using StockManagementSystem.Helpers;
using StockManagementSystem.Models.Common;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.UserServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Forms.Login
{
    public partial class FrmCreateAdmin : BaseForm
    {
        private readonly IUserService _userService;
        public FrmCreateAdmin(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }
        private bool _showPassword = false;

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text.Trim();
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                if (string.IsNullOrWhiteSpace(userName))
                {
                    MessageBox.Show("Please enter username.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter password.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Password and Confirm Password do not match.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtConfirmPassword.Focus();
                    return;
                }

                var existingUser = await _userService.GetByUserNameAsync(userName);

                if (existingUser != null)
                {
                    MessageBox.Show("Username already exists.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtUserName.Focus();
                    return;
                }

                User user = new User
                {
                    UserName = userName,
                    PasswordHash = PasswordHelper.HashPassword(password),
                    IsActive = true,
                    LastLogin = null
                };

                await _userService.AddAsync(user);

                MessageBox.Show("Admin account created successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmCreateAdmin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pnlCreateAdmin.Left = (this.ClientSize.Width - pnlCreateAdmin.Width) / 2;
            pnlCreateAdmin.Top = (this.ClientSize.Height - pnlCreateAdmin.Height) / 2;
        }

        private void FrmCreateAdmin_Resize(object sender, EventArgs e)
        {
            pnlCreateAdmin.Left = (this.ClientSize.Width - pnlCreateAdmin.Width) / 2;
            pnlCreateAdmin.Top = (this.ClientSize.Height - pnlCreateAdmin.Height) / 2;
        }

        private void pnlCreateAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            _showPassword = !_showPassword;

            txtPassword.UseSystemPasswordChar = !_showPassword;

            if (_showPassword)
            {
                picShowPassword.Image = Properties.Resources.eye_open;   // Open Eye Icon
            }
            else
            {
                picShowPassword.Image = Properties.Resources.eye_close;  // Closed Eye Icon
            }
        }

        private void picShowConfirmPassword_Click(object sender, EventArgs e)
        {
            _showPassword = !_showPassword;

            txtConfirmPassword.UseSystemPasswordChar = !_showPassword;

            if (_showPassword)
            {
                picShowConfirmPassword.Image = Properties.Resources.eye_open;   // Open Eye Icon
            }
            else
            {
                picShowConfirmPassword.Image = Properties.Resources.eye_close;  // Closed Eye Icon
            }
        }
    }
}
