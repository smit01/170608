using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0608_Conflicton {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            da.Fill(ds);
        }

        private void button2_Click(object sender, EventArgs e) {
            da.Update(dsUpload);
        }

        DataSet dsUpload;

        private void button3_Click(object sender, EventArgs e) {
            dsUpload = ds.GetChanges(DataRowState.Modified);
            dataGridView2.DataSource = dsUpload.Tables["Products"];
        }
    }
}
