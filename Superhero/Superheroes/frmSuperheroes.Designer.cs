namespace Superheroes
{
    partial class frmSuperheroes
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
            this.ddlSuperhero = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAlterEgo = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.picSuperheroImage = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSuperheroImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlSuperhero
            // 
            this.ddlSuperhero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSuperhero.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSuperhero.FormattingEnabled = true;
            this.ddlSuperhero.Location = new System.Drawing.Point(74, 53);
            this.ddlSuperhero.Name = "ddlSuperhero";
            this.ddlSuperhero.Size = new System.Drawing.Size(373, 32);
            this.ddlSuperhero.TabIndex = 0;
            this.ddlSuperhero.SelectedIndexChanged += new System.EventHandler(this.ddlSuperhero_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Red;
            this.lblName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(71, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(376, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name: ";
            // 
            // lblAlterEgo
            // 
            this.lblAlterEgo.BackColor = System.Drawing.Color.Red;
            this.lblAlterEgo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterEgo.Location = new System.Drawing.Point(71, 196);
            this.lblAlterEgo.Name = "lblAlterEgo";
            this.lblAlterEgo.Size = new System.Drawing.Size(376, 23);
            this.lblAlterEgo.TabIndex = 4;
            this.lblAlterEgo.Text = "Alter Ego:";
            // 
            // lblBio
            // 
            this.lblBio.BackColor = System.Drawing.Color.Red;
            this.lblBio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.Location = new System.Drawing.Point(71, 275);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(376, 435);
            this.lblBio.TabIndex = 5;
            this.lblBio.Text = "Bio: ";
            // 
            // lblURL
            // 
            this.lblURL.BackColor = System.Drawing.Color.Red;
            this.lblURL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(493, 687);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(376, 23);
            this.lblURL.TabIndex = 6;
            this.lblURL.Text = "URL: ";
            // 
            // picSuperheroImage
            // 
            this.picSuperheroImage.Location = new System.Drawing.Point(496, 53);
            this.picSuperheroImage.Name = "picSuperheroImage";
            this.picSuperheroImage.Size = new System.Drawing.Size(435, 597);
            this.picSuperheroImage.TabIndex = 5;
            this.picSuperheroImage.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(182, 748);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 47);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(604, 748);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 47);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSuperheroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(953, 825);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.picSuperheroImage);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblAlterEgo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ddlSuperhero);
            this.Name = "frmSuperheroes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Ch 9 Superheroes";
            this.Load += new System.EventHandler(this.frmSuperheroes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSuperheroImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlSuperhero;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAlterEgo;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.PictureBox picSuperheroImage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

