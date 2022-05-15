
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
            this.t_box_info = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_box_c_profile)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_box_c_profile
            // 
            this.p_box_c_profile.Location = new System.Drawing.Point(153, 101);
            this.p_box_c_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_box_c_profile.Name = "p_box_c_profile";
            this.p_box_c_profile.Size = new System.Drawing.Size(279, 213);
            this.p_box_c_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_box_c_profile.TabIndex = 0;
            this.p_box_c_profile.TabStop = false;
            this.p_box_c_profile.Click += new System.EventHandler(this.p_box_c_profile_Click);
            this.p_box_c_profile.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.p_box_c_profile.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // t_box_search
            // 
            this.t_box_search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.t_box_search.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_box_search.Location = new System.Drawing.Point(153, 68);
            this.t_box_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t_box_search.Name = "t_box_search";
            this.t_box_search.Size = new System.Drawing.Size(472, 29);
            this.t_box_search.TabIndex = 1;
            this.t_box_search.Text = "ID giriniz.";
            this.t_box_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_box_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_box_search_KeyPress);
            // 
            // button_search
            // 
            this.button_search.AutoSize = true;
            this.button_search.Location = new System.Drawing.Point(632, 68);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 30);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "ARA";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // t_box_info
            // 
            this.t_box_info.Location = new System.Drawing.Point(446, 101);
            this.t_box_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t_box_info.Multiline = true;
            this.t_box_info.Name = "t_box_info";
            this.t_box_info.ReadOnly = true;
            this.t_box_info.Size = new System.Drawing.Size(179, 213);
            this.t_box_info.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 62);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label1);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(771, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 56);
            this.panel2.TabIndex = 8;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 328);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(472, 155);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 82);
            this.button1.TabIndex = 10;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(832, 494);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.t_box_info);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.t_box_search);
            this.Controls.Add(this.p_box_c_profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "4AN - HEBU42";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_box_c_profile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p_box_c_profile;
        private System.Windows.Forms.TextBox t_box_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox t_box_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

