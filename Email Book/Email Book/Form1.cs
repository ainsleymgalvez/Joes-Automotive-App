using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Email_Book
{
    public partial class ContactList : Form
    {
        public ContactList()
        {
            InitializeComponent();
        }
// make a list for PersonEntity
        List<PersonEntry> personList = new List<PersonEntry>();

        private void Form1_Load(object sender, EventArgs e)
        { 
// read text file for the application

            StreamReader file = new StreamReader("Email.txt");
            
            string s;
           
            string name = "";
            string email = "";
            string phone = "";
           
            int i;

            while ((s = file.ReadLine()) != null)
            {
                i = 0;
                Char delimiter = ' ';
                String[] substrings = s.Split(delimiter);
                foreach (var substring in substrings)
                {
                    if (i == 0)
                        name = substring;
                    else if (i == 1)
                        email = substring;
                    else
                        phone = substring;
                    i = i + 1;
                }

// adding to the list

                PersonEntry personEntry = new PersonEntry(name, email, phone);
                personList.Add(personEntry);
                emailLB.Items.Add(name);
            }
        }

        private void emailLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = emailLB.SelectedIndex;

// make it show on the other form

            detailsDisplayForm ddf = new detailsDisplayForm();

            ddf.nameLbl.Text = personList[index].Name.ToString();
            ddf.emailLbl.Text = personList[index].Email.ToString();
            ddf.phoneLbl.Text = personList[index].Phone.ToString();

            ddf.Show();
        }
    }
}
