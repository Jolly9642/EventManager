using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp2019_2
{
    public partial class EventsForm : Form
    {
        public EventsForm(String ActiveUser)
        {
            InitializeComponent();
            userGreeting.Text = "Hello," + ActiveUser;
        }

        private void eventsSubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
