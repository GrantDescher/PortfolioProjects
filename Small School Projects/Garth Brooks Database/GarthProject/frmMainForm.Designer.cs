namespace GarthProject
{
    partial class frmMainForm
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
            this.btnSplashScreen = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dgvAlbums = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splashScreenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumSearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlbumSearch = new System.Windows.Forms.Button();
            this.txtAlbumSearch = new System.Windows.Forms.TextBox();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.dgvAlbumFacts = new System.Windows.Forms.DataGridView();
            this.lblAlbumList = new System.Windows.Forms.Label();
            this.lblSongList = new System.Windows.Forms.Label();
            this.lblAlbumFacts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumFacts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSplashScreen
            // 
            this.btnSplashScreen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSplashScreen.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplashScreen.Location = new System.Drawing.Point(1148, 46);
            this.btnSplashScreen.Name = "btnSplashScreen";
            this.btnSplashScreen.Size = new System.Drawing.Size(178, 64);
            this.btnSplashScreen.TabIndex = 20;
            this.btnSplashScreen.Text = "SplashScreen";
            this.btnSplashScreen.UseVisualStyleBackColor = true;
            this.btnSplashScreen.Click += new System.EventHandler(this.btnSplashScreen_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.Location = new System.Drawing.Point(276, 46);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(178, 64);
            this.btnLoadData.TabIndex = 19;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dgvAlbums
            // 
            this.dgvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbums.Location = new System.Drawing.Point(276, 138);
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.Size = new System.Drawing.Size(1050, 279);
            this.dgvAlbums.TabIndex = 21;
            this.dgvAlbums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbums_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splashScreenToolStripMenuItem1,
            this.loadDataMenuItem,
            this.albumSearchMenuItem,
            this.helpMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1543, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splashScreenToolStripMenuItem1
            // 
            this.splashScreenToolStripMenuItem1.Name = "splashScreenToolStripMenuItem1";
            this.splashScreenToolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.splashScreenToolStripMenuItem1.Text = "SplashScreen";
            this.splashScreenToolStripMenuItem1.Click += new System.EventHandler(this.splashScreenToolStripMenuItem1_Click);
            // 
            // loadDataMenuItem
            // 
            this.loadDataMenuItem.Name = "loadDataMenuItem";
            this.loadDataMenuItem.Size = new System.Drawing.Size(72, 20);
            this.loadDataMenuItem.Text = "Load Data";
            this.loadDataMenuItem.Click += new System.EventHandler(this.loadDataMenuItem_Click);
            // 
            // albumSearchMenuItem
            // 
            this.albumSearchMenuItem.Name = "albumSearchMenuItem";
            this.albumSearchMenuItem.Size = new System.Drawing.Size(93, 20);
            this.albumSearchMenuItem.Text = "Album Search";
            this.albumSearchMenuItem.Click += new System.EventHandler(this.albumSearchMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "Help";
            this.helpMenuItem.Click += new System.EventHandler(this.helpMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // btnAlbumSearch
            // 
            this.btnAlbumSearch.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbumSearch.Location = new System.Drawing.Point(460, 46);
            this.btnAlbumSearch.Name = "btnAlbumSearch";
            this.btnAlbumSearch.Size = new System.Drawing.Size(178, 64);
            this.btnAlbumSearch.TabIndex = 23;
            this.btnAlbumSearch.Text = "Album Search";
            this.btnAlbumSearch.UseVisualStyleBackColor = true;
            this.btnAlbumSearch.Click += new System.EventHandler(this.btnAlbumSearch_Click);
            // 
            // txtAlbumSearch
            // 
            this.txtAlbumSearch.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbumSearch.Location = new System.Drawing.Point(654, 46);
            this.txtAlbumSearch.Multiline = true;
            this.txtAlbumSearch.Name = "txtAlbumSearch";
            this.txtAlbumSearch.Size = new System.Drawing.Size(475, 64);
            this.txtAlbumSearch.TabIndex = 24;
            // 
            // dgvSongs
            // 
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Location = new System.Drawing.Point(276, 448);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.Size = new System.Drawing.Size(1050, 150);
            this.dgvSongs.TabIndex = 27;
            // 
            // dgvAlbumFacts
            // 
            this.dgvAlbumFacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumFacts.Location = new System.Drawing.Point(276, 632);
            this.dgvAlbumFacts.Name = "dgvAlbumFacts";
            this.dgvAlbumFacts.Size = new System.Drawing.Size(1050, 150);
            this.dgvAlbumFacts.TabIndex = 28;
            // 
            // lblAlbumList
            // 
            this.lblAlbumList.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumList.Location = new System.Drawing.Point(59, 138);
            this.lblAlbumList.Name = "lblAlbumList";
            this.lblAlbumList.Size = new System.Drawing.Size(168, 36);
            this.lblAlbumList.TabIndex = 29;
            this.lblAlbumList.Text = "Album List";
            // 
            // lblSongList
            // 
            this.lblSongList.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongList.Location = new System.Drawing.Point(59, 448);
            this.lblSongList.Name = "lblSongList";
            this.lblSongList.Size = new System.Drawing.Size(168, 36);
            this.lblSongList.TabIndex = 30;
            this.lblSongList.Text = "Song List";
            // 
            // lblAlbumFacts
            // 
            this.lblAlbumFacts.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumFacts.Location = new System.Drawing.Point(59, 632);
            this.lblAlbumFacts.Name = "lblAlbumFacts";
            this.lblAlbumFacts.Size = new System.Drawing.Size(185, 36);
            this.lblAlbumFacts.TabIndex = 31;
            this.lblAlbumFacts.Text = "Album Facts";
            // 
            // frmMainForm
            // 
            this.AcceptButton = this.btnLoadData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnSplashScreen;
            this.ClientSize = new System.Drawing.Size(1543, 809);
            this.Controls.Add(this.lblAlbumFacts);
            this.Controls.Add(this.lblSongList);
            this.Controls.Add(this.lblAlbumList);
            this.Controls.Add(this.dgvAlbumFacts);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.txtAlbumSearch);
            this.Controls.Add(this.btnAlbumSearch);
            this.Controls.Add(this.dgvAlbums);
            this.Controls.Add(this.btnSplashScreen);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garth Brooks DB Project - Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumFacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSplashScreen;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dgvAlbums;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splashScreenToolStripMenuItem1;
        private System.Windows.Forms.Button btnAlbumSearch;
        private System.Windows.Forms.ToolStripMenuItem albumSearchMenuItem;
        private System.Windows.Forms.TextBox txtAlbumSearch;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.DataGridView dgvAlbumFacts;
        private System.Windows.Forms.Label lblAlbumList;
        private System.Windows.Forms.Label lblSongList;
        private System.Windows.Forms.Label lblAlbumFacts;
    }
}