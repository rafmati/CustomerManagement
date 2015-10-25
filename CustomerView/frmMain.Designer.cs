namespace CustomerView
{
    partial class frmMain
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbCustomerMgmt = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtCustomerTotalDebt = new System.Windows.Forms.TextBox();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.txtCustomerPersonalNum = new System.Windows.Forms.TextBox();
            this.lblCustomerPersonNumber = new System.Windows.Forms.Label();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.gridCostumer = new System.Windows.Forms.DataGridView();
            this.richTxtNote = new System.Windows.Forms.RichTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.gbCustomerMgmt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCostumer)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.txtUserPassword);
            this.gbLogin.Controls.Add(this.lblPassword);
            this.gbLogin.Controls.Add(this.txtUserName);
            this.gbLogin.Controls.Add(this.lblUserName);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbLogin.Location = new System.Drawing.Point(0, 0);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(866, 85);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(69, 54);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.ShortcutsEnabled = false;
            this.txtUserPassword.Size = new System.Drawing.Size(100, 20);
            this.txtUserPassword.TabIndex = 1;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 57);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(69, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 31);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Name";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(175, 28);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gbCustomerMgmt
            // 
            this.gbCustomerMgmt.Controls.Add(this.btnRefresh);
            this.gbCustomerMgmt.Controls.Add(this.btnSearch);
            this.gbCustomerMgmt.Controls.Add(this.btnSave);
            this.gbCustomerMgmt.Controls.Add(this.btnNew);
            this.gbCustomerMgmt.Controls.Add(this.txtCustomerTotalDebt);
            this.gbCustomerMgmt.Controls.Add(this.lblTotalDebt);
            this.gbCustomerMgmt.Controls.Add(this.txtCustomerPersonalNum);
            this.gbCustomerMgmt.Controls.Add(this.lblCustomerPersonNumber);
            this.gbCustomerMgmt.Controls.Add(this.txtCustomerLastName);
            this.gbCustomerMgmt.Controls.Add(this.lblCustomerID);
            this.gbCustomerMgmt.Controls.Add(this.txtCustomerName);
            this.gbCustomerMgmt.Controls.Add(this.lblCustomerLastName);
            this.gbCustomerMgmt.Controls.Add(this.txtCustomerID);
            this.gbCustomerMgmt.Controls.Add(this.lblCustomerName);
            this.gbCustomerMgmt.Controls.Add(this.lblNote);
            this.gbCustomerMgmt.Controls.Add(this.gridCostumer);
            this.gbCustomerMgmt.Controls.Add(this.richTxtNote);
            this.gbCustomerMgmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCustomerMgmt.Enabled = false;
            this.gbCustomerMgmt.Location = new System.Drawing.Point(0, 85);
            this.gbCustomerMgmt.Name = "gbCustomerMgmt";
            this.gbCustomerMgmt.Size = new System.Drawing.Size(866, 407);
            this.gbCustomerMgmt.TabIndex = 1;
            this.gbCustomerMgmt.TabStop = false;
            this.gbCustomerMgmt.Text = "Customer management";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(200, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "S&earch";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(200, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(200, 36);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtCustomerTotalDebt
            // 
            this.txtCustomerTotalDebt.Location = new System.Drawing.Point(94, 131);
            this.txtCustomerTotalDebt.Name = "txtCustomerTotalDebt";
            this.txtCustomerTotalDebt.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerTotalDebt.TabIndex = 7;
            this.txtCustomerTotalDebt.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.Location = new System.Drawing.Point(12, 134);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(57, 13);
            this.lblTotalDebt.TabIndex = 11;
            this.lblTotalDebt.Text = "Total Debt";
            // 
            // txtCustomerPersonalNum
            // 
            this.txtCustomerPersonalNum.Location = new System.Drawing.Point(94, 107);
            this.txtCustomerPersonalNum.Name = "txtCustomerPersonalNum";
            this.txtCustomerPersonalNum.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerPersonalNum.TabIndex = 6;
            this.txtCustomerPersonalNum.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblCustomerPersonNumber
            // 
            this.lblCustomerPersonNumber.AutoSize = true;
            this.lblCustomerPersonNumber.Location = new System.Drawing.Point(12, 110);
            this.lblCustomerPersonNumber.Name = "lblCustomerPersonNumber";
            this.lblCustomerPersonNumber.Size = new System.Drawing.Size(73, 13);
            this.lblCustomerPersonNumber.TabIndex = 9;
            this.lblCustomerPersonNumber.Text = "Personal Num";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(94, 84);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerLastName.TabIndex = 5;
            this.txtCustomerLastName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 41);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(18, 13);
            this.lblCustomerID.TabIndex = 7;
            this.lblCustomerID.Text = "ID";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(94, 61);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Location = new System.Drawing.Point(12, 87);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(58, 13);
            this.lblCustomerLastName.TabIndex = 5;
            this.lblCustomerLastName.Text = "Last Name";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(94, 38);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 64);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Name";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(278, 16);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(35, 13);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Notes";
            // 
            // gridCostumer
            // 
            this.gridCostumer.AllowUserToAddRows = false;
            this.gridCostumer.AllowUserToDeleteRows = false;
            this.gridCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCostumer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCostumer.Location = new System.Drawing.Point(3, 175);
            this.gridCostumer.Name = "gridCostumer";
            this.gridCostumer.ReadOnly = true;
            this.gridCostumer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCostumer.Size = new System.Drawing.Size(860, 229);
            this.gridCostumer.TabIndex = 1;
            this.gridCostumer.SelectionChanged += new System.EventHandler(this.gridCostumer_SelectionChanged);
            // 
            // richTxtNote
            // 
            this.richTxtNote.Location = new System.Drawing.Point(281, 36);
            this.richTxtNote.Name = "richTxtNote";
            this.richTxtNote.Size = new System.Drawing.Size(582, 133);
            this.richTxtNote.TabIndex = 8;
            this.richTxtNote.Text = "";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(200, 122);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 492);
            this.Controls.Add(this.gbCustomerMgmt);
            this.Controls.Add(this.gbLogin);
            this.Name = "frmMain";
            this.Text = " Customer Management";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbCustomerMgmt.ResumeLayout(false);
            this.gbCustomerMgmt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCostumer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox gbCustomerMgmt;
        private System.Windows.Forms.RichTextBox richTxtNote;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblTotalDebt;
        private System.Windows.Forms.Label lblCustomerPersonNumber;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtCustomerTotalDebt;
        private System.Windows.Forms.TextBox txtCustomerPersonalNum;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.DataGridView gridCostumer;
        private System.Windows.Forms.Button btnRefresh;
    }
}