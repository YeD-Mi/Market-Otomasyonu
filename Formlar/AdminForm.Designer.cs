
namespace borsaProjesi
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.uruns_tabpage = new System.Windows.Forms.TabPage();
            this.Urunler_datagridview = new System.Windows.Forms.DataGridView();
            this.urunbaslik_label = new System.Windows.Forms.Label();
            this.urunler_combobox = new System.Windows.Forms.ComboBox();
            this.urunlerlistele_btn = new System.Windows.Forms.Button();
            this.urunonayla_btn = new System.Windows.Forms.Button();
            this.urunlsl = new System.Windows.Forms.Label();
            this.onaycontrol_label = new System.Windows.Forms.Label();
            this.Tarihurunkontrol_label = new System.Windows.Forms.Label();
            this.urunkodu_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanici_tabpage = new System.Windows.Forms.TabPage();
            this.Kullanicilar_datagridview = new System.Windows.Forms.DataGridView();
            this.secenekler_combobox = new System.Windows.Forms.ComboBox();
            this.baslik_label = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.onaylibakiye = new System.Windows.Forms.Label();
            this.pasifbakiye = new System.Windows.Forms.Label();
            this.parabirimibaslik = new System.Windows.Forms.Label();
            this.onayla_btn = new System.Windows.Forms.Button();
            this.donustur_btn = new System.Windows.Forms.Button();
            this.Kullanicikontrol_tarih_label = new System.Windows.Forms.Label();
            this.bakiye_txt = new System.Windows.Forms.TextBox();
            this.pasifbakiye_txt = new System.Windows.Forms.TextBox();
            this.doviz_txt = new System.Windows.Forms.TextBox();
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.kasagelir_lbl = new System.Windows.Forms.Label();
            this.adminbaslik_lbl = new System.Windows.Forms.Label();
            this.uruns_tabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Urunler_datagridview)).BeginInit();
            this.kullanici_tabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kullanicilar_datagridview)).BeginInit();
            this.adminTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.SystemColors.Window;
            this.cikis_btn.Location = new System.Drawing.Point(843, 10);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(75, 32);
            this.cikis_btn.TabIndex = 2;
            this.cikis_btn.Text = "Cikis";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // uruns_tabpage
            // 
            this.uruns_tabpage.BackColor = System.Drawing.SystemColors.Window;
            this.uruns_tabpage.Controls.Add(this.label2);
            this.uruns_tabpage.Controls.Add(this.urunkodu_txt);
            this.uruns_tabpage.Controls.Add(this.Tarihurunkontrol_label);
            this.uruns_tabpage.Controls.Add(this.onaycontrol_label);
            this.uruns_tabpage.Controls.Add(this.urunlsl);
            this.uruns_tabpage.Controls.Add(this.urunonayla_btn);
            this.uruns_tabpage.Controls.Add(this.urunlerlistele_btn);
            this.uruns_tabpage.Controls.Add(this.urunler_combobox);
            this.uruns_tabpage.Controls.Add(this.urunbaslik_label);
            this.uruns_tabpage.Controls.Add(this.Urunler_datagridview);
            this.uruns_tabpage.Location = new System.Drawing.Point(4, 29);
            this.uruns_tabpage.Margin = new System.Windows.Forms.Padding(4);
            this.uruns_tabpage.Name = "uruns_tabpage";
            this.uruns_tabpage.Padding = new System.Windows.Forms.Padding(4);
            this.uruns_tabpage.Size = new System.Drawing.Size(955, 483);
            this.uruns_tabpage.TabIndex = 1;
            this.uruns_tabpage.Text = "Ürün Kontrol";
            // 
            // Urunler_datagridview
            // 
            this.Urunler_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Urunler_datagridview.DefaultCellStyle = dataGridViewCellStyle1;
            this.Urunler_datagridview.Location = new System.Drawing.Point(168, 86);
            this.Urunler_datagridview.Margin = new System.Windows.Forms.Padding(4);
            this.Urunler_datagridview.Name = "Urunler_datagridview";
            this.Urunler_datagridview.RowHeadersWidth = 51;
            this.Urunler_datagridview.Size = new System.Drawing.Size(779, 413);
            this.Urunler_datagridview.TabIndex = 12;
            this.Urunler_datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Urunler_datagridview_CellClick);
            // 
            // urunbaslik_label
            // 
            this.urunbaslik_label.AutoSize = true;
            this.urunbaslik_label.BackColor = System.Drawing.Color.Black;
            this.urunbaslik_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.urunbaslik_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.urunbaslik_label.ForeColor = System.Drawing.Color.White;
            this.urunbaslik_label.Location = new System.Drawing.Point(15, 14);
            this.urunbaslik_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urunbaslik_label.Name = "urunbaslik_label";
            this.urunbaslik_label.Size = new System.Drawing.Size(120, 23);
            this.urunbaslik_label.TabIndex = 14;
            this.urunbaslik_label.Text = "Tüm Ürünler";
            this.urunbaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // urunler_combobox
            // 
            this.urunler_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urunler_combobox.FormattingEnabled = true;
            this.urunler_combobox.Location = new System.Drawing.Point(168, 50);
            this.urunler_combobox.Margin = new System.Windows.Forms.Padding(4);
            this.urunler_combobox.Name = "urunler_combobox";
            this.urunler_combobox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.urunler_combobox.Size = new System.Drawing.Size(272, 28);
            this.urunler_combobox.TabIndex = 16;
            // 
            // urunlerlistele_btn
            // 
            this.urunlerlistele_btn.BackColor = System.Drawing.SystemColors.Window;
            this.urunlerlistele_btn.FlatAppearance.BorderSize = 0;
            this.urunlerlistele_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.urunlerlistele_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.urunlerlistele_btn.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunlerlistele_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.urunlerlistele_btn.Location = new System.Drawing.Point(462, 46);
            this.urunlerlistele_btn.Margin = new System.Windows.Forms.Padding(4);
            this.urunlerlistele_btn.Name = "urunlerlistele_btn";
            this.urunlerlistele_btn.Size = new System.Drawing.Size(126, 36);
            this.urunlerlistele_btn.TabIndex = 18;
            this.urunlerlistele_btn.Text = "Getir";
            this.urunlerlistele_btn.UseVisualStyleBackColor = false;
            this.urunlerlistele_btn.Click += new System.EventHandler(this.Urunlerlistele_btn_Click);
            // 
            // urunonayla_btn
            // 
            this.urunonayla_btn.BackColor = System.Drawing.SystemColors.Window;
            this.urunonayla_btn.FlatAppearance.BorderSize = 0;
            this.urunonayla_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.urunonayla_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.urunonayla_btn.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunonayla_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.urunonayla_btn.Location = new System.Drawing.Point(12, 387);
            this.urunonayla_btn.Margin = new System.Windows.Forms.Padding(4);
            this.urunonayla_btn.Name = "urunonayla_btn";
            this.urunonayla_btn.Size = new System.Drawing.Size(132, 35);
            this.urunonayla_btn.TabIndex = 19;
            this.urunonayla_btn.Text = "Onayla";
            this.urunonayla_btn.UseVisualStyleBackColor = false;
            this.urunonayla_btn.Click += new System.EventHandler(this.Urunonayla_btn_Click);
            // 
            // urunlsl
            // 
            this.urunlsl.AutoSize = true;
            this.urunlsl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunlsl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urunlsl.Location = new System.Drawing.Point(8, 185);
            this.urunlsl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urunlsl.Name = "urunlsl";
            this.urunlsl.Size = new System.Drawing.Size(93, 19);
            this.urunlsl.TabIndex = 20;
            this.urunlsl.Text = "Ürün Kodu :";
            // 
            // onaycontrol_label
            // 
            this.onaycontrol_label.AutoSize = true;
            this.onaycontrol_label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaycontrol_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.onaycontrol_label.Location = new System.Drawing.Point(15, 317);
            this.onaycontrol_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.onaycontrol_label.Name = "onaycontrol_label";
            this.onaycontrol_label.Size = new System.Drawing.Size(13, 19);
            this.onaycontrol_label.TabIndex = 21;
            this.onaycontrol_label.Text = ".";
            this.onaycontrol_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tarihurunkontrol_label
            // 
            this.Tarihurunkontrol_label.AutoSize = true;
            this.Tarihurunkontrol_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tarihurunkontrol_label.Location = new System.Drawing.Point(1545, 7);
            this.Tarihurunkontrol_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tarihurunkontrol_label.Name = "Tarihurunkontrol_label";
            this.Tarihurunkontrol_label.Size = new System.Drawing.Size(100, 35);
            this.Tarihurunkontrol_label.TabIndex = 43;
            this.Tarihurunkontrol_label.Text = "Tarih :";
            // 
            // urunkodu_txt
            // 
            this.urunkodu_txt.Location = new System.Drawing.Point(12, 219);
            this.urunkodu_txt.Margin = new System.Windows.Forms.Padding(4);
            this.urunkodu_txt.Name = "urunkodu_txt";
            this.urunkodu_txt.ReadOnly = true;
            this.urunkodu_txt.Size = new System.Drawing.Size(119, 28);
            this.urunkodu_txt.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(9, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Durum:";
            // 
            // kullanici_tabpage
            // 
            this.kullanici_tabpage.BackColor = System.Drawing.SystemColors.Window;
            this.kullanici_tabpage.Controls.Add(this.doviz_txt);
            this.kullanici_tabpage.Controls.Add(this.pasifbakiye_txt);
            this.kullanici_tabpage.Controls.Add(this.bakiye_txt);
            this.kullanici_tabpage.Controls.Add(this.username_txt);
            this.kullanici_tabpage.Controls.Add(this.Kullanicikontrol_tarih_label);
            this.kullanici_tabpage.Controls.Add(this.donustur_btn);
            this.kullanici_tabpage.Controls.Add(this.onayla_btn);
            this.kullanici_tabpage.Controls.Add(this.parabirimibaslik);
            this.kullanici_tabpage.Controls.Add(this.pasifbakiye);
            this.kullanici_tabpage.Controls.Add(this.onaylibakiye);
            this.kullanici_tabpage.Controls.Add(this.label1);
            this.kullanici_tabpage.Controls.Add(this.search_btn);
            this.kullanici_tabpage.Controls.Add(this.baslik_label);
            this.kullanici_tabpage.Controls.Add(this.secenekler_combobox);
            this.kullanici_tabpage.Controls.Add(this.Kullanicilar_datagridview);
            this.kullanici_tabpage.Location = new System.Drawing.Point(4, 29);
            this.kullanici_tabpage.Margin = new System.Windows.Forms.Padding(4);
            this.kullanici_tabpage.Name = "kullanici_tabpage";
            this.kullanici_tabpage.Padding = new System.Windows.Forms.Padding(4);
            this.kullanici_tabpage.Size = new System.Drawing.Size(955, 483);
            this.kullanici_tabpage.TabIndex = 0;
            this.kullanici_tabpage.Text = "Kullanıcı Kontrol";
            // 
            // Kullanicilar_datagridview
            // 
            this.Kullanicilar_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Kullanicilar_datagridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.Kullanicilar_datagridview.Location = new System.Drawing.Point(210, 83);
            this.Kullanicilar_datagridview.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanicilar_datagridview.Name = "Kullanicilar_datagridview";
            this.Kullanicilar_datagridview.RowHeadersWidth = 51;
            this.Kullanicilar_datagridview.Size = new System.Drawing.Size(737, 413);
            this.Kullanicilar_datagridview.TabIndex = 11;
            this.Kullanicilar_datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Kullanicilar_datagridview_CellClick);
            // 
            // secenekler_combobox
            // 
            this.secenekler_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secenekler_combobox.FormattingEnabled = true;
            this.secenekler_combobox.Location = new System.Drawing.Point(210, 43);
            this.secenekler_combobox.Margin = new System.Windows.Forms.Padding(4);
            this.secenekler_combobox.Name = "secenekler_combobox";
            this.secenekler_combobox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.secenekler_combobox.Size = new System.Drawing.Size(301, 28);
            this.secenekler_combobox.TabIndex = 12;
            // 
            // baslik_label
            // 
            this.baslik_label.AutoSize = true;
            this.baslik_label.BackColor = System.Drawing.Color.Black;
            this.baslik_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baslik_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.baslik_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baslik_label.Location = new System.Drawing.Point(8, 18);
            this.baslik_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baslik_label.Name = "baslik_label";
            this.baslik_label.Size = new System.Drawing.Size(108, 23);
            this.baslik_label.TabIndex = 13;
            this.baslik_label.Text = "Tum Uyeler";
            this.baslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.Window;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.search_btn.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.search_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.search_btn.Location = new System.Drawing.Point(519, 43);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(93, 36);
            this.search_btn.TabIndex = 15;
            this.search_btn.Text = "Getir";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(8, 122);
            this.username_txt.Margin = new System.Windows.Forms.Padding(4);
            this.username_txt.Name = "username_txt";
            this.username_txt.ReadOnly = true;
            this.username_txt.Size = new System.Drawing.Size(143, 28);
            this.username_txt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(4, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Uye :";
            // 
            // onaylibakiye
            // 
            this.onaylibakiye.AutoSize = true;
            this.onaylibakiye.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.onaylibakiye.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylibakiye.Location = new System.Drawing.Point(4, 159);
            this.onaylibakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.onaylibakiye.Name = "onaylibakiye";
            this.onaylibakiye.Size = new System.Drawing.Size(110, 19);
            this.onaylibakiye.TabIndex = 26;
            this.onaylibakiye.Text = "Onayli Bakiye:";
            this.onaylibakiye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pasifbakiye
            // 
            this.pasifbakiye.AutoSize = true;
            this.pasifbakiye.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pasifbakiye.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pasifbakiye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pasifbakiye.Location = new System.Drawing.Point(4, 224);
            this.pasifbakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pasifbakiye.Name = "pasifbakiye";
            this.pasifbakiye.Size = new System.Drawing.Size(100, 19);
            this.pasifbakiye.TabIndex = 27;
            this.pasifbakiye.Text = "Pasif Bakiye:";
            this.pasifbakiye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // parabirimibaslik
            // 
            this.parabirimibaslik.AutoSize = true;
            this.parabirimibaslik.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parabirimibaslik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parabirimibaslik.Location = new System.Drawing.Point(8, 368);
            this.parabirimibaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parabirimibaslik.Name = "parabirimibaslik";
            this.parabirimibaslik.Size = new System.Drawing.Size(93, 19);
            this.parabirimibaslik.TabIndex = 27;
            this.parabirimibaslik.Text = "Para Birimi:";
            // 
            // onayla_btn
            // 
            this.onayla_btn.BackColor = System.Drawing.SystemColors.Window;
            this.onayla_btn.FlatAppearance.BorderSize = 0;
            this.onayla_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.onayla_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.onayla_btn.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onayla_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.onayla_btn.Location = new System.Drawing.Point(34, 295);
            this.onayla_btn.Margin = new System.Windows.Forms.Padding(4);
            this.onayla_btn.Name = "onayla_btn";
            this.onayla_btn.Size = new System.Drawing.Size(117, 42);
            this.onayla_btn.TabIndex = 36;
            this.onayla_btn.Text = "Onayla";
            this.onayla_btn.UseVisualStyleBackColor = false;
            this.onayla_btn.Visible = false;
            this.onayla_btn.Click += new System.EventHandler(this.Onayla_btn_Click);
            // 
            // donustur_btn
            // 
            this.donustur_btn.BackColor = System.Drawing.SystemColors.Window;
            this.donustur_btn.FlatAppearance.BorderSize = 0;
            this.donustur_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.donustur_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.donustur_btn.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donustur_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.donustur_btn.Location = new System.Drawing.Point(34, 441);
            this.donustur_btn.Margin = new System.Windows.Forms.Padding(4);
            this.donustur_btn.Name = "donustur_btn";
            this.donustur_btn.Size = new System.Drawing.Size(117, 42);
            this.donustur_btn.TabIndex = 36;
            this.donustur_btn.Text = "Dönüştür";
            this.donustur_btn.UseVisualStyleBackColor = false;
            this.donustur_btn.Visible = false;
            this.donustur_btn.Click += new System.EventHandler(this.donustur_btn_Click);
            // 
            // Kullanicikontrol_tarih_label
            // 
            this.Kullanicikontrol_tarih_label.AutoSize = true;
            this.Kullanicikontrol_tarih_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Kullanicikontrol_tarih_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kullanicikontrol_tarih_label.Location = new System.Drawing.Point(780, 46);
            this.Kullanicikontrol_tarih_label.Name = "Kullanicikontrol_tarih_label";
            this.Kullanicikontrol_tarih_label.Size = new System.Drawing.Size(48, 21);
            this.Kullanicikontrol_tarih_label.TabIndex = 40;
            this.Kullanicikontrol_tarih_label.Text = "Tarih";
            // 
            // bakiye_txt
            // 
            this.bakiye_txt.Location = new System.Drawing.Point(8, 186);
            this.bakiye_txt.Margin = new System.Windows.Forms.Padding(4);
            this.bakiye_txt.Name = "bakiye_txt";
            this.bakiye_txt.ReadOnly = true;
            this.bakiye_txt.Size = new System.Drawing.Size(143, 28);
            this.bakiye_txt.TabIndex = 41;
            // 
            // pasifbakiye_txt
            // 
            this.pasifbakiye_txt.Location = new System.Drawing.Point(8, 252);
            this.pasifbakiye_txt.Margin = new System.Windows.Forms.Padding(4);
            this.pasifbakiye_txt.Name = "pasifbakiye_txt";
            this.pasifbakiye_txt.ReadOnly = true;
            this.pasifbakiye_txt.Size = new System.Drawing.Size(143, 28);
            this.pasifbakiye_txt.TabIndex = 42;
            // 
            // doviz_txt
            // 
            this.doviz_txt.Location = new System.Drawing.Point(8, 405);
            this.doviz_txt.Margin = new System.Windows.Forms.Padding(4);
            this.doviz_txt.Name = "doviz_txt";
            this.doviz_txt.ReadOnly = true;
            this.doviz_txt.Size = new System.Drawing.Size(143, 28);
            this.doviz_txt.TabIndex = 43;
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.kullanici_tabpage);
            this.adminTabControl.Controls.Add(this.uruns_tabpage);
            this.adminTabControl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminTabControl.Location = new System.Drawing.Point(15, 49);
            this.adminTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(963, 516);
            this.adminTabControl.TabIndex = 1;
            // 
            // kasagelir_lbl
            // 
            this.kasagelir_lbl.AutoSize = true;
            this.kasagelir_lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.kasagelir_lbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kasagelir_lbl.ForeColor = System.Drawing.Color.White;
            this.kasagelir_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kasagelir_lbl.Location = new System.Drawing.Point(534, 16);
            this.kasagelir_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kasagelir_lbl.Name = "kasagelir_lbl";
            this.kasagelir_lbl.Size = new System.Drawing.Size(47, 19);
            this.kasagelir_lbl.TabIndex = 44;
            this.kasagelir_lbl.Text = "Kasa:";
            // 
            // adminbaslik_lbl
            // 
            this.adminbaslik_lbl.AutoSize = true;
            this.adminbaslik_lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.adminbaslik_lbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminbaslik_lbl.ForeColor = System.Drawing.Color.White;
            this.adminbaslik_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminbaslik_lbl.Location = new System.Drawing.Point(27, 16);
            this.adminbaslik_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminbaslik_lbl.Name = "adminbaslik_lbl";
            this.adminbaslik_lbl.Size = new System.Drawing.Size(101, 19);
            this.adminbaslik_lbl.TabIndex = 45;
            this.adminbaslik_lbl.Text = "Admin Paneli";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(991, 578);
            this.Controls.Add(this.adminbaslik_lbl);
            this.Controls.Add(this.kasagelir_lbl);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.adminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.uruns_tabpage.ResumeLayout(false);
            this.uruns_tabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Urunler_datagridview)).EndInit();
            this.kullanici_tabpage.ResumeLayout(false);
            this.kullanici_tabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kullanicilar_datagridview)).EndInit();
            this.adminTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.TabPage uruns_tabpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urunkodu_txt;
        private System.Windows.Forms.Label Tarihurunkontrol_label;
        private System.Windows.Forms.Label onaycontrol_label;
        private System.Windows.Forms.Label urunlsl;
        private System.Windows.Forms.Button urunonayla_btn;
        private System.Windows.Forms.Button urunlerlistele_btn;
        private System.Windows.Forms.ComboBox urunler_combobox;
        private System.Windows.Forms.Label urunbaslik_label;
        private System.Windows.Forms.DataGridView Urunler_datagridview;
        private System.Windows.Forms.TabPage kullanici_tabpage;
        private System.Windows.Forms.TextBox doviz_txt;
        private System.Windows.Forms.TextBox pasifbakiye_txt;
        private System.Windows.Forms.TextBox bakiye_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label Kullanicikontrol_tarih_label;
        private System.Windows.Forms.Button donustur_btn;
        private System.Windows.Forms.Button onayla_btn;
        private System.Windows.Forms.Label parabirimibaslik;
        private System.Windows.Forms.Label pasifbakiye;
        private System.Windows.Forms.Label onaylibakiye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label baslik_label;
        private System.Windows.Forms.ComboBox secenekler_combobox;
        private System.Windows.Forms.DataGridView Kullanicilar_datagridview;
        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.Label kasagelir_lbl;
        private System.Windows.Forms.Label adminbaslik_lbl;
    }
}