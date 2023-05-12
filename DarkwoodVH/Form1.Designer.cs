namespace DarkwoodVH
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
            this.btnInstall1 = new System.Windows.Forms.Button();
            this.btnInstall2 = new System.Windows.Forms.Button();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.lbfolderPath = new System.Windows.Forms.Label();
            this.BtnBrowseB = new System.Windows.Forms.Button();
            this.btnBrowseM = new System.Windows.Forms.Button();
            this.btnInstallB = new System.Windows.Forms.Button();
            this.btnInstallM = new System.Windows.Forms.Button();
            this.lbPath = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pSucceded = new System.Windows.Forms.PictureBox();
            this.pFail = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pSucceded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInstall1
            // 
            this.btnInstall1.BackColor = System.Drawing.Color.Transparent;
            this.btnInstall1.FlatAppearance.BorderSize = 0;
            this.btnInstall1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInstall1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInstall1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall1.Location = new System.Drawing.Point(723, 453);
            this.btnInstall1.Name = "btnInstall1";
            this.btnInstall1.Size = new System.Drawing.Size(460, 167);
            this.btnInstall1.TabIndex = 0;
            this.btnInstall1.UseVisualStyleBackColor = false;
            // 
            // btnInstall2
            // 
            this.btnInstall2.BackColor = System.Drawing.Color.Transparent;
            this.btnInstall2.BackgroundImage = global::DarkwoodVH.Properties.Resources.install_button;
            this.btnInstall2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstall2.FlatAppearance.BorderSize = 0;
            this.btnInstall2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInstall2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInstall2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall2.Location = new System.Drawing.Point(723, 453);
            this.btnInstall2.Name = "btnInstall2";
            this.btnInstall2.Size = new System.Drawing.Size(460, 167);
            this.btnInstall2.TabIndex = 1;
            this.btnInstall2.UseVisualStyleBackColor = false;
            this.btnInstall2.Visible = false;
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBrowse1.FlatAppearance.BorderSize = 0;
            this.btnBrowse1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBrowse1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBrowse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse1.Location = new System.Drawing.Point(586, 362);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(56, 79);
            this.btnBrowse1.TabIndex = 3;
            this.btnBrowse1.UseVisualStyleBackColor = false;
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse2.BackgroundImage = global::DarkwoodVH.Properties.Resources.folder_button;
            this.btnBrowse2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse2.FlatAppearance.BorderSize = 0;
            this.btnBrowse2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBrowse2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBrowse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse2.Image = global::DarkwoodVH.Properties.Resources.folder_button;
            this.btnBrowse2.Location = new System.Drawing.Point(761, 352);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(56, 79);
            this.btnBrowse2.TabIndex = 2;
            this.btnBrowse2.UseVisualStyleBackColor = false;
            this.btnBrowse2.Visible = false;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // lbfolderPath
            // 
            this.lbfolderPath.Location = new System.Drawing.Point(843, 383);
            this.lbfolderPath.Name = "lbfolderPath";
            this.lbfolderPath.Size = new System.Drawing.Size(292, 23);
            this.lbfolderPath.TabIndex = 4;
            // 
            // BtnBrowseB
            // 
            this.BtnBrowseB.BackColor = System.Drawing.Color.Transparent;
            this.BtnBrowseB.FlatAppearance.BorderSize = 0;
            this.BtnBrowseB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnBrowseB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnBrowseB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowseB.Location = new System.Drawing.Point(761, 352);
            this.BtnBrowseB.Name = "BtnBrowseB";
            this.BtnBrowseB.Size = new System.Drawing.Size(56, 79);
            this.BtnBrowseB.TabIndex = 0;
            this.BtnBrowseB.UseVisualStyleBackColor = false;
            this.BtnBrowseB.MouseEnter += new System.EventHandler(this.BtnBrowseB_MouseEnter);
            // 
            // btnBrowseM
            // 
            this.btnBrowseM.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseM.BackgroundImage = global::DarkwoodVH.Properties.Resources.folder_button;
            this.btnBrowseM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseM.FlatAppearance.BorderSize = 0;
            this.btnBrowseM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBrowseM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBrowseM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseM.Location = new System.Drawing.Point(761, 352);
            this.btnBrowseM.Name = "btnBrowseM";
            this.btnBrowseM.Size = new System.Drawing.Size(56, 79);
            this.btnBrowseM.TabIndex = 1;
            this.btnBrowseM.UseVisualStyleBackColor = false;
            this.btnBrowseM.Visible = false;
            this.btnBrowseM.Click += new System.EventHandler(this.btnBrowseM_Click);
            this.btnBrowseM.MouseLeave += new System.EventHandler(this.btnBrowseM_MouseLeave);
            // 
            // btnInstallB
            // 
            this.btnInstallB.BackColor = System.Drawing.Color.Transparent;
            this.btnInstallB.FlatAppearance.BorderSize = 0;
            this.btnInstallB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInstallB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInstallB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallB.Location = new System.Drawing.Point(723, 454);
            this.btnInstallB.Name = "btnInstallB";
            this.btnInstallB.Size = new System.Drawing.Size(460, 167);
            this.btnInstallB.TabIndex = 3;
            this.btnInstallB.UseVisualStyleBackColor = false;
            this.btnInstallB.MouseEnter += new System.EventHandler(this.btnInstallB_MouseEnter);
            // 
            // btnInstallM
            // 
            this.btnInstallM.BackColor = System.Drawing.Color.Transparent;
            this.btnInstallM.BackgroundImage = global::DarkwoodVH.Properties.Resources.install_button;
            this.btnInstallM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstallM.FlatAppearance.BorderSize = 0;
            this.btnInstallM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInstallM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInstallM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallM.Location = new System.Drawing.Point(723, 454);
            this.btnInstallM.Name = "btnInstallM";
            this.btnInstallM.Size = new System.Drawing.Size(460, 167);
            this.btnInstallM.TabIndex = 2;
            this.btnInstallM.UseVisualStyleBackColor = false;
            this.btnInstallM.Visible = false;
            this.btnInstallM.Click += new System.EventHandler(this.btnInstallM_Click);
            this.btnInstallM.MouseLeave += new System.EventHandler(this.btnInstallM_MouseLeave);
            // 
            // lbPath
            // 
            this.lbPath.Location = new System.Drawing.Point(840, 383);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(293, 23);
            this.lbPath.TabIndex = 4;
            this.lbPath.MouseHover += new System.EventHandler(this.lbPath_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pSucceded
            // 
            this.pSucceded.BackColor = System.Drawing.Color.Transparent;
            this.pSucceded.BackgroundImage = global::DarkwoodVH.Properties.Resources.succeeded;
            this.pSucceded.Location = new System.Drawing.Point(379, 285);
            this.pSucceded.Name = "pSucceded";
            this.pSucceded.Size = new System.Drawing.Size(509, 146);
            this.pSucceded.TabIndex = 5;
            this.pSucceded.TabStop = false;
            this.pSucceded.Visible = false;
            // 
            // pFail
            // 
            this.pFail.BackColor = System.Drawing.Color.Transparent;
            this.pFail.BackgroundImage = global::DarkwoodVH.Properties.Resources.fail;
            this.pFail.Location = new System.Drawing.Point(379, 285);
            this.pFail.Name = "pFail";
            this.pFail.Size = new System.Drawing.Size(509, 146);
            this.pFail.TabIndex = 6;
            this.pFail.TabStop = false;
            this.pFail.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(1225, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 45);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DarkwoodVH.Properties.Resources.overview;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pFail);
            this.Controls.Add(this.pSucceded);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.btnInstallM);
            this.Controls.Add(this.btnBrowseM);
            this.Controls.Add(this.BtnBrowseB);
            this.Controls.Add(this.btnInstallB);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DarkwoodVH";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pSucceded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInstall1;
        private System.Windows.Forms.Button btnInstall2;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Label lbfolderPath;
        private System.Windows.Forms.Button BtnBrowseB;
        private System.Windows.Forms.Button btnBrowseM;
        private System.Windows.Forms.Button btnInstallB;
        private System.Windows.Forms.Button btnInstallM;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pSucceded;
        private System.Windows.Forms.PictureBox pFail;
        private System.Windows.Forms.Button btnExit;
    }
}

