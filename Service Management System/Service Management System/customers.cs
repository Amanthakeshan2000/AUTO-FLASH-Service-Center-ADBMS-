using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Service_Management_System
{
    public partial class customers : UserControl
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
    

        public customers()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecord();
           // cn.Open();

        }

        public void LoadRecord()
        {

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm= new SqlCommand("select * from customer_tbl order by NIC,Name,Mobile_no,Date",cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["NIC"].ToString(), dr["Name"].ToString(), dr["Mobile_no"].ToString(), dr["Date"].ToString());
            }
            dr.Close();
            cn.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtNIC.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobile_no.Clear();
        
            txtNIC.Focus();
            txtName.Focus();
            txtAddress.Focus();
            txtEmail.Focus();
            txtMobile_no.Focus();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are You Sure You Want to Save this Customer?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTo customer_tbl(NIC,Name,Address,Mobile_no,Email,Date)VALUEs(@NIC,@Name,@Address,@Mobile_no,@Email,@Date)",cn);
                    
                    cm.Parameters.AddWithValue("@NIC", txtNIC.Text);
                    cm.Parameters.AddWithValue("@Name", txtName.Text);
                    cm.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@Mobile_no", txtMobile_no.Text);
                    cm.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@Date", txtDate.Text);

                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    Clear();

                 
                  
                }
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadRecord();
            }

            
        

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customers_Load(object sender, EventArgs e)
        {

        }
    }
}
