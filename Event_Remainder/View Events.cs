using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Event_Remainder
{
    public partial class View_Events : Form
    {
        public View_Events()
        {
            
            InitializeComponent();
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Event_Reminder.mdb";
            string query = "select * from eventDetails";
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);


                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns["ID"].Visible = false;
                        dataGridView1.Columns["eventName"].DisplayIndex = 0;
                        dataGridView1.Columns["eventDate"].DisplayIndex = 1;
                        dataGridView1.Columns["eventTime"].DisplayIndex = 2;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!"+ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}
