using SutdentManage.DAO;
using SutdentManage.DataProvide;
using SutdentManage.DTO;
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
            dgvData.DataSource = StudentDAO.Instance.getStudents();
            btDelete.Enabled = false;
            btRepair.Enabled = false;
            pnDetails.Enabled = false;
            btAdd.Enabled = true;
            Search.Enabled = true;

            cbClass.Items.Clear();
            foreach(DataRow item in ClassDAO.Instance.getClass().Rows)
            {
                cbClass.Items.Add(item["name"]);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            loadDataStudent();
            lbTitle.Text = "Search";
            dgvData.DataSource = StudentDAO.Instance.findStudent(tbName.Text);
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            loadDataStudent();
            lbTitle.Text = "Add Student";
            pnDetails.Enabled = true;
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btAdd.Enabled = false;
            btDelete.Enabled = true;
            btRepair.Enabled = true;
            pnDetails.Enabled = true;
            loadDataDetails(e);
        }

        private void loadDataDetails(DataGridViewCellEventArgs e)
        {
            lbId.Text = dgvData[0, e.RowIndex].Value.ToString();
            cbClass.Text = ClassDAO.Instance.findClass(dgvData[1, e.RowIndex].Value.ToString()).Rows[0]["name"].ToString();
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
            loadDataStudent();
            lbTitle.Text = "Repair Class Of Student";
            pnDetails.Enabled = true;
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            loadDataStudent();
            lbTitle.Text = "Delete A Student";
            pnDetails.Enabled = true;
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbTitle.Text == "Add Student")
                {
                    Student student = new Student(ClassDAO.Instance.findClass("", cbClass.Text).Rows[0]["id"].ToString(), tbNameDetail.Text,
                        dtpDateOfBirth.Value.ToString("yyyMMdd"), tbTelephone.Text, tbEmail.Text, cbMale.Text, float.Parse(tbMath.Text),
                        float.Parse(tbPhysical.Text), float.Parse(tbChemistry.Text));

                    StudentDAO.Instance.insertStudent(student);
                }
                else if (lbTitle.Text == "Search")
                {
                    dgvData.DataSource = StudentDAO.Instance.findStudent(tbName.Text);
                }
                else if (lbTitle.Text == "Repair Class Of Student")
                {
                    StudentDAO.Instance.repairStudent(lbId.Text, cbClass.Text);
                }
                else if (lbTitle.Text == "Delete A Student")
                {
                    StudentDAO.Instance.deleteStudent(lbId.Text, cbClass.Text);
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
