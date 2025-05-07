using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupProject.Models;

namespace GroupProject
{
    public partial class DriverHomePage : Form
    {
        private User loggedInUser;

        // constructor takes a User object
        public DriverHomePage(User user)
        {
            InitializeComponent();
            loggedInUser = user;

        }

        private void DriverHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
