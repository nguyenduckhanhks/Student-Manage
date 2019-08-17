namespace SutdentManage
{
    partial class student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.btRepair = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.pnDetails = new System.Windows.Forms.Panel();
            this.cbMale = new System.Windows.Forms.ComboBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.tbChemistry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPhysical = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameDetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1318, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.classToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.StudentToolStripMenuItem_Click);
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.classToolStripMenuItem.Text = "Class";
            this.classToolStripMenuItem.Click += new System.EventHandler(this.ClassToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.ThoátToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbSearch);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 654);
            this.panel1.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(204, 89);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(475, 27);
            this.tbName.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(109, 89);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(53, 20);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(3, 45);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(81, 25);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "Search:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(369, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(121, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Student";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvData);
            this.panel2.Location = new System.Drawing.Point(3, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 455);
            this.panel2.TabIndex = 2;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(867, 455);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btDelete);
            this.panel3.Controls.Add(this.btRepair);
            this.panel3.Controls.Add(this.btAdd);
            this.panel3.Controls.Add(this.Search);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 619);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1318, 63);
            this.panel3.TabIndex = 2;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(659, 15);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 33);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // btRepair
            // 
            this.btRepair.Location = new System.Drawing.Point(436, 15);
            this.btRepair.Name = "btRepair";
            this.btRepair.Size = new System.Drawing.Size(75, 33);
            this.btRepair.TabIndex = 2;
            this.btRepair.Text = "Repair";
            this.btRepair.UseVisualStyleBackColor = true;
            this.btRepair.Click += new System.EventHandler(this.BtRepair_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(234, 15);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 33);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(34, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 33);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // pnDetails
            // 
            this.pnDetails.Controls.Add(this.cbMale);
            this.pnDetails.Controls.Add(this.lbId);
            this.pnDetails.Controls.Add(this.lb);
            this.pnDetails.Controls.Add(this.cbClass);
            this.pnDetails.Controls.Add(this.button2);
            this.pnDetails.Controls.Add(this.btOk);
            this.pnDetails.Controls.Add(this.tbChemistry);
            this.pnDetails.Controls.Add(this.label8);
            this.pnDetails.Controls.Add(this.tbPhysical);
            this.pnDetails.Controls.Add(this.label7);
            this.pnDetails.Controls.Add(this.label6);
            this.pnDetails.Controls.Add(this.dtpDateOfBirth);
            this.pnDetails.Controls.Add(this.tbMath);
            this.pnDetails.Controls.Add(this.label5);
            this.pnDetails.Controls.Add(this.tbEmail);
            this.pnDetails.Controls.Add(this.label4);
            this.pnDetails.Controls.Add(this.tbTelephone);
            this.pnDetails.Controls.Add(this.label3);
            this.pnDetails.Controls.Add(this.label2);
            this.pnDetails.Controls.Add(this.tbNameDetail);
            this.pnDetails.Controls.Add(this.label1);
            this.pnDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDetails.Location = new System.Drawing.Point(876, 28);
            this.pnDetails.Name = "pnDetails";
            this.pnDetails.Size = new System.Drawing.Size(442, 591);
            this.pnDetails.TabIndex = 2;
            // 
            // cbMale
            // 
            this.cbMale.FormattingEnabled = true;
            this.cbMale.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbMale.Location = new System.Drawing.Point(363, 59);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(76, 28);
            this.cbMale.TabIndex = 27;
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbId.Enabled = false;
            this.lbId.Location = new System.Drawing.Point(97, 17);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(342, 20);
            this.lbId.TabIndex = 26;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Enabled = false;
            this.lb.Location = new System.Drawing.Point(6, 17);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(27, 20);
            this.lb.TabIndex = 25;
            this.lb.Text = "Id:";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(102, 102);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(337, 28);
            this.cbClass.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(39, 526);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 33);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.BtOk_Click);
            // 
            // tbChemistry
            // 
            this.tbChemistry.Location = new System.Drawing.Point(102, 447);
            this.tbChemistry.Name = "tbChemistry";
            this.tbChemistry.Size = new System.Drawing.Size(211, 27);
            this.tbChemistry.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Chemistry:";
            // 
            // tbPhysical
            // 
            this.tbPhysical.Location = new System.Drawing.Point(102, 379);
            this.tbPhysical.Name = "tbPhysical";
            this.tbPhysical.Size = new System.Drawing.Size(211, 27);
            this.tbPhysical.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Physical: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Birth:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "yyyy/MM/dd";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(102, 155);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(337, 27);
            this.dtpDateOfBirth.TabIndex = 16;
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(102, 322);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(211, 27);
            this.tbMath.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Math:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(102, 264);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(337, 27);
            this.tbEmail.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email:";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(102, 218);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(337, 27);
            this.tbTelephone.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telephone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Class:";
            // 
            // tbNameDetail
            // 
            this.tbNameDetail.Location = new System.Drawing.Point(101, 59);
            this.tbNameDetail.Name = "tbNameDetail";
            this.tbNameDetail.Size = new System.Drawing.Size(256, 27);
            this.tbNameDetail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 682);
            this.Controls.Add(this.pnDetails);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Manage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnDetails.ResumeLayout(false);
            this.pnDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Panel pnDetails;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btRepair;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox tbPhysical;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox tbChemistry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.ComboBox cbMale;
    }
}

