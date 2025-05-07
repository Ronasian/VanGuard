using GroupProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class ManagerHomePage : Form
    {
        private User loggedInUser;
        public ManagerHomePage(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void ManagerHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
