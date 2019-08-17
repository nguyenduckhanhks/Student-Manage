using SutdentManage.DAO;
using SutdentManage.DTO;
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
            dgvData.DataSource = ClassDAO.Instance.getClass();
            pnDetails.Enabled = false;
            btDelete.Enabled = false;
            btRepair.Enabled = false;
            btSearch.Enabled = true;
            btAdd.Enabled = true;
        }
        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadClassDetails(e);
            btSearch.Enabled = false;
            btAdd.Enabled = false;
            btDelete.Enabled = true;
            btRepair.Enabled = true;
            pnDetails.Enabled = true;
        }
        void loadClassDetails(DataGridViewCellEventArgs e)
        {
            lbId.Text = dgvData[0, e.RowIndex].Value.ToString();
            tbNameClass.Text = dgvData[1, e.RowIndex].Value.ToString();
            nudNumberOfStudent.Value = int.Parse(dgvData[2, e.RowIndex].Value.ToString());
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            loadClass();
            dgvData.DataSource = ClassDAO.Instance.findClass("", tbName.Text);
            lbTitle.Text = " Search";
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            loadClass();
            pnDetails.Enabled = true;
            lbTitle.Text = "Add A Class";
        }

        private void BtRepair_Click(object sender, EventArgs e)
        {
            loadClass();
            pnDetails.Enabled = true;
            lbTitle.Text = "Repair A Class";
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            loadClass();
            pnDetails.Enabled = true;
            lbTitle.Text = "Delete A Class";
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbTitle.Text == "Add A Class")
                {
                    Class aclass = new Class(tbNameClass.Text, int.Parse(nudNumberOfStudent.Value.ToString()));
                    ClassDAO.Instance.insertClass(aclass);
                }
                else if (lbTitle.Text == "Repair A Class")
                {
                    ClassDAO.Instance.updateClass(lbId.Text, int.Parse(nudNumberOfStudent.Value.ToString()));
                }
                else if (lbTitle.Text == "Search")
                {
                    dgvData.DataSource = ClassDAO.Instance.findClass("", tbName.Text);
                }
                else if (lbTitle.Text == "Delete A Class")
                {
                    ClassDAO.Instance.deleteClass(lbId.Text);
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
    }
}
