namespace RectificadoraGarz
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnAcceso = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(411, 281);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(239, 19);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿HAS OLVIDADO LA CONTRASEÑA?";
            // 
            // btnAcceso
            // 
            this.btnAcceso.BackColor = System.Drawing.Color.Brown;
            this.btnAcceso.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnAcceso.FlatAppearance.BorderSize = 0;
            this.btnAcceso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnAcceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceso.ForeColor = System.Drawing.Color.White;
            this.btnAcceso.Location = new System.Drawing.Point(311, 200);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(400, 40);
            this.btnAcceso.TabIndex = 9;
            this.btnAcceso.Text = "ACCEDER";
            this.btnAcceso.UseVisualStyleBackColor = false;
            this.btnAcceso.Click += new System.EventHandler(this.btnAcceso_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Brown;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(457, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(92, 36);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "LOGIN";
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.BackColor = System.Drawing.Color.Brown;
            this.txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasena.ForeColor = System.Drawing.Color.White;
            this.txtcontrasena.Location = new System.Drawing.Point(311, 137);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(400, 20);
            this.txtcontrasena.TabIndex = 7;
            this.txtcontrasena.Text = "CONTRASEÑA";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.Brown;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.Location = new System.Drawing.Point(311, 88);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(400, 20);
            this.txtuser.TabIndex = 6;
            this.txtuser.Text = "USUARIO";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(760, 330);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAcceso);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnAcceso;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}