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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new context())
            {
                Contact contact = new Contact();
                contact.Email = Txt_Email.Text;
                contact.FirstName = txt_FirstName.Text;
                contact.LastName = txt_LastName.Text;
                contact.Phone = txt_Phone.Text;
                ctx.Contacts.Add(contact);
                ctx.SaveChanges();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (var context = new context())
            {
                this.dataGridView1.DataSource = context.Contacts.ToList();
            }
        }
    }
}
