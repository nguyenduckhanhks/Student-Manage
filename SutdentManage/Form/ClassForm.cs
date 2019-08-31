using SutdentManage.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SutdentManage
{
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
            loadClass();
        }

        void loadClass()
        {
            dgvData.DataSource = from st in Data.DataStudent.Aclasses
                                 select new
                                 {
                                     Id = st.id,
                                     Tên = st.name,
                                     Số_Lượng_Học_Sinh = st.numberOfStudents,
                                 };
            dgvData.Columns[0].Visible = false;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
            pnDetails.Enabled = false;
            btDelete.Enabled = false;
            btRepair.Enabled = false;
            btSearch.Enabled = true;
            btAdd.Enabled = true;
        }
        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                loadClassDetails(e);
                btSearch.Enabled = false;
                btAdd.Enabled = false;
                btDelete.Enabled = true;
                btRepair.Enabled = true;
                pnDetails.Enabled = true;
            }
            catch(Exception)
            {
                MessageBox.Show("error");
            }
        }
        void loadClassDetails(DataGridViewCellEventArgs e)
        {
            tbNameClass.Text = dgvData[1, e.RowIndex].Value.ToString();
            nudNumberOfStudent.Value = int.Parse(dgvData[2, e.RowIndex].Value.ToString());
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = from cl in Data.DataStudent.Aclasses
                                 where cl.name == tbName.Text
                                 select new
                                 {
                                     Id = cl.id,
                                     Tên = cl.name,
                                     Số_Lượng_Học_Sinh = cl.numberOfStudents,
                                 };
            lbTitle.Text = "Search";
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            pnDetails.Enabled = true;
            lbTitle.Text = "Add A Class";
        }

        private void BtRepair_Click(object sender, EventArgs e)
        {
            pnDetails.Enabled = true;
            lbTitle.Text = "Repair A Class";
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            pnDetails.Enabled = true;
            lbTitle.Text = "Delete A Class";
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvData.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
                if (lbTitle.Text == "Add A Class")
                {
                    ClassDAO.Instance.addClass(tbNameClass.Text, int.Parse(nudNumberOfStudent.Value.ToString()));
                    loadClass();
                }
                else if (lbTitle.Text == "Repair A Class")
                {
                    
                    ClassDAO.Instance.repairClass(id, tbNameClass.Text, int.Parse(nudNumberOfStudent.Value.ToString()));

                }
                else if (lbTitle.Text == "Delete A Class")
                {
                    ClassDAO.Instance.deleteClass(id);
                }
            }
            catch(System.Exception)
            {
                MessageBox.Show("Dữ Liệu Nhập Vào Lỗi");
            }
            
            loadClass();
        }

        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadClass();
            this.Close();
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadClass();
        }
    }
}
