
namespace formHEBU42_4AN
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p_box_c_profile = new System.Windows.Forms.PictureBox();
            this.t_box_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_myprofile = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.t_box_info = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_close = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.p_box_c_profile)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_box_c_profile
            // 
            this.p_box_c_profile.Location = new System.Drawing.Point(115, 130);
            this.p_box_c_profile.Margin = new System.Windows.Forms.Padding(2);
            this.p_box_c_profile.Name = "p_box_c_profile";
            this.p_box_c_profile.Size = new System.Drawing.Size(209, 173);
            this.p_box_c_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_box_c_profile.TabIndex = 0;
            this.p_box_c_profile.TabStop = false;
            this.p_box_c_profile.Click += new System.EventHandler(this.pictureBox1_Click);
            this.p_box_c_profile.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.p_box_c_profile.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // t_box_search
            // 
            this.t_box_search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.t_box_search.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_box_search.Location = new System.Drawing.Point(115, 55);
            this.t_box_search.Margin = new System.Windows.Forms.Padding(2);
            this.t_box_search.Name = "t_box_search";
            this.t_box_search.Size = new System.Drawing.Size(355, 25);
            this.t_box_search.TabIndex = 1;
            this.t_box_search.Text = "ID giriniz.";
            this.t_box_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_box_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.t_box_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_box_search_KeyPress);
            // 
            // button_search
            // 
            this.button_search.AutoSize = true;
            this.button_search.Location = new System.Drawing.Point(474, 55);
            this.button_search.Margin = new System.Windows.Forms.Padding(2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(56, 24);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "ARA";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_myprofile
            // 
            this.button_myprofile.Location = new System.Drawing.Point(11, 55);
            this.button_myprofile.Margin = new System.Windows.Forms.Padding(2);
            this.button_myprofile.Name = "button_myprofile";
            this.button_myprofile.Size = new System.Drawing.Size(52, 50);
            this.button_myprofile.TabIndex = 3;
            this.button_myprofile.Text = "Profilim";
            this.button_myprofile.UseVisualStyleBackColor = true;
            this.button_myprofile.Click += new System.EventHandler(this.button_myprofile_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(11, 340);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(52, 50);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "ÇIKIŞ";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // t_box_info
            // 
            this.t_box_info.Location = new System.Drawing.Point(354, 133);
            this.t_box_info.Margin = new System.Windows.Forms.Padding(2);
            this.t_box_info.Multiline = true;
            this.t_box_info.Name = "t_box_info";
            this.t_box_info.Size = new System.Drawing.Size(135, 174);
            this.t_box_info.TabIndex = 6;
            this.t_box_info.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 50);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel_close
            // 
            this.panel_close.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_close.BackgroundImage")));
            this.panel_close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_close.Location = new System.Drawing.Point(593, 12);
            this.panel_close.Name = "panel_close";
            this.panel_close.Size = new System.Drawing.Size(19, 19);
            this.panel_close.TabIndex = 8;
            this.panel_close.Click += new System.EventHandler(this.panel_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(624, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_myprofile);
            this.Controls.Add(this.t_box_info);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.t_box_search);
            this.Controls.Add(this.p_box_c_profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "4AN - HEBU42";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_box_c_profile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p_box_c_profile;
        private System.Windows.Forms.TextBox t_box_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_myprofile;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox t_box_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_close;
    }
}

