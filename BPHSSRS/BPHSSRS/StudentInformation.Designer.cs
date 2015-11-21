namespace BPHSSRS
{
    partial class frmStudentInformation
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstStudentInfoMst = new System.Windows.Forms.ListView();
            this.hdrSimSchoolId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrSimFamilyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrSimGivenName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrSimMiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSchoolId = new System.Windows.Forms.TextBox();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtCitizenship = new System.Windows.Forms.TextBox();
            this.hdrSimGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrSimHomeAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrSimDateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrSimTelNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrSimCitizenship = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lstStudentInfoMst, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(923, 629);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lstStudentInfoMst
            // 
            this.lstStudentInfoMst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrSimSchoolId,
            this.hdrSimFamilyName,
            this.hdrSimGivenName,
            this.hdrSimMiddleName,
            this.hdrSimGender,
            this.hdrSimHomeAddress,
            this.hdrSimDateOfBirth,
            this.hdrSimTelNo,
            this.hdrSimCitizenship});
            this.lstStudentInfoMst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStudentInfoMst.FullRowSelect = true;
            this.lstStudentInfoMst.GridLines = true;
            this.lstStudentInfoMst.Location = new System.Drawing.Point(4, 275);
            this.lstStudentInfoMst.Margin = new System.Windows.Forms.Padding(4);
            this.lstStudentInfoMst.Name = "lstStudentInfoMst";
            this.lstStudentInfoMst.Size = new System.Drawing.Size(915, 350);
            this.lstStudentInfoMst.TabIndex = 0;
            this.lstStudentInfoMst.UseCompatibleStateImageBehavior = false;
            this.lstStudentInfoMst.View = System.Windows.Forms.View.Details;
            // 
            // hdrSimSchoolId
            // 
            this.hdrSimSchoolId.Text = "School ID";
            this.hdrSimSchoolId.Width = 90;
            // 
            // hdrSimFamilyName
            // 
            this.hdrSimFamilyName.Text = "Family Name";
            this.hdrSimFamilyName.Width = 166;
            // 
            // hdrSimGivenName
            // 
            this.hdrSimGivenName.Text = "Given Name";
            this.hdrSimGivenName.Width = 186;
            // 
            // hdrSimMiddleName
            // 
            this.hdrSimMiddleName.Text = "Middle Name";
            this.hdrSimMiddleName.Width = 166;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 226);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(915, 41);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(653, 4);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 33);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(786, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtSchoolId, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtFamilyName, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtGivenName, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtMiddleName, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label9, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.label10, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtHomeAddress, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtGender, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtDateOfBirth, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtTelNo, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCitizenship, 4, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 66);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(915, 152);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(31, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "School ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(31, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Family Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(31, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Given Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(31, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Middle Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSchoolId
            // 
            this.txtSchoolId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchoolId.Location = new System.Drawing.Point(191, 4);
            this.txtSchoolId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSchoolId.Name = "txtSchoolId";
            this.txtSchoolId.Size = new System.Drawing.Size(259, 22);
            this.txtSchoolId.TabIndex = 4;
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFamilyName.Location = new System.Drawing.Point(191, 35);
            this.txtFamilyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(259, 22);
            this.txtFamilyName.TabIndex = 5;
            // 
            // txtGivenName
            // 
            this.txtGivenName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGivenName.Location = new System.Drawing.Point(191, 66);
            this.txtGivenName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(259, 22);
            this.txtGivenName.TabIndex = 6;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMiddleName.Location = new System.Drawing.Point(191, 97);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(259, 22);
            this.txtMiddleName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(458, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Home Address:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(458, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date of Birth:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(31, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Gender:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(458, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 31);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tel No:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(458, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 31);
            this.label10.TabIndex = 9;
            this.label10.Text = "Citizenship:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(915, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Information Entry Sheet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(617, 3);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(260, 22);
            this.txtHomeAddress.TabIndex = 10;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(190, 127);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(260, 22);
            this.txtGender.TabIndex = 11;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(617, 34);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(260, 22);
            this.txtDateOfBirth.TabIndex = 12;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(617, 65);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(260, 22);
            this.txtTelNo.TabIndex = 13;
            // 
            // txtCitizenship
            // 
            this.txtCitizenship.Location = new System.Drawing.Point(617, 96);
            this.txtCitizenship.Name = "txtCitizenship";
            this.txtCitizenship.Size = new System.Drawing.Size(260, 22);
            this.txtCitizenship.TabIndex = 14;
            // 
            // hdrSimGender
            // 
            this.hdrSimGender.Text = "Gender";
            // 
            // hdrSimHomeAddress
            // 
            this.hdrSimHomeAddress.Text = "Home Address";
            this.hdrSimHomeAddress.Width = 200;
            // 
            // hdrSimDateOfBirth
            // 
            this.hdrSimDateOfBirth.Text = "Date of Birth";
            // 
            // hdrSimTelNo
            // 
            this.hdrSimTelNo.Text = "Tel No";
            // 
            // hdrSimCitizenship
            // 
            this.hdrSimCitizenship.Text = "Citizenship";
            // 
            // frmStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudentInformation";
            this.Text = "Student Information Master";
            this.Load += new System.EventHandler(this.frmStudentInformation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lstStudentInfoMst;
        private System.Windows.Forms.ColumnHeader hdrSimSchoolId;
        private System.Windows.Forms.ColumnHeader hdrSimFamilyName;
        private System.Windows.Forms.ColumnHeader hdrSimGivenName;
        private System.Windows.Forms.ColumnHeader hdrSimMiddleName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSchoolId;
        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.TextBox txtGivenName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader hdrSimGender;
        private System.Windows.Forms.ColumnHeader hdrSimHomeAddress;
        private System.Windows.Forms.ColumnHeader hdrSimDateOfBirth;
        private System.Windows.Forms.ColumnHeader hdrSimTelNo;
        private System.Windows.Forms.ColumnHeader hdrSimCitizenship;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtCitizenship;
    }
}