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

namespace test0608_Transaction {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            SqlConnection cn = new SqlConnection("server=.\\SQLExpress;database=northwind;integrated security=true");
            cn.Open();
            SqlTransaction t = cn.BeginTransaction();
            // ...
            // t.Commit(); or t.Rollback();
//            try {
                SqlCommand cmd1 = new SqlCommand(
                    "update Products set UnitsInStock = 111 where ProductID = 1",
                    cn, t);
                SqlCommand cmd2 = new SqlCommand(
                    "update Products set UnitsInStock = 222 where ProductID = 2",
                    cn, t);
                cmd1.ExecuteNonQuery(); cmd2.ExecuteNonQuery();
                MessageBox.Show("Pause, Hold on.");
                if (checkBox1.Checked)
                    t.Commit();
                else
                    t.Rollback();
            //}
            //catch {
            //    t.Rollback();
            //}


            button1.Text = "OK";
        }
    }
}
