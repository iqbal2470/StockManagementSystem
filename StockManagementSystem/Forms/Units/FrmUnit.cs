using global::StockManagementSystem.Models.Master;
using global::StockManagementSystem.Services.UnitServices;
using StockManagementSystem.Models.Common;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.UnitServices;
using System;
using System.Linq;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace StockManagementSystem.Forms.Units
{



    public partial class FrmUnit : BaseForm
    {
        private readonly IUnitService _unitService;
        private int _selectedUnitId = 0;

        public FrmUnit(IUnitService unitService)
        {
            InitializeComponent();

            txtUnitName.KeyDown += Control_KeyDown;
            txtSearch.KeyDown += Control_KeyDown;

            _unitService = unitService;

            dgvUnit.RowPostPaint += dgvUnit_RowPostPaint;
            dgvUnit.CellFormatting += dgvUnit_CellFormatting;
        }

        private async void FrmUnit_Load(object sender, EventArgs e)
        {

            //dgvUnit.AutoGenerateColumns = false;
            //dgvUnit.DataSource = await _unitService.GetAllAsync();
            await LoadUnits();
            await LoadDashboardCards();
            SetAddMode();
        }

        private async Task LoadUnits()
        {
            dgvUnit.DataSource = await _unitService.GetAllAsync();
            FormatGrid();
        }

        //private void FormatGrid()
        //{
        //    dgvUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dgvUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgvUnit.MultiSelect = false;
        //    dgvUnit.ReadOnly = true;
        //    dgvUnit.AllowUserToAddRows = false;
        //    dgvUnit.AllowUserToDeleteRows = false;
        //    dgvUnit.RowHeadersVisible = false;

        //    dgvUnit.Columns["Id"].Visible = false;
        //    dgvUnit.Columns["CreatedDate"].Visible = false;
        //    dgvUnit.Columns["UpdatedDate"].Visible = false;
        //    dgvUnit.Columns["IsDeleted"].Visible = false;

        //    dgvUnit.Columns["UnitName"].HeaderText = "Unit";
        //    dgvUnit.Columns["IsActive"].HeaderText = "Active";
        //}

        private void FormatGrid()
        {
            dgvUnit.AutoGenerateColumns = false;

            dgvUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnit.MultiSelect = false;
            dgvUnit.ReadOnly = true;
            dgvUnit.AllowUserToAddRows = false;
            dgvUnit.AllowUserToDeleteRows = false;
            dgvUnit.AllowUserToResizeRows = false;
            dgvUnit.RowHeadersVisible = false;
            dgvUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvUnit.Columns["Id"].Visible = false;

            dgvUnit.Columns["colSrNo"].HeaderText = "#";
            dgvUnit.Columns["colUnitName"].HeaderText = "Unit Name";
            dgvUnit.Columns["colStatus"].HeaderText = "Status";
            dgvUnit.Columns["colCreatedDate"].HeaderText = "Created Date";
            dgvUnit.Columns["colUpdatedDate"].HeaderText = "Updated Date";

            //dgvUnit.Columns["colEdit"].Visible = false;
            //dgvUnit.Columns["colDelete"].Visible = false;

            dgvUnit.Columns["colSrNo"].FillWeight = 40;
            dgvUnit.Columns["colUnitName"].FillWeight = 180;
            dgvUnit.Columns["colStatus"].FillWeight = 90;
            dgvUnit.Columns["colCreatedDate"].FillWeight = 120;
            dgvUnit.Columns["colUpdatedDate"].FillWeight = 120;
            //dgvUnit.Columns["colEdit"].FillWeight = 70;
            //dgvUnit.Columns["colDelete"].FillWeight = 70;

            dgvUnit.EnableHeadersVisualStyles = false;

            dgvUnit.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvUnit.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvUnit.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvUnit.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvUnit.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 243, 255);

            dgvUnit.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvUnit.ColumnHeadersHeight = 45;
            dgvUnit.RowTemplate.Height = 40;

            dgvUnit.GridColor = Color.Gainsboro;
            dgvUnit.BorderStyle = BorderStyle.None;
        }

        private void dgvUnit_RowPostPaint(object sender,
    DataGridViewRowPostPaintEventArgs e)
        {
            dgvUnit.Rows[e.RowIndex]
                .Cells["colSrNo"].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvUnit_CellFormatting(object sender,
    DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUnit.Columns[e.ColumnIndex].Name == "colStatus")
            {
                bool status = Convert.ToBoolean(e.Value);

                e.Value = status ? "Active" : "Inactive";

                e.FormattingApplied = true;
            }

            if (dgvUnit.Columns[e.ColumnIndex].Name == "colCreatedDate")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value)
                        .ToString("dd-MM-yyyy");

                    e.FormattingApplied = true;
                }
            }

            if (dgvUnit.Columns[e.ColumnIndex].Name == "colUpdatedDate")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value)
                        .ToString("dd-MM-yyyy");

                    e.FormattingApplied = true;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateUnit())
                return;

            if (_selectedUnitId > 0)
            {
                MessageBox.Show(
                    "Unit already selected. Please click New before saving a new unit.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            if (string.IsNullOrWhiteSpace(txtUnitName.Text))
            {
                MessageBox.Show("Please enter Unit Name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitName.Focus();
                return;
            }

            Unit unit = new Unit
            {
                UnitName = txtUnitName.Text.Trim(),
                IsActive = true
            };

            await _unitService.AddAsync(unit);

            MessageBox.Show("Unit saved successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtUnitName.Clear();

            SetAddMode();

            txtUnitName.Focus();

            await LoadUnits();

            await LoadDashboardCards();
        }

        private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUnit.Rows[e.RowIndex];

                _selectedUnitId = Convert.ToInt32(row.Cells["Id"].Value);


                SetEditMode();

                txtUnitName.Text = row.Cells["colUnitName"].Value?.ToString();
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateUnit())
                return;
            if (_selectedUnitId == 0)
            {
                MessageBox.Show("Please select a unit.");
                return;
            }

            Unit unit = await _unitService.GetByIdAsync(_selectedUnitId);

            if (unit != null)
            {
                unit.UnitName = txtUnitName.Text.Trim();
                unit.UpdatedDate = DateTime.Now;
                await _unitService.UpdateAsync(unit);

                MessageBox.Show("Unit updated successfully.");

                await LoadUnits();
                await LoadDashboardCards();
                txtUnitName.Clear();

                _selectedUnitId = 0;

                SetAddMode();

                txtUnitName.Focus();
            }
        }

        private async Task LoadDashboardCards()
        {
            var units = await _unitService.GetAllAsync();

            lblTotalUnit.Text = units.Count.ToString();
            lblActive.Text = units.Count(x => x.IsActive).ToString();
            lblInActive.Text = units.Count(x => !x.IsActive).ToString();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedUnitId == 0)
            {
                MessageBox.Show("Please select a unit to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this unit?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await _unitService.DeleteAsync(_selectedUnitId);

                MessageBox.Show("Unit deleted successfully.");

                await LoadUnits();
                await LoadDashboardCards();
                txtUnitName.Clear();

                _selectedUnitId = 0;

                SetAddMode();

                txtUnitName.Focus();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtUnitName.Clear();

            _selectedUnitId = 0;

            SetAddMode();

            txtUnitName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var units = await _unitService.GetAllAsync();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                units = units
                    .Where(x => x.UnitName.Contains(txtSearch.Text,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            dgvUnit.DataSource = units;

            FormatGrid();
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private bool ValidateUnit()
        {
            if (string.IsNullOrWhiteSpace(txtUnitName.Text))
            {
                MessageBox.Show("Please enter Unit Name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUnitName.Focus();
                return false;
            }

            if (txtUnitName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Unit Name must be at least 3 characters.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUnitName.Focus();
                return false;
            }

            return true;
        }
        private void SetAddMode()
        {
            btnSave.Enabled = true;

            btnUpdate.Enabled = false;

            btnDelete.Enabled = false;

            _selectedUnitId = 0;
        }
        private void SetEditMode()
        {
            btnSave.Enabled = false;

            btnUpdate.Enabled = true;

            btnDelete.Enabled = true;
        }
    }

}
