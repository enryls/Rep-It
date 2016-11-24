using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rep_It
{
    partial class Form1
    {

        private Button confirm;
        private TextBox txtBoxNumExec;
        private Label lblMessageTimer;
        private Timer timer1;
        private TextBox txtBoxTimer;
        private Label lblTimer;
        private Label lblNumExec;
        private Label lblInterval;
        private TextBox txtBoxInterval;
        private PictureBox pictureBoxLogo;
        private Panel panel1;
        private Label lblGithubPage;
        private TextBox txtBoxKeyStore;
        private Label lblKeyStore;
        private Button btnRestoreKey;
        private PictureBox pictureBoxGLogoLink;

        //Override ProcessCmdKey method
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //If the input is not selected select it
            if (restoreIt)
            {
                //If is no special character set the input as text of Textbox4
                if (keyData != Keys.Enter && keyData != Keys.Space)
                {
                    txtBoxKeyStore.Text = keyData.ToString();
                }
                //otherwise set the correct string for the input
                else
                    checkKey(keyData);
            }
            //When the input is selected restoreIt variable is set to false
            restoreIt = false;

            //Exit with Escape key 
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Assign the correct value of "special" case to the input for perform repetition
        private void checkKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    txtBoxKeyStore.Text = "{ENTER}";
                    break;
                case Keys.Space:
                    txtBoxKeyStore.Text = " ";
                    break;

            }
        }

        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.confirm = new System.Windows.Forms.Button();
            this.txtBoxNumExec = new System.Windows.Forms.TextBox();
            this.lblMessageTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBoxTimer = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblNumExec = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.txtBoxInterval = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxGLogoLink = new System.Windows.Forms.PictureBox();
            this.lblGithubPage = new System.Windows.Forms.Label();
            this.txtBoxKeyStore = new System.Windows.Forms.TextBox();
            this.lblKeyStore = new System.Windows.Forms.Label();
            this.btnRestoreKey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGLogoLink)).BeginInit();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.LightGray;
            this.confirm.Location = new System.Drawing.Point(150, 300);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(185, 65);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // txtBoxNumExec
            // 
            this.txtBoxNumExec.Location = new System.Drawing.Point(280, 120);
            this.txtBoxNumExec.Name = "txtBoxNumExec";
            this.txtBoxNumExec.Size = new System.Drawing.Size(185, 23);
            this.txtBoxNumExec.TabIndex = 1;
            // 
            // lblMessageTimer
            // 
            this.lblMessageTimer.AutoSize = true;
            this.lblMessageTimer.Location = new System.Drawing.Point(150, 382);
            this.lblMessageTimer.Name = "lblMessageTimer";
            this.lblMessageTimer.Size = new System.Drawing.Size(0, 15);
            this.lblMessageTimer.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtBoxTimer
            // 
            this.txtBoxTimer.Location = new System.Drawing.Point(280, 240);
            this.txtBoxTimer.Name = "txtBoxTimer";
            this.txtBoxTimer.Size = new System.Drawing.Size(185, 23);
            this.txtBoxTimer.TabIndex = 2;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(280, 220);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(37, 15);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "Timer";
            // 
            // lblNumExec
            // 
            this.lblNumExec.AutoSize = true;
            this.lblNumExec.Location = new System.Drawing.Point(280, 100);
            this.lblNumExec.Name = "lblNumExec";
            this.lblNumExec.Size = new System.Drawing.Size(114, 15);
            this.lblNumExec.TabIndex = 6;
            this.lblNumExec.Text = "Number of execution";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(40, 220);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(45, 15);
            this.lblInterval.TabIndex = 7;
            this.lblInterval.Text = "Interval";
            // 
            // txtBoxInterval
            // 
            this.txtBoxInterval.Location = new System.Drawing.Point(40, 240);
            this.txtBoxInterval.Name = "txtBoxInterval";
            this.txtBoxInterval.Size = new System.Drawing.Size(185, 23);
            this.txtBoxInterval.TabIndex = 3;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(192, -14);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pictureBoxGLogoLink);
            this.panel1.Controls.Add(this.lblGithubPage);
            this.panel1.Location = new System.Drawing.Point(-1, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 52);
            this.panel1.TabIndex = 10;
            // 
            // pictureBoxGLogoLink
            // 
            this.pictureBoxGLogoLink.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGLogoLink.Image")));
            this.pictureBoxGLogoLink.Location = new System.Drawing.Point(339, 15);
            this.pictureBoxGLogoLink.Name = "pictureBoxGLogoLink";
            this.pictureBoxGLogoLink.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxGLogoLink.TabIndex = 13;
            this.pictureBoxGLogoLink.TabStop = false;
            this.pictureBoxGLogoLink.Click += new System.EventHandler(this.pictureBoxGLogoLink_Click);
            // 
            // lblGithubPage
            // 
            this.lblGithubPage.AutoSize = true;
            this.lblGithubPage.Location = new System.Drawing.Point(124, 23);
            this.lblGithubPage.Name = "lblGithubPage";
            this.lblGithubPage.Size = new System.Drawing.Size(212, 15);
            this.lblGithubPage.TabIndex = 11;
            this.lblGithubPage.Text = "Download and Contribute to the Code on";
            // 
            // txtBoxKeyStore
            // 
            this.txtBoxKeyStore.HideSelection = false;
            this.txtBoxKeyStore.Location = new System.Drawing.Point(40, 120);
            this.txtBoxKeyStore.Name = "txtBoxKeyStore";
            this.txtBoxKeyStore.ReadOnly = true;
            this.txtBoxKeyStore.Size = new System.Drawing.Size(185, 23);
            this.txtBoxKeyStore.TabIndex = 0;
            // 
            // lblKeyStore
            // 
            this.lblKeyStore.AutoSize = true;
            this.lblKeyStore.Location = new System.Drawing.Point(40, 100);
            this.lblKeyStore.Name = "lblKeyStore";
            this.lblKeyStore.Size = new System.Drawing.Size(135, 15);
            this.lblKeyStore.TabIndex = 11;
            this.lblKeyStore.Text = "Press the Key for Store It";
            // 
            // btnRestoreKey
            // 
            this.btnRestoreKey.Location = new System.Drawing.Point(40, 170);
            this.btnRestoreKey.Name = "btnRestoreKey";
            this.btnRestoreKey.Size = new System.Drawing.Size(142, 23);
            this.btnRestoreKey.TabIndex = 12;
            this.btnRestoreKey.Text = "Click for Restore the Key";
            this.btnRestoreKey.UseVisualStyleBackColor = true;
            this.btnRestoreKey.Click += new System.EventHandler(this.btnRestoreKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(502, 461);
            this.Controls.Add(this.btnRestoreKey);
            this.Controls.Add(this.lblKeyStore);
            this.Controls.Add(this.txtBoxKeyStore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.txtBoxInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblNumExec);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.txtBoxTimer);
            this.Controls.Add(this.lblMessageTimer);
            this.Controls.Add(this.txtBoxNumExec);
            this.Controls.Add(this.confirm);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "REP-IT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGLogoLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

    }
}

