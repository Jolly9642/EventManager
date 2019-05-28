using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace TestApp2019_2
{
    public partial class Form1 : Form
    {

        List<Users> userList = new List<Users>();
        Users addUser = new Users();
        XMLReader xReader = new XMLReader();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
            Users newUser = new Users();
            newUser.Firstname = fname.Text;
            newUser.Lastname = lname.Text;
            newUser.Userid = useridbox.Text;
           
            newUser.Password = Hasher.Hash(passwordbox.Text);
            newUser.Points = 0;
            newUser.Admin = false;
            bool t = false;
            
            if (File.Exists("Data.xml"))
            {
                newUser.InsertUser(newUser);
                userList.Clear();
                t = true;
            }
            else if(t==false)
            {
                newUser.Admin = true;
                userList.Add(newUser);

                //This load the list into the xml document.
                XmlSerializer xs = new XmlSerializer(typeof(List<Users>));
                using (FileStream fs = new FileStream("Data.xml", FileMode.Create))
                {
                    xs.Serialize(fs, userList);
                }
            }
            MessageBox.Show("User added successfully.");
            this.Close();
        }
        
        private void loadUser_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
