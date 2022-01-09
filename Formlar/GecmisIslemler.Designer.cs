
namespace borsaProjesi.FormScreens
{
    partial class GecmisAlisverisListele
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
            this.tarih1_datetime = new System.Windows.Forms.DateTimePicker();
            this.ShowSiparisler_datagrid = new System.Windows.Forms.DataGridView();
            this.tarih2_datetime = new System.Windows.Forms.DateTimePicker();
            this.OncekiSiparislerim_listele_btn = new System.Windows.Forms.Button();
            this.Yaptigim_satislar_btn = new System.Windows.Forms.Button();
            this.herikiside_btn = new System.Windows.Forms.Button();
            this.rapor_btn = new System.Windows.Forms.Button();
            this.geri_btn = new System.Windows.Forms.Button();
            this.ilktarih_lbl = new System.Windows.Forms.Label();
            this.sontarih_lbl = new System.Windows.Forms.Label();
            this.logbaslik_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowSiparisler_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tarih1_datetime
            // 
            this.tarih1_datetime.Location = new System.Drawing.Point(13, 75);
            this.tarih1_datetime.Margin = new System.Windows.Forms.Padding(4);
            this.tarih1_datetime.Name = "tarih1_datetime";
            this.tarih1_datetime.Size = new System.Drawing.Size(225, 22);
            this.tarih1_datetime.TabIndex = 2;
            this.tarih1_datetime.Value = new System.DateTime(2021, 5, 1, 0, 0, 0, 0);
            // 
            // ShowSiparisler_datagrid
            // 
            this.ShowSiparisler_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowSiparisler_datagrid.Location = new System.Drawing.Point(13, 113);
            this.ShowSiparisler_datagrid.Margin = new System.Windows.Forms.Padding(4);
            this.ShowSiparisler_datagrid.Name = "ShowSiparisler_datagrid";
            this.ShowSiparisler_datagrid.RowHeadersVisible = false;
            this.ShowSiparisler_datagrid.RowHeadersWidth = 51;
            this.ShowSiparisler_datagrid.Size = new System.Drawing.Size(864, 378);
            this.ShowSiparisler_datagrid.TabIndex = 3;
            // 
            // tarih2_datetime
            // 
            this.tarih2_datetime.Location = new System.Drawing.Point(246, 75);
            this.tarih2_datetime.Margin = new System.Windows.Forms.Padding(4);
            this.tarih2_datetime.Name = "tarih2_datetime";
            this.tarih2_datetime.Size = new System.Drawing.Size(225, 22);
            this.tarih2_datetime.TabIndex = 2;
            // 
            // OncekiSiparislerim_listele_btn
            // 
            this.OncekiSiparislerim_listele_btn.BackColor = System.Drawing.SystemColors.Window;
            this.OncekiSiparislerim_listele_btn.Location = new System.Drawing.Point(616, 72);
            this.OncekiSiparislerim_listele_btn.Margin = new System.Windows.Forms.Padding(4);
            this.OncekiSiparislerim_listele_btn.Name = "OncekiSiparislerim_listele_btn";
            this.OncekiSiparislerim_listele_btn.Size = new System.Drawing.Size(129, 33);
            this.OncekiSiparislerim_listele_btn.TabIndex = 4;
            this.OncekiSiparislerim_listele_btn.Text = "Aldıklarım";
            this.OncekiSiparislerim_listele_btn.UseVisualStyleBackColor = false;
            this.OncekiSiparislerim_listele_btn.Click += new System.EventHandler(this.OncekiSiparislerim_listele_btn_Click);
            // 
            // Yaptigim_satislar_btn
            // 
            this.Yaptigim_satislar_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Yaptigim_satislar_btn.Location = new System.Drawing.Point(479, 72);
            this.Yaptigim_satislar_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Yaptigim_satislar_btn.Name = "Yaptigim_satislar_btn";
            this.Yaptigim_satislar_btn.Size = new System.Drawing.Size(129, 33);
            this.Yaptigim_satislar_btn.TabIndex = 4;
            this.Yaptigim_satislar_btn.Text = "Sattıklarım";
            this.Yaptigim_satislar_btn.UseVisualStyleBackColor = false;
            this.Yaptigim_satislar_btn.Click += new System.EventHandler(this.Yaptigim_satislar_btn_Click);
            // 
            // herikiside_btn
            // 
            this.herikiside_btn.BackColor = System.Drawing.SystemColors.Window;
            this.herikiside_btn.Location = new System.Drawing.Point(753, 72);
            this.herikiside_btn.Margin = new System.Windows.Forms.Padding(4);
            this.herikiside_btn.Name = "herikiside_btn";
            this.herikiside_btn.Size = new System.Drawing.Size(129, 33);
            this.herikiside_btn.TabIndex = 4;
            this.herikiside_btn.Text = "Tümü";
            this.herikiside_btn.UseVisualStyleBackColor = false;
            this.herikiside_btn.Click += new System.EventHandler(this.Herikiside_btn_Click);
            // 
            // rapor_btn
            // 
            this.rapor_btn.BackColor = System.Drawing.SystemColors.Window;
            this.rapor_btn.Location = new System.Drawing.Point(479, 513);
            this.rapor_btn.Name = "rapor_btn";
            this.rapor_btn.Size = new System.Drawing.Size(157, 50);
            this.rapor_btn.TabIndex = 0;
            this.rapor_btn.Text = "Dışa Aktar";
            this.rapor_btn.UseVisualStyleBackColor = false;
            this.rapor_btn.Click += new System.EventHandler(this.rapor_btn_Click_1);
            // 
            // geri_btn
            // 
            this.geri_btn.BackColor = System.Drawing.SystemColors.Window;
            this.geri_btn.Location = new System.Drawing.Point(276, 513);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(157, 50);
            this.geri_btn.TabIndex = 5;
            this.geri_btn.Text = "Geri";
            this.geri_btn.UseVisualStyleBackColor = false;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // ilktarih_lbl
            // 
            this.ilktarih_lbl.AutoSize = true;
            this.ilktarih_lbl.Location = new System.Drawing.Point(88, 44);
            this.ilktarih_lbl.Name = "ilktarih_lbl";
            this.ilktarih_lbl.Size = new System.Drawing.Size(73, 17);
            this.ilktarih_lbl.TabIndex = 6;
            this.ilktarih_lbl.Text = "Başlangıç:";
            this.ilktarih_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sontarih_lbl
            // 
            this.sontarih_lbl.AutoSize = true;
            this.sontarih_lbl.Location = new System.Drawing.Point(314, 44);
            this.sontarih_lbl.Name = "sontarih_lbl";
            this.sontarih_lbl.Size = new System.Drawing.Size(38, 17);
            this.sontarih_lbl.TabIndex = 7;
            this.sontarih_lbl.Text = "Bitiş:";
            this.sontarih_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logbaslik_lbl
            // 
            this.logbaslik_lbl.AutoSize = true;
            this.logbaslik_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logbaslik_lbl.Location = new System.Drawing.Point(327, 9);
            this.logbaslik_lbl.Name = "logbaslik_lbl";
            this.logbaslik_lbl.Size = new System.Drawing.Size(251, 23);
            this.logbaslik_lbl.TabIndex = 8;
            this.logbaslik_lbl.Text = "GEÇMİŞ LOG KAYITLARI";
            this.logbaslik_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GecmisAlisverisListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 577);
            this.Controls.Add(this.logbaslik_lbl);
            this.Controls.Add(this.sontarih_lbl);
            this.Controls.Add(this.ilktarih_lbl);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.rapor_btn);
            this.Controls.Add(this.herikiside_btn);
            this.Controls.Add(this.Yaptigim_satislar_btn);
            this.Controls.Add(this.OncekiSiparislerim_listele_btn);
            this.Controls.Add(this.ShowSiparisler_datagrid);
            this.Controls.Add(this.tarih2_datetime);
            this.Controls.Add(this.tarih1_datetime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GecmisAlisverisListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparislerim";
            this.Load += new System.EventHandler(this.Siparislerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowSiparisler_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker tarih1_datetime;
        private System.Windows.Forms.DataGridView ShowSiparisler_datagrid;
        private System.Windows.Forms.DateTimePicker tarih2_datetime;
        private System.Windows.Forms.Button OncekiSiparislerim_listele_btn;
        private System.Windows.Forms.Button Yaptigim_satislar_btn;
        private System.Windows.Forms.Button herikiside_btn;
        private System.Windows.Forms.Button rapor_btn;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.Label ilktarih_lbl;
        private System.Windows.Forms.Label sontarih_lbl;
        private System.Windows.Forms.Label logbaslik_lbl;
    }
}