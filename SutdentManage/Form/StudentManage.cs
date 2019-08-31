using SutdentManage.DAO;
using SutdentManage.Provider;
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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
            loadDataStudent();
        }

        void loadDataStudent()
        {
            dgvData.DataSource = from st in Data.DataStudent.Astudents
                                 select new
                                 {
                                     Id = st.id,
                                     Idclass = st.idClass,
                                     Tên = st.name,
                                     Ngày_sinh = st.dateOfbirth,
                                     Lớp = st.Aclass.name,
                                     Số_điện_thoại = st.telephone,
                                     Email = st.email,
                                     Giới_tính = st.male,
                                     Toán = st.mathPoint,
                                     Lý = st.physicalPoint,
                                     Hóa = st.chemicalPoint,
                                 }; 
            dgvData.Columns["Id"].Visible = false;
            dgvData.Columns["Idclass"].Visible = false;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btDelete.Enabled = false;
            btRepair.Enabled = false;
            pnDetails.Enabled = false;
            btAdd.Enabled = true;
            Search.Enabled = true;

            cbClass.Items.Clear();
            var lst = Data.DataStudent.Aclasses.Select(p => p).ToList();
            foreach(var item in lst)
            {
                cbClass.Items.Add(item.name);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            loadDataStudent();
            lbTitle.Text = "Search";
            dgvData.DataSource = from st in Data.DataStudent.Astudents
                                 where st.name == tbName.Text
                                 select new
                                 {
                                     Id = st.id,
                                     Idclass = st.idClass,
                                     Tên = st.name,
                                     Ngày_sinh = st.dateOfbirth,
                                     Số_điện_thoại = st.telephone,
                                     Email = st.email,
                                     Giới_tính = st.male,
                                     Toán = st.mathPoint,
                                     Lý = st.physicalPoint,
                                     Hóa = st.chemicalPoint,
                                 };
            dgvData.Columns["Id"].Visible = false;
            dgvData.Columns["Idclass"].Visible = false;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            loadDataStudent();
            lbTitle.Text = "Add Student";
            pnDetails.Enabled = true;
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btAdd.Enabled = false;
                btDelete.Enabled = true;
                btRepair.Enabled = true;
                pnDetails.Enabled = true;
                loadDataDetails(e);
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
           
        }

        private void loadDataDetails(DataGridViewCellEventArgs e)
        {
            string idClass = dgvData.SelectedCells[0].OwningRow.Cells["Idclass"].Value.ToString();
            Aclass cl = Data.DataStudent.Aclasses.Where(p => p.id.Equals(idClass)).SingleOrDefault();

            string id = dgvData.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
            Astudent st = Data.DataStudent.Astudents.Where(p => p.id.Equals(id)).SingleOrDefault();

            cbClass.Text = cl.name;
            tbNameDetail.Text = st.name;
            dtpDateOfBirth.Value = st.dateOfbirth;
            tbTelephone.Text = st.telephone;
            tbEmail.Text = st.email;

            cbMale.Text = "Male";
            if (st.male == 0) cbMale.Text = "Female";

            tbMath.Text = st.mathPoint.ToString();
            tbPhysical.Text = st.physicalPoint.ToString();
            tbChemistry.Text = st.chemicalPoint.ToString();
        }

        private void BtRepair_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Repair Class Of Student";
            pnDetails.Enabled = true;
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Delete A Student";
            pnDetails.Enabled = true;
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            try
            {
                Aclass cl = Data.DataStudent.Aclasses.Where(p => p.name.Equals(cbClass.Text)).SingleOrDefault();
                string idclass = cl.id;

                if (lbTitle.Text == "Add Student")
                {
                    StudentDAO.Instance.addStudent(idclass, tbNameDetail.Text, dtpDateOfBirth.Value, tbTelephone.Text, tbEmail.Text, 
                        cbMale.Text, float.Parse(tbMath.Text), float.Parse(tbPhysical.Text), float.Parse(tbChemistry.Text));  
                }
                else if (lbTitle.Text == "Repair Class Of Student")
                {
                    string id = dgvData.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
                    StudentDAO.Instance.repairStudent(id, idclass, tbNameDetail.Text, dtpDateOfBirth.Value, tbTelephone.Text, tbEmail.Text,
                        cbMale.Text, float.Parse(tbMath.Text), float.Parse(tbPhysical.Text), float.Parse(tbChemistry.Text));
                }
                else if (lbTitle.Text == "Delete A Student")
                {
                    string id = dgvData.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
                    StudentDAO.Instance.deleteStudent(id);
                }
            }
            catch(System.Exception)
            {
                MessageBox.Show("Dữ Liệu Nhập Vào Lỗi");
            }
            
            loadDataStudent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            loadDataStudent();
        }

        private void ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadDataStudent();
            this.Hide();
            ClassForm clf = new ClassForm();
            clf.ShowDialog();
            this.Show();
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadDataStudent();
        }
    }
}
