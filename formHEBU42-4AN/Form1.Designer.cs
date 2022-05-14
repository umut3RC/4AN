
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
            this.p_box_c_profile = new System.Windows.Forms.PictureBox();
            this.t_box_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_myprofile = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.t_box_info = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_box_c_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // p_box_c_profile
            // 
            this.p_box_c_profile.Location = new System.Drawing.Point(160, 78);
            this.p_box_c_profile.Name = "p_box_c_profile";
            this.p_box_c_profile.Size = new System.Drawing.Size(226, 213);
            this.p_box_c_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.t_box_search.Location = new System.Drawing.Point(160, 12);
            this.t_box_search.Name = "t_box_search";
            this.t_box_search.Size = new System.Drawing.Size(472, 29);
            this.t_box_search.TabIndex = 1;
            this.t_box_search.Text = "Mağaza araması yapın.";
            this.t_box_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_box_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button_search
            // 
            this.button_search.AutoSize = true;
            this.button_search.Location = new System.Drawing.Point(638, 12);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 29);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "ARA";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // button_myprofile
            // 
            this.button_myprofile.Location = new System.Drawing.Point(12, 12);
            this.button_myprofile.Name = "button_myprofile";
            this.button_myprofile.Size = new System.Drawing.Size(69, 62);
            this.button_myprofile.TabIndex = 3;
            this.button_myprofile.Text = "Profilim";
            this.button_myprofile.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(12, 420);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(69, 62);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "ÇIKIŞ";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // t_box_info
            // 
            this.t_box_info.Location = new System.Drawing.Point(532, 78);
            this.t_box_info.Multiline = true;
            this.t_box_info.Name = "t_box_info";
            this.t_box_info.Size = new System.Drawing.Size(181, 213);
            this.t_box_info.TabIndex = 6;
            this.t_box_info.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(832, 494);
            this.Controls.Add(this.t_box_info);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_myprofile);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.t_box_search);
            this.Controls.Add(this.p_box_c_profile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_box_c_profile)).EndInit();
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
    }
}

