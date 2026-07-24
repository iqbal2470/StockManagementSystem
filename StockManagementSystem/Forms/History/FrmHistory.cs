using ClosedXML.Excel;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using StockManagementSystem.Models.Common;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.StockTransactionServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace StockManagementSystem.Forms.History
{
    public partial class FrmHistory : BaseForm
    {
        private List<StockTransaction> _filteredHistoryList = new();
        private List<StockTransaction> _historyList = new();
        private readonly IStockTransactionService _stockTransactionService;
        public FrmHistory(IStockTransactionService stockTransactionService)
        {
            InitializeComponent();
            _stockTransactionService = stockTransactionService;
        }

        private async void FrmHistory_Load(object sender, EventArgs e)
        {
            //dtpFrom.Value = DateTime.Today.AddMonths(-1);
            //dtpTo.Value = DateTime.Today;
            //await LoadHistoryAsync();

            //LoadTransactionTypes();
            await LoadHistoryAsync();

            LoadTransactionTypes();

            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;

            ApplyFilters();
        }
        private async Task LoadHistoryAsync()
        {
            _historyList = await _stockTransactionService.GetAllHistoryAsync();
            _filteredHistoryList = _historyList;
            dgvHistory.Rows.Clear();

            foreach (var item in _historyList)
            {
                dgvHistory.Rows.Add(
                    item.CreatedDate.ToString("dd-MM-yyyy hh:mm tt"),
                    item.Product?.ProductName,
                    item.TransactionType.ToString(),
                    item.Quantity,
                    item.PreviousStock,
                    item.CurrentStock,
                    item.ReferenceNo,
                    item.Remarks
                );
            }

            lblRecordCount.Text = $"Total Records : {_historyList.Count}";

            FormatHistoryGrid();
        }
        //private async Task LoadHistoryAsync()
        //{
        //    var history = await _stockTransactionService.GetAllHistoryAsync();

        //    dgvHistory.Rows.Clear();

        //    foreach (var item in history)
        //    {
        //        dgvHistory.Rows.Add(
        //            item.CreatedDate.ToString("dd-MM-yyyy hh:mm tt"),
        //            item.Product?.ProductName,
        //            item.TransactionType.ToString(),
        //            item.Quantity,
        //            item.PreviousStock,
        //            item.CurrentStock,
        //            item.ReferenceNo,
        //            item.Remarks
        //        );
        //    }

        //    lblRecordCount.Text = $"Total Records : {history.Count}";

        //    FormatHistoryGrid();
        //}

        private void FormatHistoryGrid()
        {
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AllowUserToResizeRows = false;

            dgvHistory.MultiSelect = false;

            dgvHistory.ReadOnly = true;

            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvHistory.RowHeadersVisible = false;

            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvHistory.BorderStyle = BorderStyle.None;

            dgvHistory.BackgroundColor = Color.White;

            dgvHistory.EnableHeadersVisualStyles = false;

            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);

            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvHistory.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvHistory.DefaultCellStyle.Font =
                new Font("Segoe UI", 9);

            dgvHistory.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(33, 150, 243);

            dgvHistory.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvHistory.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 249, 250);

            //dgvHistory.RowsDefaultCellStyle.Height = 35;
            foreach (DataGridViewRow row in dgvHistory.Rows)
            {
                row.Height = 35;
            }
        }
        private void LoadTransactionTypes()
        {
            cmbTransactionType.Items.Clear();

            cmbTransactionType.Items.Add("All");

            foreach (var item in Enum.GetNames(typeof(TransactionType)))
            {
                cmbTransactionType.Items.Add(item);
            }

            cmbTransactionType.SelectedIndex = 0;
        }
        private void SearchHistory()
        {
            string search = txtSearch.Text.Trim().ToLower();

            var filteredList = _historyList.Where(x =>
                (x.Product?.ProductName ?? "").ToLower().Contains(search) ||
                x.TransactionType.ToString().ToLower().Contains(search) ||
                (x.ReferenceNo ?? "").ToLower().Contains(search) ||
                (x.Remarks ?? "").ToLower().Contains(search)
            ).ToList();

            dgvHistory.Rows.Clear();

            foreach (var item in filteredList)
            {
                dgvHistory.Rows.Add(
                    item.CreatedDate.ToString("dd-MM-yyyy hh:mm tt"),
                    item.Product?.ProductName,
                    item.TransactionType.ToString(),
                    item.Quantity,
                    item.PreviousStock,
                    item.CurrentStock,
                    item.ReferenceNo,
                    item.Remarks
                );
            }

            lblRecordCount.Text = $"Total Records : {filteredList.Count}";
        }
        //private void ApplyFilters()
        //{
        //    var filteredList = _historyList.AsEnumerable();

        //    // Search Filter
        //    string search = txtSearch.Text.Trim().ToLower();

        //    if (!string.IsNullOrWhiteSpace(search))
        //    {
        //        filteredList = filteredList.Where(x =>
        //            (x.Product?.ProductName ?? "").ToLower().Contains(search) ||
        //            x.TransactionType.ToString().ToLower().Contains(search) ||
        //            (x.ReferenceNo ?? "").ToLower().Contains(search) ||
        //            (x.Remarks ?? "").ToLower().Contains(search));
        //    }

        //    // Transaction Type Filter
        //    if (cmbTransactionType.SelectedIndex > 0)
        //    {
        //        string selectedType = cmbTransactionType.Text;

        //        filteredList = filteredList.Where(x =>
        //            x.TransactionType.ToString() == selectedType);
        //    }

        //    LoadGrid(filteredList.ToList());
        //}
        private void ApplyFilters()
        {
            IEnumerable<StockTransaction> filteredList = _historyList;

            // Search Filter
            string search = txtSearch.Text.Trim().ToLower();

            if (!string.IsNullOrWhiteSpace(search))
            {
                filteredList = filteredList.Where(x =>
                    (x.Product?.ProductName ?? "").ToLower().Contains(search) ||
                    x.TransactionType.ToString().ToLower().Contains(search) ||
                    (x.ReferenceNo ?? "").ToLower().Contains(search) ||
                    (x.Remarks ?? "").ToLower().Contains(search));
            }

            // Transaction Type Filter
            if (cmbTransactionType.SelectedIndex > 0)
            {
                string selectedType = cmbTransactionType.Text;

                filteredList = filteredList.Where(x =>
                    x.TransactionType.ToString() == selectedType);
            }

            // Date Filter
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date.AddDays(1).AddSeconds(-1);

            filteredList = filteredList.Where(x =>
                x.CreatedDate >= fromDate &&
                x.CreatedDate <= toDate);
            _filteredHistoryList = filteredList.ToList();
            //LoadGrid(filteredList.ToList());
            LoadGrid(_filteredHistoryList);
        }
        private void LoadGrid(List<StockTransaction> history)
        {
            dgvHistory.Rows.Clear();

            foreach (var item in history)
            {
                dgvHistory.Rows.Add(
                    item.CreatedDate.ToString("dd-MM-yyyy hh:mm tt"),
                    item.Product?.ProductName,
                    item.TransactionType.ToString(),
                    item.Quantity,
                    item.PreviousStock,
                    item.CurrentStock,
                    item.ReferenceNo,
                    item.Remarks
                );
            }

            lblRecordCount.Text = $"Total Records : {history.Count}";
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //SearchHistory();
            ApplyFilters();
        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            cmbTransactionType.SelectedIndex = 0;

            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;

           await LoadHistoryAsync();

            ApplyFilters();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            cmbTransactionType.SelectedIndex = 0;

            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;

            ApplyFilters();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvHistory.Rows.Count == 0)
            {
                MessageBox.Show("No records available to export.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Workbook|*.xlsx";
                saveFileDialog.FileName = $"History_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("History");

                        // Headers
                        for (int i = 0; i < dgvHistory.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvHistory.Columns[i].HeaderText;
                            worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                        }

                        // Data
                        //for (int i = 0; i < dgvHistory.Rows.Count; i++)
                        //{
                        //    for (int j = 0; j < dgvHistory.Columns.Count; j++)
                        //    {
                        //        worksheet.Cell(i + 2, j + 1).Value =
                        //            dgvHistory.Rows[i].Cells[j].Value?.ToString();
                        //    }
                        //}
                        int row = 2;

                        foreach (var item in _filteredHistoryList)
                        {
                            worksheet.Cell(row, 1).Value = item.CreatedDate.ToString("dd-MM-yyyy hh:mm tt");
                            worksheet.Cell(row, 2).Value = item.Product?.ProductName;
                            worksheet.Cell(row, 3).Value = item.TransactionType.ToString();
                            worksheet.Cell(row, 4).Value = item.Quantity;
                            worksheet.Cell(row, 5).Value = item.PreviousStock;
                            worksheet.Cell(row, 6).Value = item.CurrentStock;
                            worksheet.Cell(row, 7).Value = item.ReferenceNo;
                            worksheet.Cell(row, 8).Value = item.Remarks;

                            row++;
                        }
                        worksheet.Columns().AdjustToContents();

                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("History exported successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Process.Start(new ProcessStartInfo(saveFileDialog.FileName)
                    {
                        UseShellExecute = true
                    });
                }
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dgvHistory.Rows.Count == 0)
            {
                MessageBox.Show("No records available.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "PDF File|*.pdf";

            save.FileName = $"History_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

            if (save.ShowDialog() != DialogResult.OK)
                return;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(20);

                    page.Size(PageSizes.A4.Landscape());

                    page.Header()
                        .Text("Stock Transaction History")
                        .FontSize(20)
                        .Bold()
                        .AlignCenter();

                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn(2);
                            columns.RelativeColumn(2);
                            columns.RelativeColumn(2);
                            columns.RelativeColumn(1);
                            columns.RelativeColumn(1);
                            columns.RelativeColumn(1);
                            columns.RelativeColumn(2);
                            columns.RelativeColumn(3);
                        });

                        // Header

                        table.Header(header =>
                        {
                            header.Cell().Text("Date").Bold();
                            header.Cell().Text("Product").Bold();
                            header.Cell().Text("Type").Bold();
                            header.Cell().Text("Qty").Bold();
                            header.Cell().Text("Prev").Bold();
                            header.Cell().Text("Current").Bold();
                            header.Cell().Text("Reference").Bold();
                            header.Cell().Text("Remarks").Bold();
                        });

                        // Rows

                        //foreach (DataGridViewRow row in dgvHistory.Rows)
                        //{
                        //    table.Cell().Text(row.Cells[0].Value?.ToString() ?? "");
                        //    table.Cell().Text(row.Cells[1].Value?.ToString() ?? "");
                        //    table.Cell().Text(row.Cells[2].Value?.ToString() ?? "");
                        //    table.Cell().Text(row.Cells[3].Value?.ToString() ?? "");
                        //    table.Cell().Text(row.Cells[4].Value?.ToString() ?? "");
                        //    table.Cell().Text(row.Cells[5].Value?.ToString() ?? "");
                        //    table.Cell().Text(row.Cells[6].Value?.ToString() ?? "");
                        //    table.Cell().Text(row.Cells[7].Value?.ToString() ?? "");
                        //}

                        foreach (var item in _filteredHistoryList)
                        {
                            table.Cell().Text(item.CreatedDate.ToString("dd-MM-yyyy hh:mm tt"));
                            table.Cell().Text(item.Product?.ProductName ?? "");
                            table.Cell().Text(item.TransactionType.ToString());
                            table.Cell().Text(item.Quantity.ToString());
                            table.Cell().Text(item.PreviousStock.ToString());
                            table.Cell().Text(item.CurrentStock.ToString());
                            table.Cell().Text(item.ReferenceNo ?? "");
                            table.Cell().Text(item.Remarks ?? "");
                        }
                    });

                    page.Footer()
                        .AlignCenter()
                        .Text($"Generated : {DateTime.Now:dd-MM-yyyy hh:mm tt}");
                });
            })
            .GeneratePdf(save.FileName);

            MessageBox.Show("PDF exported successfully.");

            Process.Start(new ProcessStartInfo(save.FileName)
            {
                UseShellExecute = true
            });
        }
    }
}
