namespace Elektronikai
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.varos_txtbox = new System.Windows.Forms.TextBox();
            this.iranyitoszam_txtbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // varos_txtbox
            // 
            this.varos_txtbox.Location = new System.Drawing.Point(196, 84);
            this.varos_txtbox.Name = "varos_txtbox";
            this.varos_txtbox.Size = new System.Drawing.Size(214, 20);
            this.varos_txtbox.TabIndex = 0;
            // 
            // iranyitoszam_txtbox
            // 
            this.iranyitoszam_txtbox.Location = new System.Drawing.Point(196, 130);
            this.iranyitoszam_txtbox.Name = "iranyitoszam_txtbox";
            this.iranyitoszam_txtbox.Size = new System.Drawing.Size(214, 20);
            this.iranyitoszam_txtbox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iranyitoszam_txtbox);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.varos_txtbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(331, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 250);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.label2.Location = new System.Drawing.Point(77, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "IRÁNYÍTÓSZÁM";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(355, 190);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(98, 36);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.label1.Location = new System.Drawing.Point(77, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "VÁROS";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1219, 647);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox varos_txtbox;
        private System.Windows.Forms.TextBox iranyitoszam_txtbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
    }
}
