namespace BrTube_Download
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxUrl = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboResolucao = new MetroFramework.Controls.MetroComboBox();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.lblPercentage = new MetroFramework.Controls.MetroLabel();
            this.metroButtonStart = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDiretorio = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "URL:";
            // 
            // metroTextBoxUrl
            // 
            this.metroTextBoxUrl.Location = new System.Drawing.Point(98, 82);
            this.metroTextBoxUrl.Name = "metroTextBoxUrl";
            this.metroTextBoxUrl.Size = new System.Drawing.Size(266, 23);
            this.metroTextBoxUrl.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Resolução:";
            // 
            // cboResolucao
            // 
            this.cboResolucao.FormattingEnabled = true;
            this.cboResolucao.ItemHeight = 23;
            this.cboResolucao.Items.AddRange(new object[] {
            "360",
            "480",
            "720"});
            this.cboResolucao.Location = new System.Drawing.Point(98, 148);
            this.cboResolucao.Name = "cboResolucao";
            this.cboResolucao.Size = new System.Drawing.Size(266, 29);
            this.cboResolucao.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(98, 188);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(266, 10);
            this.progressBar.TabIndex = 3;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(25, 184);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(27, 19);
            this.lblPercentage.TabIndex = 0;
            this.lblPercentage.Text = "0%";
            // 
            // metroButtonStart
            // 
            this.metroButtonStart.Location = new System.Drawing.Point(289, 210);
            this.metroButtonStart.Name = "metroButtonStart";
            this.metroButtonStart.Size = new System.Drawing.Size(75, 23);
            this.metroButtonStart.TabIndex = 4;
            this.metroButtonStart.Text = "Iniciar";
            this.metroButtonStart.Click += new System.EventHandler(this.metroButtonStart_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 239);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(144, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "© Cidronio de Oliveira";
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Enabled = false;
            this.txtDiretorio.Location = new System.Drawing.Point(98, 115);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(222, 23);
            this.txtDiretorio.TabIndex = 7;
            this.txtDiretorio.Text = "C:\\Users\\CIDRONIO\\Desktop";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 115);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Local:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(328, 115);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(36, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "...";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BrTube_Download.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(331, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 48);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 266);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButtonStart);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cboResolucao);
            this.Controls.Add(this.metroTextBoxUrl);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "BR-TUBE DOWNLOAD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUrl;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboResolucao;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroLabel lblPercentage;
        private MetroFramework.Controls.MetroButton metroButtonStart;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDiretorio;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

