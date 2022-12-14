namespace HOT7
{
    partial class frmBankLoan
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
            this.gbxCreateLoan = new System.Windows.Forms.GroupBox();
            this.gbxManageLoan = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblManageName = new System.Windows.Forms.Label();
            this.lblManageType = new System.Windows.Forms.Label();
            this.lblManageAmount = new System.Windows.Forms.Label();
            this.lblAmountAfterPayment = new System.Windows.Forms.Label();
            this.lblAmountAfterInterest = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.radShortTerm = new System.Windows.Forms.RadioButton();
            this.radLongTerm = new System.Windows.Forms.RadioButton();
            this.gbxCreateLoan.SuspendLayout();
            this.gbxManageLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCreateLoan
            // 
            this.gbxCreateLoan.Controls.Add(this.radLongTerm);
            this.gbxCreateLoan.Controls.Add(this.radShortTerm);
            this.gbxCreateLoan.Controls.Add(this.btnClear);
            this.gbxCreateLoan.Controls.Add(this.btnCreateLoan);
            this.gbxCreateLoan.Controls.Add(this.txtAmount);
            this.gbxCreateLoan.Controls.Add(this.txtName);
            this.gbxCreateLoan.Controls.Add(this.lblType);
            this.gbxCreateLoan.Controls.Add(this.lblAmount);
            this.gbxCreateLoan.Controls.Add(this.lblName);
            this.gbxCreateLoan.Location = new System.Drawing.Point(39, 13);
            this.gbxCreateLoan.Name = "gbxCreateLoan";
            this.gbxCreateLoan.Size = new System.Drawing.Size(708, 189);
            this.gbxCreateLoan.TabIndex = 0;
            this.gbxCreateLoan.TabStop = false;
            this.gbxCreateLoan.Text = "Create Loan";
            // 
            // gbxManageLoan
            // 
            this.gbxManageLoan.Controls.Add(this.btnExit);
            this.gbxManageLoan.Controls.Add(this.btnMakePayment);
            this.gbxManageLoan.Controls.Add(this.lblAmountAfterInterest);
            this.gbxManageLoan.Controls.Add(this.lblAmountAfterPayment);
            this.gbxManageLoan.Controls.Add(this.lblManageAmount);
            this.gbxManageLoan.Controls.Add(this.lblManageType);
            this.gbxManageLoan.Controls.Add(this.lblManageName);
            this.gbxManageLoan.Location = new System.Drawing.Point(39, 230);
            this.gbxManageLoan.Name = "gbxManageLoan";
            this.gbxManageLoan.Size = new System.Drawing.Size(708, 189);
            this.gbxManageLoan.TabIndex = 1;
            this.gbxManageLoan.TabStop = false;
            this.gbxManageLoan.Text = "Manage Loan";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Lime;
            this.lblName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(53, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.Lime;
            this.lblAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(53, 73);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 23);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount:";
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Lime;
            this.lblType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(53, 143);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 23);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type:";
            // 
            // lblManageName
            // 
            this.lblManageName.BackColor = System.Drawing.Color.Lime;
            this.lblManageName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageName.Location = new System.Drawing.Point(53, 36);
            this.lblManageName.Name = "lblManageName";
            this.lblManageName.Size = new System.Drawing.Size(436, 23);
            this.lblManageName.TabIndex = 2;
            // 
            // lblManageType
            // 
            this.lblManageType.BackColor = System.Drawing.Color.Lime;
            this.lblManageType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageType.Location = new System.Drawing.Point(53, 74);
            this.lblManageType.Name = "lblManageType";
            this.lblManageType.Size = new System.Drawing.Size(171, 23);
            this.lblManageType.TabIndex = 3;
            // 
            // lblManageAmount
            // 
            this.lblManageAmount.BackColor = System.Drawing.Color.Lime;
            this.lblManageAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageAmount.Location = new System.Drawing.Point(260, 74);
            this.lblManageAmount.Name = "lblManageAmount";
            this.lblManageAmount.Size = new System.Drawing.Size(229, 23);
            this.lblManageAmount.TabIndex = 4;
            // 
            // lblAmountAfterPayment
            // 
            this.lblAmountAfterPayment.BackColor = System.Drawing.Color.Lime;
            this.lblAmountAfterPayment.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountAfterPayment.Location = new System.Drawing.Point(53, 114);
            this.lblAmountAfterPayment.Name = "lblAmountAfterPayment";
            this.lblAmountAfterPayment.Size = new System.Drawing.Size(632, 23);
            this.lblAmountAfterPayment.TabIndex = 5;
            // 
            // lblAmountAfterInterest
            // 
            this.lblAmountAfterInterest.BackColor = System.Drawing.Color.Lime;
            this.lblAmountAfterInterest.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountAfterInterest.Location = new System.Drawing.Point(53, 152);
            this.lblAmountAfterInterest.Name = "lblAmountAfterInterest";
            this.lblAmountAfterInterest.Size = new System.Drawing.Size(632, 23);
            this.lblAmountAfterInterest.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(207, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(282, 29);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(207, 73);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(282, 29);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateLoan.Location = new System.Drawing.Point(529, 33);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(156, 30);
            this.btnCreateLoan.TabIndex = 4;
            this.btnCreateLoan.Text = "Create Loan";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(529, 73);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakePayment.Location = new System.Drawing.Point(529, 32);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(156, 30);
            this.btnMakePayment.TabIndex = 0;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(529, 67);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radShortTerm
            // 
            this.radShortTerm.AutoSize = true;
            this.radShortTerm.BackColor = System.Drawing.Color.Lime;
            this.radShortTerm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radShortTerm.Location = new System.Drawing.Point(207, 126);
            this.radShortTerm.Name = "radShortTerm";
            this.radShortTerm.Size = new System.Drawing.Size(184, 26);
            this.radShortTerm.TabIndex = 2;
            this.radShortTerm.TabStop = true;
            this.radShortTerm.Text = "Short Term Loan";
            this.radShortTerm.UseVisualStyleBackColor = false;
            // 
            // radLongTerm
            // 
            this.radLongTerm.AutoSize = true;
            this.radLongTerm.BackColor = System.Drawing.Color.Lime;
            this.radLongTerm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLongTerm.Location = new System.Drawing.Point(207, 157);
            this.radLongTerm.Name = "radLongTerm";
            this.radLongTerm.Size = new System.Drawing.Size(181, 26);
            this.radLongTerm.TabIndex = 3;
            this.radLongTerm.TabStop = true;
            this.radLongTerm.Text = "Long Term Loan";
            this.radLongTerm.UseVisualStyleBackColor = false;
            // 
            // frmBankLoan
            // 
            this.AcceptButton = this.btnCreateLoan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxManageLoan);
            this.Controls.Add(this.gbxCreateLoan);
            this.Name = "frmBankLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOT 7 - Bank Loan";
            this.Load += new System.EventHandler(this.frmBankLoan_Load);
            this.gbxCreateLoan.ResumeLayout(false);
            this.gbxCreateLoan.PerformLayout();
            this.gbxManageLoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCreateLoan;
        private System.Windows.Forms.RadioButton radLongTerm;
        private System.Windows.Forms.RadioButton radShortTerm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxManageLoan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblAmountAfterInterest;
        private System.Windows.Forms.Label lblAmountAfterPayment;
        private System.Windows.Forms.Label lblManageAmount;
        private System.Windows.Forms.Label lblManageType;
        private System.Windows.Forms.Label lblManageName;
    }
}

