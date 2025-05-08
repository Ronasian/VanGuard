using GroupProject.Data;
using GroupProject.Models;
using System;
using System.Linq;
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
            vansDGV.CellContentClick += vansDGV_CellContentClick;
        }

        private void ManagerHomePage_Load(object sender, EventArgs e)
        {
            vansDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            vansDGV.MultiSelect = false;
            LoadVanTable();
        }

        private void LoadVanTable()
        {
            vansDGV.Columns.Clear();
            vansDGV.Rows.Clear();

            // Text Columns
            vansDGV.Columns.Add("VanIDCol", "Van ID");
            vansDGV.Columns.Add("DriverCol", "Driver");
            vansDGV.Columns.Add("StatusCol", "Status");
            vansDGV.Columns.Add("RepairCol", "Needs Repair");

            // Button Columns
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

            foreach (var van in VanDatabase.Vans)
            {
                string needsRepairText = van.NeedsRepair ? "Yes" : "No";
                vansDGV.Rows.Add(van.Id, van.AssignedDriver, van.Status, needsRepairText);
            }

            vansDGV.AllowUserToAddRows = false;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string newVanId = VanIDtextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newVanId))
            {
                MessageBox.Show("Please enter a Van ID.");
                return;
            }

            if (VanDatabase.Vans.Any(v => v.Id.Equals(newVanId, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("A van with this ID already exists.");
                return;
            }

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
            LoadVanTable();
        }

        private void vansDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Always get Van ID from the first column
            string vanId = vansDGV.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(vanId))
                return;

            var selectedVan = VanDatabase.Vans.FirstOrDefault(v => v.Id == vanId);
            if (selectedVan == null)
                return;

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