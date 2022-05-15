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
using System.Data.SQLite;

namespace formHEBU42_4AN
{
    public partial class Form1 : Form
    {
        bool mouseDown;
        private Point offset;
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

        private void button_search_Click(object sender, EventArgs e)
        {
            string id = t_box_search.Text;
            t_box_info.Visible = true;

            get_id(id);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void p_box_c_profile_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection _connection = new SQLiteConnection();
                _connection.ConnectionString = ("Data Source=data/SQLite/companies.db");
                _connection.Open();
                string sql = "SELECT * FROM reputation WHERE co_name=@co_name";
                SQLiteParameter prm1 = new SQLiteParameter("co_ID", textBox2.Text);

                SQLiteCommand cmd = new SQLiteCommand(sql, _connection);
                cmd.Parameters.Add(prm1);

                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("başarılı ?");
                }
                else
                {
                    MessageBox.Show("-_-");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
