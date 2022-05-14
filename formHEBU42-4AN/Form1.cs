using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace formHEBU42_4AN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            p_box_c_profile.AllowDrop = true;
            t_box_info.Visible = false;
            p_box_c_profile.Visible = false;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                p_box_c_profile.Image = img;
            }
        }

        private void get_id(string id)
        {   
            switch (id)
            {
                case "uercan":
                    t_box_info.Text = "Ad: Umut ERCAN" + "\r\n";
                    p_box_c_profile.Visible = true;
                    p_box_c_profile.Image = Properties.Resources.uercan;
                    break;
                case "hsisman":
                    t_box_info.Text = "Ad: Hanifi ŞİŞMAN" + "\r\n";
                    p_box_c_profile.Visible = true;
                    p_box_c_profile.Image = Properties.Resources.hsisman;
                    break;
                case "berdogan":
                    t_box_info.Text = "Ad: Burak Baki ERDOĞAN" + "\r\n";
                    p_box_c_profile.Visible = true;
                    p_box_c_profile.Image = Properties.Resources.berdogan;
                    break;
                case "eiscan":
                    t_box_info.Text = "Ad: Emrecan İŞCAN" + "\r\n";
                    p_box_c_profile.Visible = true;
                    p_box_c_profile.Image = Properties.Resources.eiscan;
                    break;
                case "ROOT":
                    p_box_c_profile.Visible = true;
                    t_box_info.Text = "Created By UMTER_STDS";
                    p_box_c_profile.Image = Properties.Resources.umter_studios;
                    break;
                default:
                    t_box_info.Visible = false;
                    p_box_c_profile.Visible = false;
                    t_box_search.Text = "KAYIT BULUNAMADI";
                    break;
            }
        }

        private void t_box_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            string id = t_box_search.Text;

            if (e.KeyChar == (char)Keys.Enter)
            {
                t_box_info.Visible = true;
                get_id(id);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string id = t_box_search.Text;
            t_box_info.Visible = true;

            get_id(id);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_myprofile_Click(object sender, EventArgs e)
        {

        }
    }
}
