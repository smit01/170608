using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0608_OleDB {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Music.mdb
            // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Data\AccessDB\Music.mdb
            // Provider=SQLNCLI11;Data Source=.\SQLExpress;Integrated Security=SSPI;Initial Catalog=Northwind
        }

        private void button1_Click(object sender, EventArgs e) {
            da.Fill(ds);
        }

        private void button2_Click(object sender, EventArgs e) {
            da.Update(ds);
        }
    }
}
