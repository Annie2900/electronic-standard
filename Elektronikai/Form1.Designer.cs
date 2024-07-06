namespace Elektronikai
{
    partial class Gigatron
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kosar_btn = new System.Windows.Forms.Button();
            this.vasarlasielozmenyek_btn = new System.Windows.Forms.Button();
            this.temerkmodositas_btn = new System.Windows.Forms.Button();
            this.fooldal_btn = new System.Windows.Forms.Button();
            this.foOldal1 = new Elektronikai.FoOldal();
            this.termekModositas1 = new Elektronikai.TermekModositas();
            this.vasarlasiElozmenyek1 = new Elektronikai.VasarlasiElozmenyek();
            this.kosar1 = new Elektronikai.Kosar();
            this.login1 = new Elektronikai.Login();
            this.exit_btn = new System.Windows.Forms.Button();
            this.kereses_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 82);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.panel2.Controls.Add(this.kereses_btn);
            this.panel2.Controls.Add(this.tb_search);
            this.panel2.Location = new System.Drawing.Point(864, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 33);
            this.panel2.TabIndex = 3;
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_search.Location = new System.Drawing.Point(3, 3);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(265, 27);
            this.tb_search.TabIndex = 1;
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.kosar_btn);
            this.panel3.Controls.Add(this.vasarlasielozmenyek_btn);
            this.panel3.Controls.Add(this.temerkmodositas_btn);
            this.panel3.Controls.Add(this.fooldal_btn);
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1222, 42);
            this.panel3.TabIndex = 2;
            // 
            // kosar_btn
            // 
            this.kosar_btn.Font = new System.Drawing.Font("Reem Kufi", 9F);
            this.kosar_btn.Location = new System.Drawing.Point(1032, 7);
            this.kosar_btn.Name = "kosar_btn";
            this.kosar_btn.Size = new System.Drawing.Size(173, 28);
            this.kosar_btn.TabIndex = 4;
            this.kosar_btn.Text = "KOSÁR";
            this.kosar_btn.UseVisualStyleBackColor = true;
            this.kosar_btn.Click += new System.EventHandler(this.kosar_btn_Click);
            // 
            // vasarlasielozmenyek_btn
            // 
            this.vasarlasielozmenyek_btn.Font = new System.Drawing.Font("Reem Kufi", 9F);
            this.vasarlasielozmenyek_btn.Location = new System.Drawing.Point(370, 7);
            this.vasarlasielozmenyek_btn.Name = "vasarlasielozmenyek_btn";
            this.vasarlasielozmenyek_btn.Size = new System.Drawing.Size(173, 28);
            this.vasarlasielozmenyek_btn.TabIndex = 3;
            this.vasarlasielozmenyek_btn.Text = "VÁSÁRLÁSI ELŐZMÉNYEK";
            this.vasarlasielozmenyek_btn.UseVisualStyleBackColor = true;
            this.vasarlasielozmenyek_btn.Click += new System.EventHandler(this.vasarlasielozmenyek_btn_Click);
            // 
            // temerkmodositas_btn
            // 
            this.temerkmodositas_btn.Font = new System.Drawing.Font("Reem Kufi", 9F);
            this.temerkmodositas_btn.Location = new System.Drawing.Point(191, 7);
            this.temerkmodositas_btn.Name = "temerkmodositas_btn";
            this.temerkmodositas_btn.Size = new System.Drawing.Size(173, 28);
            this.temerkmodositas_btn.TabIndex = 1;
            this.temerkmodositas_btn.Text = "TERMÉK MÓDOSÍTÁS";
            this.temerkmodositas_btn.UseVisualStyleBackColor = true;
            this.temerkmodositas_btn.Click += new System.EventHandler(this.temerkmodositas_btn_Click);
            // 
            // fooldal_btn
            // 
            this.fooldal_btn.Font = new System.Drawing.Font("Reem Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fooldal_btn.Location = new System.Drawing.Point(12, 7);
            this.fooldal_btn.Name = "fooldal_btn";
            this.fooldal_btn.Size = new System.Drawing.Size(173, 28);
            this.fooldal_btn.TabIndex = 0;
            this.fooldal_btn.Text = "FŐOLDAL";
            this.fooldal_btn.UseVisualStyleBackColor = true;
            this.fooldal_btn.Click += new System.EventHandler(this.fooldal_btn_Click);
            // 
            // foOldal1
            // 
            this.foOldal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foOldal1.ForeColor = System.Drawing.SystemColors.Control;
            this.foOldal1.Location = new System.Drawing.Point(0, 123);
            this.foOldal1.Name = "foOldal1";
            this.foOldal1.Size = new System.Drawing.Size(1219, 647);
            this.foOldal1.TabIndex = 3;
            // 
            // termekModositas1
            // 
            this.termekModositas1.Location = new System.Drawing.Point(0, 123);
            this.termekModositas1.Name = "termekModositas1";
            this.termekModositas1.Size = new System.Drawing.Size(1219, 647);
            this.termekModositas1.TabIndex = 4;
            // 
            // vasarlasiElozmenyek1
            // 
            this.vasarlasiElozmenyek1.Location = new System.Drawing.Point(0, 123);
            this.vasarlasiElozmenyek1.Name = "vasarlasiElozmenyek1";
            this.vasarlasiElozmenyek1.Size = new System.Drawing.Size(1219, 647);
            this.vasarlasiElozmenyek1.TabIndex = 5;
            // 
            // kosar1
            // 
            this.kosar1.Location = new System.Drawing.Point(0, 123);
            this.kosar1.Name = "kosar1";
            this.kosar1.Size = new System.Drawing.Size(1219, 647);
            this.kosar1.TabIndex = 6;
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(0, 123);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1219, 647);
            this.login1.TabIndex = 7;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.exit_btn.BackgroundImage = global::Elektronikai.Properties.Resources.letter;
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_btn.Location = new System.Drawing.Point(1180, 23);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Padding = new System.Windows.Forms.Padding(2);
            this.exit_btn.Size = new System.Drawing.Size(33, 33);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // kereses_btn
            // 
            this.kereses_btn.BackColor = System.Drawing.Color.Transparent;
            this.kereses_btn.BackgroundImage = global::Elektronikai.Properties.Resources.search_icon_png_21;
            this.kereses_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kereses_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kereses_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kereses_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.kereses_btn.Location = new System.Drawing.Point(271, 3);
            this.kereses_btn.Margin = new System.Windows.Forms.Padding(0);
            this.kereses_btn.Name = "kereses_btn";
            this.kereses_btn.Size = new System.Drawing.Size(25, 25);
            this.kereses_btn.TabIndex = 2;
            this.kereses_btn.UseVisualStyleBackColor = false;
            this.kereses_btn.Click += new System.EventHandler(this.kereses_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Elektronikai.Properties.Resources.gigatron_logo_fb1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 57);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Gigatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1220, 770);
            this.Controls.Add(this.foOldal1);
            this.Controls.Add(this.termekModositas1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.vasarlasiElozmenyek1);
            this.Controls.Add(this.kosar1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gigatron";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button kereses_btn;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button vasarlasielozmenyek_btn;
        private System.Windows.Forms.Button temerkmodositas_btn;
        private System.Windows.Forms.Button fooldal_btn;
        private FoOldal foOldal1;
        private TermekModositas termekModositas1;
        private VasarlasiElozmenyek vasarlasiElozmenyek1;
        private Kosar kosar1;
        private System.Windows.Forms.Button kosar_btn;
        private Login login1;
        private System.Windows.Forms.Button exit_btn;
    }
}

