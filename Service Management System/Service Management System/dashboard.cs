using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Service_Management_System
{
    public partial class dashboard : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
       

        public dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            //MessageBox.Show("Connected");

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            customers c1 = new customers();
            panel3.Controls.Add(c1);
            c1.BringToFront();
            c1.Show();
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            vehicle v1 = new vehicle();
            panel3.Controls.Add(v1);
            v1.BringToFront();
            v1.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            service s1 = new service();
            panel3.Controls.Add(s1);
            s1.BringToFront();
            s1.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor=Color.DarkBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(24, 96, 148);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkBlue;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkBlue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(24, 96, 148);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 96, 148);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vehicle1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
