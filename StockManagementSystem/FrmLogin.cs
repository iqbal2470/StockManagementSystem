using StockManagementSystem.Helpers;
using StockManagementSystem.Services.UserServices;

namespace StockManagementSystem
{
    public partial class FrmLogin : Form
    {
        private readonly IUserService _userService;
        public FrmLogin(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text.Trim();
                string password = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(userName))
                {
                    MessageBox.Show("Please enter username.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtUserName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter password.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPassword.Focus();
                    return;
                }

                var user = await _userService.GetByUserNameAsync(userName);

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtUserName.Focus();
                    return;
                }

                bool isValidPassword = PasswordHelper.VerifyPassword(
                    password,
                    user.PasswordHash);

                if (!isValidPassword)
                {
                    MessageBox.Show("Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                user.LastLogin = DateTime.Now;

                await _userService.UpdateAsync(user);

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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
          
            txtPassword.UseSystemPasswordChar = true;
        
        }
    }
}
