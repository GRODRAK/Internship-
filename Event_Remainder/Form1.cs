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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void new_eventbt_Click(object sender, EventArgs e)
        {
            New_Event newEvent = new New_Event();
            newEvent.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Events viewEvent = new View_Events();
            viewEvent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Event editevent = new Edit_Event();
            editevent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           DialogResult exit=MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           if (exit == DialogResult.Yes)
           {
               this.Close();
           }

        }

     
    }
}
