using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Management_System
{
    class DBConnection
    {
        public string MyConnection()
        {
            string con = "Data Source=DESKTOP-1DA8EH9\\SQLEXPRESS;Initial Catalog=Service_Center_DB;Integrated Security=True";
            return con; 
        }
    }
}
