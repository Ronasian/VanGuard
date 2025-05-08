using GroupProject.Data;
using GroupProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class ManagerHomePage : Form
    {
        // stores currently logged in user
        private User loggedInUser;

        public ManagerHomePage(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            // event handler for clicks inside the grid
            vansDGV.CellContentClick += vansDGV_CellContentClick;
        }

        private void ManagerHomePage_Load(object sender, EventArgs e)
        {
            // Highlights row when clicked on
            vansDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // prevents highlighting multiple rows
            vansDGV.MultiSelect = false;
            // call helper function to populate grid during initialization
            LoadVanTable();
        }

        private void LoadVanTable()
        {
            // clears columns
            vansDGV.Columns.Clear();
            vansDGV.Rows.Clear();

            // adds text columns for van data
            vansDGV.Columns.Add("VanIDCol", "Van ID");
            vansDGV.Columns.Add("DriverCol", "Driver");
            vansDGV.Columns.Add("StatusCol", "Status");
            vansDGV.Columns.Add("RepairCol", "Needs Repair");

            // buttons for manager actions
            vansDGV.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Actions",
                Text = "View Report",
                UseColumnTextForButtonValue = true,
                Name = "ViewReport"
            });

            vansDGV.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Actions",
                Text = "Mark Repaired",
                UseColumnTextForButtonValue = true,
                Name = "MarkRepaired"
            });

            vansDGV.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Actions",
                Text = "Remove",
                UseColumnTextForButtonValue = true,
                Name = "RemoveVan"
            });
            // creates rows for each van in database
            foreach (var van in VanDatabase.Vans.ToList())
            {
                // use helper function on van
                ApplyInspectionLogic(van);
                string needsRepairText = van.NeedsRepair ? "Yes" : "No";
                vansDGV.Rows.Add(van.Id, van.AssignedDriver, van.Status, needsRepairText);
            }
            // prevents users from adding rows (excluding the actual add van button)
            vansDGV.AllowUserToAddRows = false;
        }
        private void ApplyInspectionLogic(Van van)
        {
            if (string.IsNullOrWhiteSpace(van.Report))
                return;

            string report = van.Report.ToLower();

            if (report.Contains("engine") || report.Contains("light"))
            {
                van.Status = "Out of Service";
                van.NeedsRepair = true;
            }
            else if (report.Contains("exterior"))
            {
                van.Status = "Active";
                van.NeedsRepair = true;
            }
            else
            {
                van.Status = "Active";
                van.NeedsRepair = false;
            }

            VanDatabase.UpdateVan(van);
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string newVanId = VanIDtextbox.Text.Trim();
            // validating user input
            if (string.IsNullOrWhiteSpace(newVanId))
            {
                MessageBox.Show("Please enter a Van ID.");
                return;
            }
            // makes sure that all IDs are unique
            if (VanDatabase.Vans.Any(v => v.Id.Equals(newVanId, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("A van with this ID already exists.");
                return;
            }
            // create new van
            Van newVan = new Van
            {
                Id = newVanId,
                AssignedDriver = "",
                Status = "Active",
                NeedsRepair = false,
                Report = ""
            };

            VanDatabase.AddVan(newVan);
            VanIDtextbox.Clear();
            // refreshes grid
            LoadVanTable();
        }

        private void vansDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // retrieves id from the first column (0)
            string vanId = vansDGV.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(vanId))
                return;
            // finds van in database
            var selectedVan = VanDatabase.Vans.FirstOrDefault(v => v.Id == vanId);
            if (selectedVan == null)
                return;
            // verifies action buttons
            string columnName = vansDGV.Columns[e.ColumnIndex].Name;
            if (columnName == "ViewReport")
            {
                MessageBox.Show(string.IsNullOrWhiteSpace(selectedVan.Report)
                    ? "No report submitted."
                    : selectedVan.Report,
                    "Condition Report");
            }
            else if (columnName == "MarkRepaired")
            {
                selectedVan.NeedsRepair = false;
                selectedVan.Report = "";
                selectedVan.Status = "Active";
                VanDatabase.UpdateVan(selectedVan);
                LoadVanTable();
            }
            else if (columnName == "RemoveVan")
            {
                var confirm = MessageBox.Show($"Remove van {selectedVan.Id}?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    VanDatabase.RemoveVan(selectedVan.Id);
                    LoadVanTable();
                }
            }
        }
    }
}