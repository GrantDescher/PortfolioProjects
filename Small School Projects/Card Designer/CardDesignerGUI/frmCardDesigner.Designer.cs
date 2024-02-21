namespace CardDesignerGUI
{
    partial class frmCardDesigner
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
            this.lblOccassion = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.ddlOccassion = new System.Windows.Forms.ComboBox();
            this.ddlStyle = new System.Windows.Forms.ComboBox();
            this.cbxEnvelope = new System.Windows.Forms.CheckBox();
            this.cbxStamp = new System.Windows.Forms.CheckBox();
            this.cbxCustomMessage = new System.Windows.Forms.CheckBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCustomMessage = new System.Windows.Forms.TextBox();
            this.pbxPreview = new System.Windows.Forms.PictureBox();
            this.gbxExtras = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).BeginInit();
            this.gbxExtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOccassion
            // 
            this.lblOccassion.AutoSize = true;
            this.lblOccassion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccassion.Location = new System.Drawing.Point(46, 42);
            this.lblOccassion.Name = "lblOccassion";
            this.lblOccassion.Size = new System.Drawing.Size(117, 24);
            this.lblOccassion.TabIndex = 5;
            this.lblOccassion.Text = "Occassion";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.Location = new System.Drawing.Point(46, 104);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(59, 24);
            this.lblStyle.TabIndex = 6;
            this.lblStyle.Text = "Style";
            // 
            // ddlOccassion
            // 
            this.ddlOccassion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOccassion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlOccassion.FormattingEnabled = true;
            this.ddlOccassion.Location = new System.Drawing.Point(233, 42);
            this.ddlOccassion.Name = "ddlOccassion";
            this.ddlOccassion.Size = new System.Drawing.Size(261, 32);
            this.ddlOccassion.TabIndex = 0;
            // 
            // ddlStyle
            // 
            this.ddlStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStyle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlStyle.FormattingEnabled = true;
            this.ddlStyle.Location = new System.Drawing.Point(233, 104);
            this.ddlStyle.Name = "ddlStyle";
            this.ddlStyle.Size = new System.Drawing.Size(261, 32);
            this.ddlStyle.TabIndex = 1;
            this.ddlStyle.SelectedIndexChanged += new System.EventHandler(this.ddlStyle_SelectedIndexChanged);
            // 
            // cbxEnvelope
            // 
            this.cbxEnvelope.AutoSize = true;
            this.cbxEnvelope.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEnvelope.Location = new System.Drawing.Point(6, 19);
            this.cbxEnvelope.Name = "cbxEnvelope";
            this.cbxEnvelope.Size = new System.Drawing.Size(198, 28);
            this.cbxEnvelope.TabIndex = 0;
            this.cbxEnvelope.Text = "Envelope ($0.25)";
            this.cbxEnvelope.UseVisualStyleBackColor = true;
            // 
            // cbxStamp
            // 
            this.cbxStamp.AutoSize = true;
            this.cbxStamp.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStamp.Location = new System.Drawing.Point(6, 53);
            this.cbxStamp.Name = "cbxStamp";
            this.cbxStamp.Size = new System.Drawing.Size(168, 28);
            this.cbxStamp.TabIndex = 1;
            this.cbxStamp.Text = "Stamp ($0.50)";
            this.cbxStamp.UseVisualStyleBackColor = true;
            // 
            // cbxCustomMessage
            // 
            this.cbxCustomMessage.AutoSize = true;
            this.cbxCustomMessage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCustomMessage.Location = new System.Drawing.Point(6, 88);
            this.cbxCustomMessage.Name = "cbxCustomMessage";
            this.cbxCustomMessage.Size = new System.Drawing.Size(278, 28);
            this.cbxCustomMessage.TabIndex = 2;
            this.cbxCustomMessage.Text = "Custom Message ($0.25)";
            this.cbxCustomMessage.UseVisualStyleBackColor = true;
            this.cbxCustomMessage.CheckedChanged += new System.EventHandler(this.cbxCustomMessage_CheckedChanged);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(46, 536);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(70, 24);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "Cost: ";
            // 
            // txtCustomMessage
            // 
            this.txtCustomMessage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomMessage.Location = new System.Drawing.Point(49, 275);
            this.txtCustomMessage.Multiline = true;
            this.txtCustomMessage.Name = "txtCustomMessage";
            this.txtCustomMessage.Size = new System.Drawing.Size(445, 242);
            this.txtCustomMessage.TabIndex = 3;
            // 
            // pbxPreview
            // 
            this.pbxPreview.Location = new System.Drawing.Point(561, 134);
            this.pbxPreview.Name = "pbxPreview";
            this.pbxPreview.Size = new System.Drawing.Size(504, 383);
            this.pbxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPreview.TabIndex = 9;
            this.pbxPreview.TabStop = false;
            // 
            // gbxExtras
            // 
            this.gbxExtras.Controls.Add(this.cbxEnvelope);
            this.gbxExtras.Controls.Add(this.cbxStamp);
            this.gbxExtras.Controls.Add(this.cbxCustomMessage);
            this.gbxExtras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxExtras.Location = new System.Drawing.Point(50, 147);
            this.gbxExtras.Name = "gbxExtras";
            this.gbxExtras.Size = new System.Drawing.Size(310, 122);
            this.gbxExtras.TabIndex = 2;
            this.gbxExtras.TabStop = false;
            this.gbxExtras.Text = "Extras";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(378, 527);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 46);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmCardDesigner
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1112, 608);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbxExtras);
            this.Controls.Add(this.pbxPreview);
            this.Controls.Add(this.txtCustomMessage);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.ddlStyle);
            this.Controls.Add(this.ddlOccassion);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblOccassion);
            this.Name = "frmCardDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Designer";
            this.Load += new System.EventHandler(this.frmCardDesigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).EndInit();
            this.gbxExtras.ResumeLayout(false);
            this.gbxExtras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOccassion;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.ComboBox ddlOccassion;
        private System.Windows.Forms.ComboBox ddlStyle;
        private System.Windows.Forms.CheckBox cbxEnvelope;
        private System.Windows.Forms.CheckBox cbxStamp;
        private System.Windows.Forms.CheckBox cbxCustomMessage;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCustomMessage;
        private System.Windows.Forms.PictureBox pbxPreview;
        private System.Windows.Forms.GroupBox gbxExtras;
        private System.Windows.Forms.Button btnCalculate;
    }
}

