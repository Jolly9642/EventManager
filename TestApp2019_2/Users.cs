using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;


namespace TestApp2019_2
{
    


    public class Users
    {  
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Userid { get; set; }
        public string Password { get; set; }
        public double Points { get; set; }
        public bool Admin { get; set; }
        List<Users> iuserList = new List<Users>();
        //public string Address { get; set; }
        //public string City { get; set; }
        //public int Zipcode { get; set; }
        //public string Phone { get; set; }
        // public string Email { get; set; }

        public void InsertUser(Users insertableUser)
        {

            insertableUser.PopulateUserList(iuserList);

            iuserList.Add(insertableUser);
            
            XmlSerializer xs = new XmlSerializer(typeof(List<Users>));

            File.Delete("Data.xml");
            using (FileStream fs = new FileStream("Data.xml", FileMode.Create))
            {
                xs.Serialize(fs, iuserList);
            }

        }


        //This deletes a user. Kind of had to rewrite the populate list method because I didn'tknow how to manipulate the populate method to delete.
        public void DeleteUser(Users deleteableUder)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Data.xml");
            XmlNodeList Xusers = xmlDoc.GetElementsByTagName("Users");
            XmlNodeList Xfirstname = xmlDoc.GetElementsByTagName("Firstname");
            XmlNodeList Xlastname = xmlDoc.GetElementsByTagName("Lastname");
            XmlNodeList Xuserid = xmlDoc.GetElementsByTagName("Userid");
            XmlNodeList Xpassword = xmlDoc.GetElementsByTagName("Password");
            XmlNodeList Xpoints = xmlDoc.GetElementsByTagName("Points");
            XmlNodeList Xadmin = xmlDoc.GetElementsByTagName("Admin");
            for (int i = 0; i < Xusers.Count; i++)
            {

                if (Xuserid[i].InnerText == deleteableUder.Userid)
                {
                    
                    //This is left blank so that the user that is suppose  to be deleted won't be added to the updated list.
                }
                else
                {
                    Users arUsers = new Users();
                    arUsers.Firstname = Xfirstname[i].InnerText;
                    arUsers.Lastname = Xlastname[i].InnerText;
                    arUsers.Userid = Xlastname[i].InnerText;
                    arUsers.Password = Xpassword[i].InnerText;
                    arUsers.Points = XmlConvert.ToDouble(Xpoints[i].InnerText);
                    arUsers.Admin = XmlConvert.ToBoolean(Xadmin[i].InnerText);
                    iuserList.Add(arUsers);
                }
            }
           
            XmlSerializer xs = new XmlSerializer(typeof(List<Users>));

            File.Delete("Data.xml");
            using (FileStream fs = new FileStream("Data.xml", FileMode.Create))
            {
                xs.Serialize(fs, iuserList);
            }
        }


        //Poulate list takes all the users from the xml file and populates them into a list. 
        public List<Users> PopulateUserList(List<Users> pUserList)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Data.xml");
            XmlNodeList Xusers = xmlDoc.GetElementsByTagName("Users");
            XmlNodeList Xfirstname = xmlDoc.GetElementsByTagName("Firstname");
            XmlNodeList Xlastname = xmlDoc.GetElementsByTagName("Lastname");
            XmlNodeList Xuserid = xmlDoc.GetElementsByTagName("Userid");
            XmlNodeList Xpassword = xmlDoc.GetElementsByTagName("Password");
            XmlNodeList Xpoints = xmlDoc.GetElementsByTagName("Points");
            XmlNodeList Xadmin = xmlDoc.GetElementsByTagName("Admin");
            for (int i = 0; i < Xusers.Count; i++)
            {
                Users arUsers = new Users();
                arUsers.Firstname = Xfirstname[i].InnerText;
                arUsers.Lastname = Xlastname[i].InnerText;
                arUsers.Userid = Xlastname[i].InnerText;
                arUsers.Password = Xpassword[i].InnerText;
                arUsers.Points = XmlConvert.ToDouble(Xpoints[i].InnerText);
                arUsers.Admin = XmlConvert.ToBoolean(Xadmin[i].InnerText);
                pUserList.Add(arUsers);
            }
            return pUserList;
        }

        


    }

    
}
