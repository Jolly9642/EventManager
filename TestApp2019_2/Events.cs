using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Diagnostics;


namespace TestApp2019_2
{
    public class Events
    {
        public string EventName { get; set; }
        public double EventPoint { get; set; }
         
         List<Users> Volunteers { get; set; }
        //List<Users> iuserList = new List<Users>();
        List<Events> EventsList = new List<Events>();


        public void AddEvent(String Ename, double Epoint)
        {
            Events Aevent = new Events();
            Aevent.EventName = Ename;
            Aevent.EventPoint = Epoint;
            bool t = false;

            if (File.Exists("Events.xml"))
            {
                //newUser.InsertUser(newUser);
                // userList.Clear();

                Aevent.InsertEvent(Aevent);
                t = true;
            }
            else if (t == false)
            {

                List<Events> addEList = new List<Events>();
                addEList.Add(Aevent);

                //This load the list into the xml document.
                XmlSerializer xs = new XmlSerializer(typeof(List<Events>));
                using (FileStream fs = new FileStream("Events.xml", FileMode.Create))
                {
                    xs.Serialize(fs, addEList);
                }
            }




        }

        public void InsertEvent(Events Ievent)
        {

            //insertableUser.PopulateUserList(iuserList);

            //iuserList.Add(insertableUser);

            //XmlSerializer xs = new XmlSerializer(typeof(List<Users>));

            Ievent.PopulateEventList(EventsList);

            EventsList.Add(Ievent);

            XmlSerializer xs = new XmlSerializer(typeof(List<Events>));

            File.Delete("Events.xml");
            using (FileStream fs = new FileStream("Events.xml", FileMode.Create))
            {
                xs.Serialize(fs, EventsList);
            }



        }






        public void AddUserToEvent(Events e, Users u)
        {
            e.Volunteers.Add(u);
        }

        public List<Events> PopulateEventList(List<Events> pEventList)
        {
            XmlDocument xmlDoc = new XmlDocument();

            //List<Events> nevent = new List<Events>();
            if (File.Exists("Events.xml"))
                { 
            xmlDoc.Load("Events.xml");
            // XmlNodeList Xusers = xmlDoc.GetElementsByTagName("Users");
            XmlNodeList Xevent = xmlDoc.GetElementsByTagName("Events");
            XmlNodeList Xeventname = xmlDoc.GetElementsByTagName("EventName");
            XmlNodeList Xeventpoint = xmlDoc.GetElementsByTagName("EventPoint");
            //XmlNodeList Xeventvolunteers = xmlDoc.GetElementsByTagName("Volunteers");
            for (int i = 0; i < Xevent.Count; i++)
            {

                Events arEvents = new Events();
                arEvents.EventName = Xeventname[i].InnerText;
                arEvents.EventPoint = XmlConvert.ToDouble(Xeventpoint[i].InnerText);


                //Debug.WriteLine(Xeventname[i].InnerText);

                // nevent.Add(arEvents);
                pEventList.Add(arEvents);

            }
            // return nevent;
            return pEventList;
            }
            else
            {
                return null;
            }
        }

        public List<Events> SaveEventList(List<Events> sList)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Events>));

            File.Delete("Events.xml");
            using (FileStream fs = new FileStream("Events.xml", FileMode.Create))
            {
                xs.Serialize(fs, sList);
            }
            return sList;
        }






    }
}
