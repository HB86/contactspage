using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity; 

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //inactive
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new context())
            {
                Contact contact = new Contact();
                contact.Email = Txt_Email.Text;
                //maps email field to database
                contact.FirstName = txt_FirstName.Text;
                //maps first name field to database
                contact.LastName = txt_LastName.Text;
                //maps last name to database
                contact.Phone = txt_Phone.Text;
                //maps phone number to database
                ctx.Contacts.Add(contact);
                ctx.SaveChanges();
                //Saves contact information to database on click
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //inactive coming later
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //inactive coming later 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (var context = new context())
            {
                this.dataGridView1.DataSource = context.Contacts.ToList();

                //Reads data from database and displays in data grid
            }

        }
    }
}
