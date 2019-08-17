namespace SutdentManage
{
    partial class ClassForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.btRepair = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.pnDetails = new System.Windows.Forms.Panel();
            this.lbId = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.nudNumberOfStudent = new System.Windows.Forms.NumericUpDown();
            this.btCancle = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNameClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.pnDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfStudent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btDelete);
            this.panel3.Controls.Add(this.btRepair);
            this.panel3.Controls.Add(this.btAdd);
            this.panel3.Controls.Add(this.btSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 597);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1267, 63);
            this.panel3.TabIndex = 8;
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
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(34, 13);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 33);
            this.btSearch.TabIndex = 0;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // pnDetails
            // 
            this.pnDetails.Controls.Add(this.lbId);
            this.pnDetails.Controls.Add(this.lb);
            this.pnDetails.Controls.Add(this.nudNumberOfStudent);
            this.pnDetails.Controls.Add(this.btCancle);
            this.pnDetails.Controls.Add(this.btOk);
            this.pnDetails.Controls.Add(this.label8);
            this.pnDetails.Controls.Add(this.tbNameClass);
            this.pnDetails.Controls.Add(this.label1);
            this.pnDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDetails.Location = new System.Drawing.Point(920, 0);
            this.pnDetails.Name = "pnDetails";
            this.pnDetails.Size = new System.Drawing.Size(347, 597);
            this.pnDetails.TabIndex = 9;
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbId.Enabled = false;
            this.lbId.Location = new System.Drawing.Point(150, 25);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(185, 20);
            this.lbId.TabIndex = 28;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Enabled = false;
            this.lb.Location = new System.Drawing.Point(10, 28);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(23, 17);
            this.lb.TabIndex = 27;
            this.lb.Text = "Id:";
            // 
            // nudNumberOfStudent
            // 
            this.nudNumberOfStudent.Location = new System.Drawing.Point(208, 112);
            this.nudNumberOfStudent.Name = "nudNumberOfStudent";
            this.nudNumberOfStudent.Size = new System.Drawing.Size(120, 22);
            this.nudNumberOfStudent.TabIndex = 24;
            // 
            // btCancle
            // 
            this.btCancle.Location = new System.Drawing.Point(234, 188);
            this.btCancle.Name = "btCancle";
            this.btCancle.Size = new System.Drawing.Size(75, 33);
            this.btCancle.TabIndex = 23;
            this.btCancle.Text = "Cancel";
            this.btCancle.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(69, 188);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 33);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.BtOk_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Number Of Student:";
            // 
            // tbNameClass
            // 
            this.tbNameClass.Location = new System.Drawing.Point(150, 73);
            this.tbNameClass.Name = "tbNameClass";
            this.tbNameClass.Size = new System.Drawing.Size(188, 22);
            this.tbNameClass.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
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
            this.menuStrip1.Size = new System.Drawing.Size(920, 28);
            this.menuStrip1.TabIndex = 10;
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
            this.panel1.Controls.Add(this.dgvData);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbSearch);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 569);
            this.panel1.TabIndex = 11;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(8, 118);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(906, 445);
            this.dgvData.TabIndex = 6;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(194, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(211, 22);
            this.tbName.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(99, 79);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
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
            this.lbTitle.Size = new System.Drawing.Size(91, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Class";
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnDetails);
            this.Controls.Add(this.panel3);
            this.Name = "ClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class";
            this.panel3.ResumeLayout(false);
            this.pnDetails.ResumeLayout(false);
            this.pnDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfStudent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btRepair;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Panel pnDetails;
        private System.Windows.Forms.NumericUpDown nudNumberOfStudent;
        private System.Windows.Forms.Button btCancle;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNameClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lb;
    }
}