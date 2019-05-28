using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace TestApp2019_2
{
    public partial class AdminForm : Form
    {

        public List<Events> pevent = new List<Events>();

        public AdminForm(String ActiveUser)
        {
            InitializeComponent();
            adminLabelGreeting.Text = "Hello, " + ActiveUser;
            List<Users> activeUserList = new List<Users>();
            List<Events> eventsList = new List<Events>();
            Users aUser = new Users();
             Events aEvent = new Events();
            aUser.PopulateUserList(activeUserList);
            aEvent.PopulateEventList(eventsList);


            foreach(Users i in activeUserList)
            {
                adminUsersBox.Items.Add(i.Userid);
            }
            foreach (Events i in eventsList)
            {
                adminEventsBox.Items.Add(i.EventName);
            }
            //adminUsersBox.DataSource=activeUserList;


        }

        public void PopUserListBox()
        {

            adminUsersBox.Items.Clear();
            List<Users> activeUserList = new List<Users>();
            Users aUser = new Users();
            aUser.PopulateUserList(activeUserList);

            foreach (Users i in activeUserList)
            {
                adminUsersBox.Items.Add(i.Userid);
            }
        }

        public void PopEventsListBox()
        {
            adminEventsBox.Items.Clear();
            List<Events> eventsList = new List<Events>();
            Events aEvent = new Events();
            aEvent.PopulateEventList(eventsList);

            foreach (Events i in eventsList)
            {
                adminEventsBox.Items.Add(i.EventName);
            }
        }

        private void adminCreateEventBtn_Click(object sender, EventArgs e)
        {
            Events newEvent = new Events();
            newEvent.AddEvent(adminEventNameBox.Text.ToString(), Convert.ToDouble(adminEventRankInput.Text));
            PopEventsListBox();

        }

        private void adminDeleteEventBtn_Click(object sender, EventArgs e)
        {
            Events delEvent = new Events();
            delEvent.PopulateEventList(pevent);

            foreach(Events i in pevent)
            {

                //Debug.WriteLine(i.EventName.ToString() + "    "+  adminEventsBox.SelectedItem.ToString());
                if (i.EventName.ToString() == adminEventsBox.SelectedItem.ToString())
                {
                    Debug.WriteLine(i.EventName.ToString());
                    pevent.Remove(i);
                    break;
                   
                }
            }
            //pevent.Remove();
            delEvent.SaveEventList(pevent);
            PopEventsListBox();
            pevent.Clear();


            Debug.WriteLine("maybe it saved the event");
            
        }

        private void adminDeleteUserBtn_Click(object sender, EventArgs e)
        {

        }

        private void adminMakeAdminBtn_Click(object sender, EventArgs e)
        {

        }

        private void adminUsersBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminEventsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
