namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lbVname = new System.Windows.Forms.Label();
            this.lbNname = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbVname = new System.Windows.Forms.TextBox();
            this.tbNname = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.libPerson = new System.Windows.Forms.ListBox();
            this.progBCount = new System.Windows.Forms.ProgressBar();
            this.cbPerson = new System.Windows.Forms.ComboBox();
            this.picBLogo = new System.Windows.Forms.PictureBox();
            this.picBPerson = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personendaten";
            // 
            // lbVname
            // 
            this.lbVname.AutoSize = true;
            this.lbVname.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVname.Location = new System.Drawing.Point(45, 223);
            this.lbVname.Name = "lbVname";
            this.lbVname.Size = new System.Drawing.Size(70, 15);
            this.lbVname.TabIndex = 1;
            this.lbVname.Text = "Vorname :";
            // 
            // lbNname
            // 
            this.lbNname.AutoSize = true;
            this.lbNname.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNname.Location = new System.Drawing.Point(45, 257);
            this.lbNname.Name = "lbNname";
            this.lbNname.Size = new System.Drawing.Size(77, 15);
            this.lbNname.TabIndex = 2;
            this.lbNname.Text = "Nachname :";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(45, 291);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 15);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "email :";
            // 
            // tbVname
            // 
            this.tbVname.Location = new System.Drawing.Point(181, 221);
            this.tbVname.Name = "tbVname";
            this.tbVname.Size = new System.Drawing.Size(208, 20);
            this.tbVname.TabIndex = 4;
            // 
            // tbNname
            // 
            this.tbNname.Location = new System.Drawing.Point(181, 255);
            this.tbNname.Name = "tbNname";
            this.tbNname.Size = new System.Drawing.Size(208, 20);
            this.tbNname.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(181, 289);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(208, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(290, 341);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(99, 36);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Speichern";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // libPerson
            // 
            this.libPerson.FormattingEnabled = true;
            this.libPerson.Location = new System.Drawing.Point(453, 256);
            this.libPerson.Name = "libPerson";
            this.libPerson.Size = new System.Drawing.Size(191, 121);
            this.libPerson.TabIndex = 8;
            this.libPerson.SelectedIndexChanged += new System.EventHandler(this.libPerson_SelectedIndexChanged);
            // 
            // progBCount
            // 
            this.progBCount.Location = new System.Drawing.Point(48, 145);
            this.progBCount.Maximum = 5;
            this.progBCount.Name = "progBCount";
            this.progBCount.Size = new System.Drawing.Size(136, 11);
            this.progBCount.TabIndex = 9;
            // 
            // cbPerson
            // 
            this.cbPerson.FormattingEnabled = true;
            this.cbPerson.Location = new System.Drawing.Point(453, 220);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(191, 21);
            this.cbPerson.TabIndex = 10;
            this.cbPerson.SelectedIndexChanged += new System.EventHandler(this.cbPerson_SelectedIndexChanged);
            // 
            // picBLogo
            // 
            this.picBLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBLogo.Image")));
            this.picBLogo.Location = new System.Drawing.Point(558, 12);
            this.picBLogo.Name = "picBLogo";
            this.picBLogo.Size = new System.Drawing.Size(86, 78);
            this.picBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBLogo.TabIndex = 11;
            this.picBLogo.TabStop = false;
            // 
            // picBPerson
            // 
            this.picBPerson.Location = new System.Drawing.Point(521, 119);
            this.picBPerson.Name = "picBPerson";
            this.picBPerson.Size = new System.Drawing.Size(123, 95);
            this.picBPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBPerson.TabIndex = 12;
            this.picBPerson.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 460);
            this.Controls.Add(this.picBPerson);
            this.Controls.Add(this.picBLogo);
            this.Controls.Add(this.cbPerson);
            this.Controls.Add(this.progBCount);
            this.Controls.Add(this.libPerson);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNname);
            this.Controls.Add(this.tbVname);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNname);
            this.Controls.Add(this.lbVname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVname;
        private System.Windows.Forms.Label lbNname;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbVname;
        private System.Windows.Forms.TextBox tbNname;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ListBox libPerson;
        private System.Windows.Forms.ProgressBar progBCount;
        private System.Windows.Forms.ComboBox cbPerson;
        private System.Windows.Forms.PictureBox picBLogo;
        private System.Windows.Forms.PictureBox picBPerson;
    }
}

