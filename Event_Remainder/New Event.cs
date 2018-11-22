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
    public partial class New_Event : Form
    {
        public New_Event()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
  this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String event_name = textBox1.Text.ToString();
            DateTime event_date = dateTimePicker1.Value.Date;
            if (!am.Checked && !pm.Checked)  
            {
                errorProvider1.SetError(time2, "Select AM/PM");
                
            }
            else if (hr.SelectedItem == null || min.SelectedItem == null || sec.SelectedItem == null)  
            {
                errorProvider1.SetError(time, "Set Time");
                 
            }
            else if (event_name == string.Empty)
            {
                errorProvider1.SetError(textBox1, "Enter the event name");
                
            }
            else
            {
                try
                {
                    String event_time2 = pm.Checked ? "PM" : "AM";
                    String event_time = hr.SelectedItem.ToString() + ":" + min.SelectedItem.ToString() + ":" + sec.SelectedItem.ToString() + "-" + event_time2.ToString();
                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Event_Reminder.mdb");
                    OleDbCommand cmd = con.CreateCommand();
                    con.Open();
                    cmd.CommandText = "insert into eventDetails(eventName,eventDate,eventTime)values('" + event_name + "','" + event_date + "','" + event_time + "')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Created Successfully", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!"+ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            

        }

        private void New_Event_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
        }

       

       

     }
}

       

        

       

  

       

        

       

       

        

      

        

       

       
  
