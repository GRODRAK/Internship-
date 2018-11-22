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

    public partial class Edit_Event : Form
    {

        public Edit_Event()
        {
            InitializeComponent();
        }

        private void Edit_Event_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Event_Reminder.mdb");
            connect.Open();
            string cmd = "select * from eventDetails";
            OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(cmd, connect));
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "eventName";
            comboBox1.ValueMember = "ID";

            
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String event_name = comboBox1.GetItemText(comboBox1.SelectedItem);

            DateTime event_date = dateTimePicker1.Value.Date;
            if (!am.Checked && !pm.Checked)
            {
                errorProvider1.SetError(time2, "Select AM/PM");
                
            }
            else if (hr.SelectedItem == null || min.SelectedItem == null || sec.SelectedItem == null)
            {
                errorProvider1.SetError(time, "Set Time");
               
            }

            else
            {
                try
                {
                    String event_time2 = pm.Checked ? "PM" : "AM";
                    String event_time = hr.SelectedItem.ToString() + ":" + min.SelectedItem.ToString() + ":" + sec.SelectedItem.ToString() + "-" + event_time2.ToString();
                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Rak/Documents/Visual Studio 2008/Projects/Event_Remainder/Backup/Event_Remainder/Event_Reminder.mdb");
                    OleDbCommand cmd = con.CreateCommand();
                    con.Open();
                    cmd.CommandText = "update eventDetails set eventDate='" + event_date + "',eventTime='" + event_time + "' where eventName='" + event_name + "'";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        


    }
        

        
    }

