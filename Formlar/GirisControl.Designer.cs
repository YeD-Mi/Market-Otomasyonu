
namespace borsaProjesi
{
    partial class GirisControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisControl));
            this.Exit_btn = new System.Windows.Forms.Button();
            this.uyegir_rb = new System.Windows.Forms.RadioButton();
            this.admingir_rb = new System.Windows.Forms.RadioButton();
            this.adminsifre = new System.Windows.Forms.Label();
            this.adminnick = new System.Windows.Forms.Label();
            this.password_admin = new System.Windows.Forms.TextBox();
            this.username_admin = new System.Windows.Forms.TextBox();
            this.giris_btn = new System.Windows.Forms.Button();
            this.anagorsel_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sign_up_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.anagorsel_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit_btn.Location = new System.Drawing.Point(27, 342);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(90, 42);
            this.Exit_btn.TabIndex = 9;
            this.Exit_btn.Text = "Çıkış";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // uyegir_rb
            // 
            this.uyegir_rb.AutoSize = true;
            this.uyegir_rb.Location = new System.Drawing.Point(49, 82);
            this.uyegir_rb.Name = "uyegir_rb";
            this.uyegir_rb.Size = new System.Drawing.Size(87, 21);
            this.uyegir_rb.TabIndex = 2;
            this.uyegir_rb.TabStop = true;
            this.uyegir_rb.Text = "Üye Giriş";
            this.uyegir_rb.UseVisualStyleBackColor = true;
            // 
            // admingir_rb
            // 
            this.admingir_rb.AutoSize = true;
            this.admingir_rb.Location = new System.Drawing.Point(142, 82);
            this.admingir_rb.Name = "admingir_rb";
            this.admingir_rb.Size = new System.Drawing.Size(101, 21);
            this.admingir_rb.TabIndex = 3;
            this.admingir_rb.TabStop = true;
            this.admingir_rb.Text = "Admin Giriş";
            this.admingir_rb.UseVisualStyleBackColor = true;
            // 
            // adminsifre
            // 
            this.adminsifre.AutoSize = true;
            this.adminsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminsifre.Location = new System.Drawing.Point(12, 201);
            this.adminsifre.Name = "adminsifre";
            this.adminsifre.Size = new System.Drawing.Size(54, 20);
            this.adminsifre.TabIndex = 6;
            this.adminsifre.Text = "Şifre: ";
            // 
            // adminnick
            // 
            this.adminnick.AutoSize = true;
            this.adminnick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminnick.Location = new System.Drawing.Point(12, 141);
            this.adminnick.Name = "adminnick";
            this.adminnick.Size = new System.Drawing.Size(58, 20);
            this.adminnick.TabIndex = 4;
            this.adminnick.Text = "K.Adı: ";
            // 
            // password_admin
            // 
            this.password_admin.BackColor = System.Drawing.SystemColors.Window;
            this.password_admin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_admin.Location = new System.Drawing.Point(77, 189);
            this.password_admin.Margin = new System.Windows.Forms.Padding(4);
            this.password_admin.Multiline = true;
            this.password_admin.Name = "password_admin";
            this.password_admin.PasswordChar = '*';
            this.password_admin.Size = new System.Drawing.Size(166, 33);
            this.password_admin.TabIndex = 7;
            // 
            // username_admin
            // 
            this.username_admin.BackColor = System.Drawing.SystemColors.Window;
            this.username_admin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_admin.Location = new System.Drawing.Point(77, 141);
            this.username_admin.Margin = new System.Windows.Forms.Padding(4);
            this.username_admin.Multiline = true;
            this.username_admin.Name = "username_admin";
            this.username_admin.Size = new System.Drawing.Size(166, 30);
            this.username_admin.TabIndex = 5;
            // 
            // giris_btn
            // 
            this.giris_btn.BackColor = System.Drawing.SystemColors.Window;
            this.giris_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.giris_btn.FlatAppearance.BorderSize = 0;
            this.giris_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.giris_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.giris_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.giris_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.giris_btn.Location = new System.Drawing.Point(27, 274);
            this.giris_btn.Margin = new System.Windows.Forms.Padding(4);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(205, 42);
            this.giris_btn.TabIndex = 8;
            this.giris_btn.Tag = "";
            this.giris_btn.Text = "Giriş";
            this.giris_btn.UseVisualStyleBackColor = false;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // anagorsel_pic
            // 
            this.anagorsel_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anagorsel_pic.BackgroundImage")));
            this.anagorsel_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.anagorsel_pic.Location = new System.Drawing.Point(262, 10);
            this.anagorsel_pic.Name = "anagorsel_pic";
            this.anagorsel_pic.Size = new System.Drawing.Size(586, 442);
            this.anagorsel_pic.TabIndex = 13;
            this.anagorsel_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alış-Satış Platformu";
            // 
            // sign_up_btn
            // 
            this.sign_up_btn.BackColor = System.Drawing.SystemColors.Window;
            this.sign_up_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sign_up_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_up_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.sign_up_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sign_up_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sign_up_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.sign_up_btn.Location = new System.Drawing.Point(139, 342);
            this.sign_up_btn.Margin = new System.Windows.Forms.Padding(4);
            this.sign_up_btn.Name = "sign_up_btn";
            this.sign_up_btn.Size = new System.Drawing.Size(90, 42);
            this.sign_up_btn.TabIndex = 10;
            this.sign_up_btn.Text = "Üye Ol";
            this.sign_up_btn.UseVisualStyleBackColor = false;
            this.sign_up_btn.Click += new System.EventHandler(this.sign_up_btn_Click);
            // 
            // GirisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 464);
            this.Controls.Add(this.sign_up_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anagorsel_pic);
            this.Controls.Add(this.adminsifre);
            this.Controls.Add(this.adminnick);
            this.Controls.Add(this.password_admin);
            this.Controls.Add(this.username_admin);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.admingir_rb);
            this.Controls.Add(this.uyegir_rb);
            this.Controls.Add(this.Exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GirisControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisControl";
            this.Load += new System.EventHandler(this.GirisControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anagorsel_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.RadioButton uyegir_rb;
        private System.Windows.Forms.RadioButton admingir_rb;
        private System.Windows.Forms.Label adminsifre;
        private System.Windows.Forms.Label adminnick;
        private System.Windows.Forms.TextBox password_admin;
        private System.Windows.Forms.TextBox username_admin;
        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.PictureBox anagorsel_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sign_up_btn;
    }
}