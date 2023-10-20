using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Management_System
{
    public partial class customers : UserControl
    {

        public customers()
        {
            InitializeComponent();
            for(int i=1;i<= 10; i++)
            {
                dataGridView1.Rows.Add(i,"1","Brand" +i);
            }
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
    }
}
