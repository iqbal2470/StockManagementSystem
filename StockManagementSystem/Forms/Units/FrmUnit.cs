using global::StockManagementSystem.Models.Master;
using global::StockManagementSystem.Services.UnitServices;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.UnitServices;
using System;
using System.Linq;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace StockManagementSystem.Forms.Units
{



    public partial class FrmUnit : Form
    {
        private readonly IUnitService _unitService;
        private int _selectedUnitId = 0;

        public FrmUnit(IUnitService unitService)
        {
            InitializeComponent();

            txtUnitName.KeyDown += Control_KeyDown;
            txtSearch.KeyDown += Control_KeyDown;

            _unitService = unitService;
        }

        private async void FrmUnit_Load(object sender, EventArgs e)
        {
            await LoadUnits();
        }

        private async Task LoadUnits()
        {
            dgvUnit.DataSource = await _unitService.GetAllAsync();
            FormatGrid();
        }

        private void FormatGrid()
        {
            dgvUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnit.MultiSelect = false;
            dgvUnit.ReadOnly = true;
            dgvUnit.AllowUserToAddRows = false;
            dgvUnit.AllowUserToDeleteRows = false;
            dgvUnit.RowHeadersVisible = false;

            dgvUnit.Columns["Id"].Visible = false;
            dgvUnit.Columns["CreatedDate"].Visible = false;
            dgvUnit.Columns["UpdatedDate"].Visible = false;
            dgvUnit.Columns["IsDeleted"].Visible = false;

            dgvUnit.Columns["UnitName"].HeaderText = "Unit";
            dgvUnit.Columns["IsActive"].HeaderText = "Active";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
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
            txtUnitName.Focus();

            await LoadUnits();
        }

        private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUnit.Rows[e.RowIndex];

                _selectedUnitId = Convert.ToInt32(row.Cells["Id"].Value);

                txtUnitName.Text = row.Cells["UnitName"].Value?.ToString();
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedUnitId == 0)
            {
                MessageBox.Show("Please select a unit.");
                return;
            }

            Unit unit = await _unitService.GetByIdAsync(_selectedUnitId);

            if (unit != null)
            {
                unit.UnitName = txtUnitName.Text.Trim();

                await _unitService.UpdateAsync(unit);

                MessageBox.Show("Unit updated successfully.");

                await LoadUnits();

                txtUnitName.Clear();

                _selectedUnitId = 0;
            }
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

                txtUnitName.Clear();

                _selectedUnitId = 0;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtUnitName.Clear();

            _selectedUnitId = 0;

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
    }

}
