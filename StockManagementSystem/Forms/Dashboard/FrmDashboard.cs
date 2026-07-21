using FontAwesome.Sharp;
using Microsoft.Extensions.DependencyInjection;
using StockManagementSystem.Forms.Brands;
using StockManagementSystem.Forms.Categories;
using StockManagementSystem.Forms.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Forms.Dashboard
{
    public partial class FrmDashboard : Form
    {
        private const int SidebarExpandedWidth = 250;
        private const int SidebarCollapsedWidth = 70;
        private Form? activeForm;
        private bool isSidebarExpanded = true;
        private IconButton? currentButton;
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (isSidebarExpanded)
            {
                pnlSidebar.Width -= 10;

                if (pnlSidebar.Width <= SidebarCollapsedWidth)
                {
                    timerSidebar.Stop();
                    isSidebarExpanded = false;
                    SetMenuText(false);

                    SetButtonLayout(false);
                }
            }
            else
            {
                pnlSidebar.Width += 10;

                if (pnlSidebar.Width >= SidebarExpandedWidth)
                {
                    timerSidebar.Stop();
                    isSidebarExpanded = true;

                    SetMenuText(true);
                    SetButtonLayout(true);
                }
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd MMM yyyy hh:mm:ss tt");
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Dashboard";

            lblUserName.Text = "Admin";

            lblDateTime.Text = DateTime.Now.ToString("dd MMM yyyy hh:mm:ss tt");

            timerClock.Start();

            SetMenuText(true);

            SetButtonLayout(true);
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlDesktop.Controls.Clear();
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCategory);
            OpenChildForm(Program.Services.GetRequiredService<FrmCategory>());

            lblTitle.Text = "Category";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(btnDashboard);
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            pnlDesktop.Controls.Clear();

            lblTitle.Text = "Dashboard";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }


        private void ActivateButton(IconButton button)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 41, 55);
                currentButton.ForeColor = Color.White;
                currentButton.IconColor = Color.White;
            }

            currentButton = button;

            currentButton.BackColor = Color.FromArgb(59, 130, 246);
            currentButton.ForeColor = Color.White;
            currentButton.IconColor = Color.White;
        }

        private void SetMenuText(bool expanded)
        {
            btnDashboard.Text = expanded ? " Dashboard" : "";
            //btnMasters.Text = expanded ? " Masters" : "";
            btnCategory.Text = expanded ? " Category" : "";
            //btnBrand.Text = expanded ? " Brands" : "";
            //btnUnit.Text = expanded ? " Unit" : "";
            //btnSupplier.Text = expanded ? " Supplier" : "";
            //btnCustomer.Text = expanded ? " Customer" : "";
            //btnProduct.Text = expanded ? " Product" : "";
            //btnPurchase.Text = expanded ? " Purchase" : "";
            //btnSales.Text = expanded ? " Sales" : "";
            //btnStock.Text = expanded ? " Stock" : "";
            //btnReports.Text = expanded ? " Reports" : "";
            //btnSettings.Text = expanded ? " Settings" : "";
            btnLogout.Text = expanded ? " Logout" : "";
        }

        private void SetButtonLayout(bool expanded)
        {
            IconButton[] buttons =
            {
        btnDashboard,
        btnCategory,
        btnLogout
    };

            foreach (var button in buttons)
            {
                if (expanded)
                {
                    button.TextImageRelation = TextImageRelation.ImageBeforeText;
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.TextAlign = ContentAlignment.MiddleLeft;
                    button.Padding = new Padding(15, 0, 0, 0);
                }
                else
                {
                    button.TextImageRelation = TextImageRelation.Overlay;
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Padding = new Padding(0);
                }
            }
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            ActivateButton(btnBrand);

            OpenChildForm(Program.Services.GetRequiredService<FrmBrand>());
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            ActivateButton(btnUnit);

            OpenChildForm(Program.Services.GetRequiredService<FrmUnit>());
        }
    }
}
