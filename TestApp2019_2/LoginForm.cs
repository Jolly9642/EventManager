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
using System.Xml.Serialization;
using System.Xml;

namespace TestApp2019_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //This is the click for logging in. It reads data from xml file into a list which you can tra
            //verse with a loop after assigning the appropriate class elements fromthe xml document. 
            string uname = userLogin.Text;
            string pass = passwordLogin.Text;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Data.xml");
            XmlNodeList Xuseradmin = xmlDoc.GetElementsByTagName("Admin");
            XmlNodeList Xuserid = xmlDoc.GetElementsByTagName("Userid");
            XmlNodeList Xpassword = xmlDoc.GetElementsByTagName("Password");

            for (int i = 0; i < Xuserid.Count; i++)
            {
                //Hasher.Verifyy(pass, Xpassword[i].InnerText);

                //if (Xuserid[i].InnerText == uname && Xpassword[i].InnerText == pass)

                if (Xuserid[i].InnerText == uname && Hasher.Verify(pass, Xpassword[i].InnerText) == true)
                {
                    //MessageBox.Show(Xuserid[i].InnerText);
                    //need to instantiate a form here after the user logs in.
                    if (XmlConvert.ToBoolean( Xuseradmin[i].InnerText) == true)
                    {
                        AdminForm Aform = new AdminForm(Xuserid[i].InnerText);
                        Aform.Show();
                        return;
                    }

                    EventsForm Eform = new EventsForm(Xuserid[i].InnerText);
                    Eform.Show();
                    return;
                }
                
                
            }
            MessageBox.Show("Incorrect user login");


        }
    }
}
