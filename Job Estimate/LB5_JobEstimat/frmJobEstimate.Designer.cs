namespace LB5_JobEstimat
{
    partial class frmJobEstimate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHoursToComplete = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblTripFee = new System.Windows.Forms.Label();
            this.lblTotalFeeCurrent = new System.Windows.Forms.Label();
            this.lblHourlyRateCurrent = new System.Windows.Forms.Label();
            this.lblHoursToCompleteCurrent = new System.Windows.Forms.Label();
            this.lblDescriptionCurrent = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtHoursToComplete = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblNewValue = new System.Windows.Forms.Label();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(347, 447);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 67);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(652, 447);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(195, 67);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDescription.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(83, 131);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(278, 39);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoursToComplete
            // 
            this.lblHoursToComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHoursToComplete.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursToComplete.Location = new System.Drawing.Point(83, 207);
            this.lblHoursToComplete.Name = "lblHoursToComplete";
            this.lblHoursToComplete.Size = new System.Drawing.Size(278, 39);
            this.lblHoursToComplete.TabIndex = 6;
            this.lblHoursToComplete.Text = "Hours To Complete:";
            this.lblHoursToComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(83, 281);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(278, 39);
            this.lblHourlyRate.TabIndex = 7;
            this.lblHourlyRate.Text = "Hourly Rate:";
            this.lblHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalFee.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.Location = new System.Drawing.Point(83, 356);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(278, 39);
            this.lblTotalFee.TabIndex = 8;
            this.lblTotalFee.Text = "Total Fee:";
            this.lblTotalFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTripFee
            // 
            this.lblTripFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTripFee.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripFee.Location = new System.Drawing.Point(438, 356);
            this.lblTripFee.Name = "lblTripFee";
            this.lblTripFee.Size = new System.Drawing.Size(278, 39);
            this.lblTripFee.TabIndex = 10;
            this.lblTripFee.Text = "Plus Trip Fee ($35)";
            this.lblTripFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalFeeCurrent
            // 
            this.lblTotalFeeCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalFeeCurrent.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeeCurrent.Location = new System.Drawing.Point(825, 356);
            this.lblTotalFeeCurrent.Name = "lblTotalFeeCurrent";
            this.lblTotalFeeCurrent.Size = new System.Drawing.Size(278, 39);
            this.lblTotalFeeCurrent.TabIndex = 15;
            this.lblTotalFeeCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHourlyRateCurrent
            // 
            this.lblHourlyRateCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHourlyRateCurrent.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRateCurrent.Location = new System.Drawing.Point(825, 281);
            this.lblHourlyRateCurrent.Name = "lblHourlyRateCurrent";
            this.lblHourlyRateCurrent.Size = new System.Drawing.Size(278, 39);
            this.lblHourlyRateCurrent.TabIndex = 14;
            this.lblHourlyRateCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoursToCompleteCurrent
            // 
            this.lblHoursToCompleteCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHoursToCompleteCurrent.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursToCompleteCurrent.Location = new System.Drawing.Point(825, 207);
            this.lblHoursToCompleteCurrent.Name = "lblHoursToCompleteCurrent";
            this.lblHoursToCompleteCurrent.Size = new System.Drawing.Size(278, 39);
            this.lblHoursToCompleteCurrent.TabIndex = 13;
            this.lblHoursToCompleteCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescriptionCurrent
            // 
            this.lblDescriptionCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDescriptionCurrent.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionCurrent.Location = new System.Drawing.Point(825, 131);
            this.lblDescriptionCurrent.Name = "lblDescriptionCurrent";
            this.lblDescriptionCurrent.Size = new System.Drawing.Size(278, 39);
            this.lblDescriptionCurrent.TabIndex = 12;
            this.lblDescriptionCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(441, 131);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(275, 38);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoursToComplete
            // 
            this.txtHoursToComplete.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursToComplete.Location = new System.Drawing.Point(441, 204);
            this.txtHoursToComplete.Name = "txtHoursToComplete";
            this.txtHoursToComplete.Size = new System.Drawing.Size(275, 38);
            this.txtHoursToComplete.TabIndex = 1;
            this.txtHoursToComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.Location = new System.Drawing.Point(441, 281);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(275, 38);
            this.txtHourlyRate.TabIndex = 2;
            this.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNewValue
            // 
            this.lblNewValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNewValue.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewValue.Location = new System.Drawing.Point(438, 60);
            this.lblNewValue.Name = "lblNewValue";
            this.lblNewValue.Size = new System.Drawing.Size(278, 39);
            this.lblNewValue.TabIndex = 9;
            this.lblNewValue.Text = "New Value";
            this.lblNewValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblCurrentValue.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentValue.Location = new System.Drawing.Point(825, 60);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(278, 39);
            this.lblCurrentValue.TabIndex = 11;
            this.lblCurrentValue.Text = "Current Value";
            this.lblCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmJobEstimate
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1190, 570);
            this.Controls.Add(this.lblCurrentValue);
            this.Controls.Add(this.lblNewValue);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtHoursToComplete);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescriptionCurrent);
            this.Controls.Add(this.lblHoursToCompleteCurrent);
            this.Controls.Add(this.lblHourlyRateCurrent);
            this.Controls.Add(this.lblTotalFeeCurrent);
            this.Controls.Add(this.lblTripFee);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblHoursToComplete);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmJobEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWD2200 - LB5_JobEstimate Chapter 12";
            this.Load += new System.EventHandler(this.frmJobEstimate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblHoursToComplete;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label lblTripFee;
        private System.Windows.Forms.Label lblTotalFeeCurrent;
        private System.Windows.Forms.Label lblHourlyRateCurrent;
        private System.Windows.Forms.Label lblHoursToCompleteCurrent;
        private System.Windows.Forms.Label lblDescriptionCurrent;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtHoursToComplete;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label lblNewValue;
        private System.Windows.Forms.Label lblCurrentValue;
    }
}

