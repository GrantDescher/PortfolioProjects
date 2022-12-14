namespace LB1_FlashCards
{
    partial class frmFlashCards
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
            this.btnDefine = new System.Windows.Forms.Button();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.lblWhatTerm = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.lblNewTerm = new System.Windows.Forms.Label();
            this.txtNewDefinition = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDefine
            // 
            this.btnDefine.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefine.Location = new System.Drawing.Point(493, 66);
            this.btnDefine.Name = "btnDefine";
            this.btnDefine.Size = new System.Drawing.Size(114, 33);
            this.btnDefine.TabIndex = 1;
            this.btnDefine.Text = "Define";
            this.btnDefine.UseVisualStyleBackColor = true;
            this.btnDefine.Click += new System.EventHandler(this.btnDefine_Click);
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTerm.Location = new System.Drawing.Point(47, 86);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(416, 32);
            this.txtSearchTerm.TabIndex = 0;
            this.txtSearchTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWhatTerm
            // 
            this.lblWhatTerm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblWhatTerm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatTerm.Location = new System.Drawing.Point(43, 53);
            this.lblWhatTerm.Name = "lblWhatTerm";
            this.lblWhatTerm.Size = new System.Drawing.Size(420, 23);
            this.lblWhatTerm.TabIndex = 5;
            this.lblWhatTerm.Text = " What Term Do You Want Me To Define?";
            this.lblWhatTerm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(639, 66);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 33);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDefinition
            // 
            this.lblDefinition.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDefinition.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefinition.Location = new System.Drawing.Point(47, 171);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(560, 120);
            this.lblDefinition.TabIndex = 6;
            this.lblDefinition.Text = " ";
            this.lblDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewTerm
            // 
            this.lblNewTerm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNewTerm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTerm.Location = new System.Drawing.Point(51, 322);
            this.lblNewTerm.Name = "lblNewTerm";
            this.lblNewTerm.Size = new System.Drawing.Size(556, 23);
            this.lblNewTerm.TabIndex = 7;
            this.lblNewTerm.Text = " I Don\'t Know That Term Yet. What Does It Mean?";
            this.lblNewTerm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewDefinition
            // 
            this.txtNewDefinition.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewDefinition.Location = new System.Drawing.Point(51, 376);
            this.txtNewDefinition.Name = "txtNewDefinition";
            this.txtNewDefinition.Size = new System.Drawing.Size(556, 32);
            this.txtNewDefinition.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(639, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmFlashCards
            // 
            this.AcceptButton = this.btnDefine;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewDefinition);
            this.Controls.Add(this.lblNewTerm);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblWhatTerm);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.btnDefine);
            this.Name = "frmFlashCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Cards";
            this.Load += new System.EventHandler(this.frmFlashCards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDefine;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Label lblWhatTerm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.Label lblNewTerm;
        private System.Windows.Forms.TextBox txtNewDefinition;
        private System.Windows.Forms.Button btnAdd;
    }
}

