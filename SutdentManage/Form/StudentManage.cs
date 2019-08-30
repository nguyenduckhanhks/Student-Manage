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
            string id = dgvData.SelectedCells[0].OwningRow.Cells["Idclass"].Value.ToString();
            Aclass st = Data.DataStudent.Aclasses.Where(p => p.id.Equals(id)).SingleOrDefault();
            cbClass.Text = st.name;
            tbNameDetail.Text = dgvData[2, e.RowIndex].Value.ToString();
            dtpDateOfBirth.Value = DateTimeProvider.Instance.convertStringToDate(dgvData[3, e.RowIndex].Value.ToString());
            tbTelephone.Text = dgvData[4, e.RowIndex].Value.ToString();
            tbEmail.Text = dgvData[5, e.RowIndex].Value.ToString();

            cbMale.Text = dgvData[6, e.RowIndex].Value.ToString();
            if (cbMale.Text == "1") cbMale.Text = "Male"; else cbMale.Text = "Female";

            tbMath.Text = dgvData[7, e.RowIndex].Value.ToString();
            tbPhysical.Text=dgvData[8, e.RowIndex].Value.ToString();
            tbChemistry.Text = dgvData[9, e.RowIndex].Value.ToString();
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
                string name = tbNameDetail.Text;
                DateTime dateOfBirth = dtpDateOfBirth.Value;
                string telephone = tbTelephone.Text;
                string email = tbEmail.Text;
                int male = 0;
                if (cbMale.Text == "Male") male = 1;
                float math = float.Parse(tbMath.Text);
                float physic = float.Parse(tbPhysical.Text);
                float chemical = float.Parse(tbChemistry.Text);
                if (lbTitle.Text == "Add Student")
                {
                    string id = RandomIdProvide.Instance.CreateId();
                    Astudent st = new Astudent();
                    st.id = id;
                    st.idClass = idclass;
                    st.dateOfbirth = dateOfBirth;
                    st.name = name;
                    st.telephone = telephone;
                    st.email = email;
                    st.male = male;
                    st.mathPoint = math;
                    st.physicalPoint = physic;
                    st.chemicalPoint = chemical;

                    Data.DataStudent.Astudents.InsertOnSubmit(st);
                    Data.DataStudent.SubmitChanges();
                    
                }
                else if (lbTitle.Text == "Repair Class Of Student")
                {
                    string id = dgvData.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();

                    Astudent st = Data.DataStudent.Astudents.Where(p => p.id.Equals(id)).SingleOrDefault();

                    st.idClass = idclass;
                    st.dateOfbirth = dateOfBirth;
                    st.name = name;
                    st.telephone = telephone;
                    st.email = email;
                    st.male = male;
                    st.mathPoint = math;
                    st.physicalPoint = physic;
                    st.chemicalPoint = chemical;

                    Data.DataStudent.SubmitChanges();
                }
                else if (lbTitle.Text == "Delete A Student")
                {
                    string id = dgvData.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();

                    Astudent st = Data.DataStudent.Astudents.Where(p => p.id.Equals(id)).SingleOrDefault();

                    Data.DataStudent.Astudents.DeleteOnSubmit(st);
                    Data.DataStudent.SubmitChanges();
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
