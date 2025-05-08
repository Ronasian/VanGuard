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
using GroupProject.Data;

namespace GroupProject
{
    public partial class DriverHomePage : Form
    {
        private User loggedInUser;

        public DriverHomePage(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void DriverHomePage_Load(object sender, EventArgs e)
        {
            LoadAvailableVans();
        }

        private void LoadAvailableVans()
        {
            Vanscombobox.Items.Clear();
            foreach (var van in VanDatabase.Vans.Where(v => v.Status == "Active" && string.IsNullOrEmpty(v.AssignedDriver)))
            {
                Vanscombobox.Items.Add(van.Id);
            }
        }

        private void btnAssignVan_Click(object sender, EventArgs e)
        {
            string selectedVanId = Vanscombobox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedVanId))
            {
                MessageBox.Show("Please select a van.");
                return;
            }

            var van = VanDatabase.Vans.FirstOrDefault(v => v.Id == selectedVanId);
            if (van != null)
            {
                van.AssignedDriver = loggedInUser.Email;
                VanDatabase.UpdateVan(van);
                MessageBox.Show($"Assigned van {van.Id} to you.");
                LoadAvailableVans();
            }
        }

        private void btnInspect_Click(object sender, EventArgs e)
        {
            var assignedVan = VanDatabase.Vans.FirstOrDefault(v => v.AssignedDriver == loggedInUser.Email);
            if (assignedVan == null)
            {
                MessageBox.Show("You must assign a van first.");
                return;
            }

            var sb = new StringBuilder();
            bool hasIssue = false;

            if (Exteriorcheckbox.Checked)
            {
                sb.AppendLine("Visible Exterior Damage");
                hasIssue = true;
            }
            if (Lightscheckbox.Checked)
            {
                sb.AppendLine("Lights Broken/Out");
                hasIssue = true;
            }
            if (Enginecheckbox.Checked)
            {
                sb.AppendLine("Engine Noise/Failure");
                hasIssue = true;
            }

            string notes = notestextBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(notes))
            {
                sb.AppendLine($"Notes: {notes}");
            }

            assignedVan.Report = sb.ToString();
            assignedVan.NeedsRepair = hasIssue;
            assignedVan.Status = hasIssue ? "Out of Service" : "Active";

            VanDatabase.UpdateVan(assignedVan);
            MessageBox.Show("Inspection submitted.");
        }
    }
}

