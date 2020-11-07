namespace ApartmanKayıt
{
    partial class FrmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.BtnDaire = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKayıtlar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnHakkımızda = new DevExpress.XtraEditors.SimpleButton();
            this.BtnBorc = new DevExpress.XtraEditors.SimpleButton();
            this.BtnFoto = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // BtnDaire
            // 
            this.BtnDaire.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.BtnDaire.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.BtnDaire.Appearance.BackColor2 = System.Drawing.Color.Lime;
            this.BtnDaire.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.BtnDaire.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnDaire.Appearance.Options.UseBackColor = true;
            this.BtnDaire.Appearance.Options.UseFont = true;
            this.BtnDaire.Appearance.Options.UseForeColor = true;
            this.BtnDaire.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDaire.ImageOptions.Image")));
            this.BtnDaire.Location = new System.Drawing.Point(26, 88);
            this.BtnDaire.Name = "BtnDaire";
            this.BtnDaire.Size = new System.Drawing.Size(198, 43);
            this.BtnDaire.TabIndex = 6;
            this.BtnDaire.Text = "Daireler";
            this.BtnDaire.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnKayıtlar
            // 
            this.BtnKayıtlar.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.BtnKayıtlar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.BtnKayıtlar.Appearance.BackColor2 = System.Drawing.Color.Lime;
            this.BtnKayıtlar.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.BtnKayıtlar.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnKayıtlar.Appearance.Options.UseBackColor = true;
            this.BtnKayıtlar.Appearance.Options.UseFont = true;
            this.BtnKayıtlar.Appearance.Options.UseForeColor = true;
            this.BtnKayıtlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKayıtlar.ImageOptions.Image")));
            this.BtnKayıtlar.Location = new System.Drawing.Point(26, 171);
            this.BtnKayıtlar.Name = "BtnKayıtlar";
            this.BtnKayıtlar.Size = new System.Drawing.Size(198, 43);
            this.BtnKayıtlar.TabIndex = 7;
            this.BtnKayıtlar.Text = "Kayıt İşlemleri";
            this.BtnKayıtlar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnHakkımızda
            // 
            this.BtnHakkımızda.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.BtnHakkımızda.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.BtnHakkımızda.Appearance.BackColor2 = System.Drawing.Color.Lime;
            this.BtnHakkımızda.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.BtnHakkımızda.Appearance.Options.UseBackColor = true;
            this.BtnHakkımızda.Appearance.Options.UseFont = true;
            this.BtnHakkımızda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHakkımızda.ImageOptions.Image")));
            this.BtnHakkımızda.Location = new System.Drawing.Point(26, 253);
            this.BtnHakkımızda.Name = "BtnHakkımızda";
            this.BtnHakkımızda.Size = new System.Drawing.Size(198, 43);
            this.BtnHakkımızda.TabIndex = 8;
            this.BtnHakkımızda.Text = "Hakkımızda";
            this.BtnHakkımızda.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // BtnBorc
            // 
            this.BtnBorc.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.BtnBorc.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.BtnBorc.Appearance.BackColor2 = System.Drawing.Color.Lime;
            this.BtnBorc.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.BtnBorc.Appearance.Options.UseBackColor = true;
            this.BtnBorc.Appearance.Options.UseFont = true;
            this.BtnBorc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBorc.ImageOptions.Image")));
            this.BtnBorc.Location = new System.Drawing.Point(354, 88);
            this.BtnBorc.Name = "BtnBorc";
            this.BtnBorc.Size = new System.Drawing.Size(198, 43);
            this.BtnBorc.TabIndex = 9;
            this.BtnBorc.Text = "Borçlar";
            this.BtnBorc.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // BtnFoto
            // 
            this.BtnFoto.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.BtnFoto.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.BtnFoto.Appearance.BackColor2 = System.Drawing.Color.Lime;
            this.BtnFoto.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.BtnFoto.Appearance.Options.UseBackColor = true;
            this.BtnFoto.Appearance.Options.UseFont = true;
            this.BtnFoto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFoto.ImageOptions.Image")));
            this.BtnFoto.Location = new System.Drawing.Point(354, 171);
            this.BtnFoto.Name = "BtnFoto";
            this.BtnFoto.Size = new System.Drawing.Size(198, 43);
            this.BtnFoto.TabIndex = 10;
            this.BtnFoto.Text = "Daire Fotoğrafları";
            this.BtnFoto.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.BtnCikis.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.BtnCikis.Appearance.BackColor2 = System.Drawing.Color.Lime;
            this.BtnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.BtnCikis.Appearance.Options.UseBackColor = true;
            this.BtnCikis.Appearance.Options.UseFont = true;
            this.BtnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCikis.ImageOptions.Image")));
            this.BtnCikis.Location = new System.Drawing.Point(354, 253);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(198, 43);
            this.BtnCikis.TabIndex = 11;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(265, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(7, 19);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "-";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(231, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(7, 19);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "-";
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(585, 361);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnFoto);
            this.Controls.Add(this.BtnBorc);
            this.Controls.Add(this.BtnHakkımızda);
            this.Controls.Add(this.BtnKayıtlar);
            this.Controls.Add(this.BtnDaire);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnDaire;
        private DevExpress.XtraEditors.SimpleButton BtnKayıtlar;
        private DevExpress.XtraEditors.SimpleButton BtnHakkımızda;
        private DevExpress.XtraEditors.SimpleButton BtnBorc;
        private DevExpress.XtraEditors.SimpleButton BtnFoto;
        private DevExpress.XtraEditors.SimpleButton BtnCikis;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}