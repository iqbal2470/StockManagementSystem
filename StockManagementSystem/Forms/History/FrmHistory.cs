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

using QuestPDF.Fluent;
using QuestPDF.Helpers;
//using QuestPDF.Infrastructure;

//using Colors = QuestPDF.Helpers.Colors;
using IContainer = QuestPDF.Infrastructure.IContainer;



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


        private byte[] BitmapToBytes(Bitmap bitmap)
        {
            using var ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        private void btnPdf_Click(object sender, EventArgs e)
        {
            //if (dgvHistory.Rows.Count == 0)
            //{
            //    MessageBox.Show("No records available.");
            //    return;
            //}


            //Document.Create(container =>
            //{
            //    container.Page(page =>
            //    {
            //        page.Margin(20);

            //        page.Size(PageSizes.A4.Landscape());

            //        page.Header()
            //            .Text("Stock Transaction History")
            //            .FontSize(20)
            //            .Bold()
            //            .AlignCenter();

            //        page.Content().Table(table =>
            //        {
            //            table.ColumnsDefinition(columns =>
            //            {
            //                columns.RelativeColumn(2);
            //                columns.RelativeColumn(2);
            //                columns.RelativeColumn(2);
            //                columns.RelativeColumn(1);
            //                columns.RelativeColumn(1);
            //                columns.RelativeColumn(1);
            //                columns.RelativeColumn(2);
            //                columns.RelativeColumn(3);
            //            });

            //            // Header

            //            table.Header(header =>
            //            {
            //                header.Cell().Text("Date").Bold();
            //                header.Cell().Text("Product").Bold();
            //                header.Cell().Text("Type").Bold();
            //                header.Cell().Text("Qty").Bold();
            //                header.Cell().Text("Prev").Bold();
            //                header.Cell().Text("Current").Bold();
            //                header.Cell().Text("Reference").Bold();
            //                header.Cell().Text("Remarks").Bold();
            //            });

            //            // Rows

            //            //foreach (DataGridViewRow row in dgvHistory.Rows)
            //            //{
            //            //    table.Cell().Text(row.Cells[0].Value?.ToString() ?? "");
            //            //    table.Cell().Text(row.Cells[1].Value?.ToString() ?? "");
            //            //    table.Cell().Text(row.Cells[2].Value?.ToString() ?? "");
            //            //    table.Cell().Text(row.Cells[3].Value?.ToString() ?? "");
            //            //    table.Cell().Text(row.Cells[4].Value?.ToString() ?? "");
            //            //    table.Cell().Text(row.Cells[5].Value?.ToString() ?? "");
            //            //    table.Cell().Text(row.Cells[6].Value?.ToString() ?? "");
            //            //    table.Cell().Text(row.Cells[7].Value?.ToString() ?? "");
            //            //}

            //            foreach (var item in _filteredHistoryList)
            //            {
            //                table.Cell().Text(item.CreatedDate.ToString("dd-MM-yyyy hh:mm tt"));
            //                table.Cell().Text(item.Product?.ProductName ?? "");
            //                table.Cell().Text(item.TransactionType.ToString());
            //                table.Cell().Text(item.Quantity.ToString());
            //                table.Cell().Text(item.PreviousStock.ToString());
            //                table.Cell().Text(item.CurrentStock.ToString());
            //                table.Cell().Text(item.ReferenceNo ?? "");
            //                table.Cell().Text(item.Remarks ?? "");
            //            }
            //        });

            //        page.Footer()
            //            .AlignCenter()
            //            .Text($"Generated : {DateTime.Now:dd-MM-yyyy hh:mm tt}");
            //    });
            //})
            //.GeneratePdf(save.FileName);

            //MessageBox.Show("PDF exported successfully.");

            //Process.Start(new ProcessStartInfo(save.FileName)
            //{
            //    UseShellExecute = true
            //});


            if (_filteredHistoryList == null || _filteredHistoryList.Count == 0)
            {
                MessageBox.Show("No records available.");
                return;
            }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "PDF File|*.pdf";
                save.FileName = $"History_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    GeneratePdf(save.FileName);

                    MessageBox.Show("PDF exported successfully.");

                    Process.Start(new ProcessStartInfo(save.FileName)
                    {
                        UseShellExecute = true
                    });
                }
            }
        }


        //private void GeneratePdf(string filePath)
        //{
        //    Document.Create(container =>
        //    {
        //        container.Page(page =>
        //        {
        //            page.Size(PageSizes.A4.Landscape());

        //            page.Margin(15);

        //            // Header
        //            page.Header().Element(BuildHeader);

        //            // Content
        //            page.Content().Column(column =>
        //            {
        //                column.Item().Element(BuildHistorySummary);

        //                column.Item().Element(BuildHistoryTable);
        //            });

        //            // Footer
        //            page.Footer().Element(BuildFooter);
        //        });
        //    })
        //    .GeneratePdf(filePath);
        //}
        private void GeneratePdf(string filePath)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4.Landscape());

                    page.Margin(15);

                    // Content
                    page.Content().Column(column =>
                    {
                        // Ye sirf first page par dikhega
                        column.Item().Element(BuildHeader);

                        column.Item().Element(BuildHistorySummary);

                        column.Item().Element(BuildHistoryTable);
                    });

                    // Footer
                    page.Footer().Element(BuildFooter);
                });
            })
            .GeneratePdf(filePath);
        }
        private void BuildHeader(IContainer container)
        {
            container.Column(column =>
            {
                column.Item()
                    .Border(1)
                    .Padding(5)
                    .Row(row =>
                    {
                        // ================= Logo =================

                        row.ConstantItem(120)
                            .Height(80)
                            .Element(c =>
                            {
                                try
                                {
                                    var logo = Properties.Resources.storemangeimg_1_removebg_preview;

                                    if (logo != null)
                                    {
                                        c.AlignCenter()
                                         .AlignMiddle()
                                         .Image(BitmapToBytes(logo))
                                         .FitArea();
                                    }
                                    else
                                    {
                                        c.Border(1)
                                         .AlignCenter()
                                         .AlignMiddle()
                                         .Text("LOGO")
                                         .Bold();
                                    }
                                }
                                catch
                                {
                                    c.Border(1)
                                     .AlignCenter()
                                     .AlignMiddle()
                                     .Text("LOGO")
                                     .Bold();
                                }
                            });

                        // ================= Company =================

                        row.RelativeItem()
                            .AlignMiddle()
                            .Column(col =>
                            {
                                col.Item()
                                    .AlignCenter()
                                    .Text("CAR ACCESSORY MANAGEMENT STORE")
                                    .FontSize(18)
                                    .Bold();

                                col.Item()
                                    .AlignCenter()
                                    .Text("Car Accessories & Auto Parts")
                                    .FontSize(10);

                                col.Item()
                                    .AlignCenter()
                                    .Text("Address : Jaipur, Rajasthan")
                                    .FontSize(10);

                                col.Item()
                                    .AlignCenter()
                                    .Text("Mobile : +91-9876543210 | Email : info@company.com")
                                    .FontSize(10);

                                col.Item()
                                    .AlignCenter()
                                    .Text("GST No : XXXXXXXXXXXXX")
                                    .FontSize(10);
                            });

                        // Right Blank Space

                        row.ConstantItem(120)
                            .Element(x => { });
                    });

                // Report Title

                column.Item()
                    .PaddingTop(10)
                    .AlignCenter()
                    .Text("STOCK TRANSACTION HISTORY")
                    .FontSize(18)
                    .Bold();

                // Date

                column.Item()
                    .PaddingTop(5)
                    .AlignCenter()
                    .Text($"Generated On : {DateTime.Now:dd-MM-yyyy hh:mm tt}");

                column.Item()
                    .PaddingTop(10)
                    .LineHorizontal(1);
            });
        }

        private void BuildHistorySummary(IContainer container)
        {
            int totalTransactions = _filteredHistoryList.Count;

            int purchase = _filteredHistoryList.Count(x =>
                x.TransactionType.ToString() == "Purchase");

            int sale = _filteredHistoryList.Count(x =>
                x.TransactionType.ToString() == "Sale");

            int adjustment = _filteredHistoryList.Count(x =>
                x.TransactionType.ToString() == "Adjustment");

            int totalQtyIn = _filteredHistoryList
                .Where(x => x.TransactionType.ToString() == "Purchase")
                .Sum(x => x.Quantity);

            int totalQtyOut = _filteredHistoryList
                .Where(x => x.TransactionType.ToString() == "Sale")
                .Sum(x => x.Quantity);

            container
                .Border(1)
                .Padding(10)
                .Column(column =>
                {
                    column.Item().Row(row =>
                    {
                        row.RelativeItem()
                            .Text("Total Transactions")
                            .Bold();

                        row.ConstantItem(150)
                            .AlignRight()
                            .Text(totalTransactions.ToString());
                    });

                    column.Item()
                        .PaddingTop(5)
                        .Row(row =>
                        {
                            row.RelativeItem()
                                .Text("Purchase Entries")
                                .Bold();

                            row.ConstantItem(150)
                                .AlignRight()
                                .Text(purchase.ToString());
                        });

                    column.Item()
                        .PaddingTop(5)
                        .Row(row =>
                        {
                            row.RelativeItem()
                                .Text("Sale Entries")
                                .Bold();

                            row.ConstantItem(150)
                                .AlignRight()
                                .Text(sale.ToString());
                        });

                    column.Item()
                        .PaddingTop(5)
                        .Row(row =>
                        {
                            row.RelativeItem()
                                .Text("Adjustment Entries")
                                .Bold();

                            row.ConstantItem(150)
                                .AlignRight()
                                .Text(adjustment.ToString());
                        });

                    column.Item()
                        .PaddingTop(5)
                        .Row(row =>
                        {
                            row.RelativeItem()
                                .Text("Total Purchase Qty")
                                .Bold();

                            row.ConstantItem(150)
                                .AlignRight()
                                .Text(totalQtyIn.ToString());
                        });

                    column.Item()
                        .PaddingTop(5)
                        .Row(row =>
                        {
                            row.RelativeItem()
                                .Text("Total Sale Qty")
                                .Bold();

                            row.ConstantItem(150)
                                .AlignRight()
                                .Text(totalQtyOut.ToString());
                        });
                });
        }

        private void BuildHistoryTable(IContainer container)
        {
            container
                .PaddingTop(15)
                .Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(2); // Date
                        columns.RelativeColumn(3); // Product
                        columns.RelativeColumn(2); // Type
                        columns.RelativeColumn(1); // Qty
                        columns.RelativeColumn(1); // Prev
                        columns.RelativeColumn(1); // Current
                        columns.RelativeColumn(2); // Reference
                        columns.RelativeColumn(3); // Remarks
                    });

                    // =========================
                    // Header
                    // =========================

                    table.Cell()
                        .Background("#1E88E5")
                        .Border(1)
                        .BorderColor("#D0D0D0")
                        .Padding(6)
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Date")
                        .FontColor(Colors.White)
                        .FontSize(10)
                        .Bold();

                    table.Cell()
                        .Background("#1E88E5")
                        .Border(1)
                        .BorderColor("#D0D0D0")
                        .Padding(6)
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Product")
                        .FontColor(Colors.White)
                        .FontSize(10)
                        .Bold();

                    table.Cell()
                        .Background("#1E88E5")
                        .Border(1)
                        .BorderColor("#D0D0D0")
                        .Padding(6)
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Type")
                        .FontColor(Colors.White)
                        .FontSize(10)
                        .Bold();

                    table.Cell()
                        .Background("#1E88E5")
                        .Border(1)
                        .BorderColor("#D0D0D0")
                        .Padding(6)
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Qty")
                        .FontColor(Colors.White)
                        .FontSize(10)
                        .Bold();

                    table.Cell()
                        .Background("#1E88E5")
                        .Border(1)
                        .BorderColor("#D0D0D0")
                        .Padding(6)
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Previous")
                        .FontColor(Colors.White)
                        .FontSize(10)
                        .Bold();

                    table.Cell()
                        .Background("#1E88E5")
                        .Border(1)
                        .BorderColor("#D0D0D0")
                        .Padding(6)
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Current")
                        .FontColor(Colors.White)
                        .FontSize(10)
                        .Bold();

                    table.Cell()
                        .Background("#1E88E5")
                        .Border(1)
                        .BorderColor("#D0D0D0")
                        .Padding(6)
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Reference")
                        .FontColor(Colors.White)
                        .FontSize(10)
                        .Bold();

                    table.Cell()
                        .Background("#1E88E5")
                        .Border(1)
                        .BorderColor("#D0D0D0")
                        .Padding(6)
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Remarks")
                        .FontColor(Colors.White)
                        .FontSize(10)
                        .Bold();

                    // =========================
                    // Rows
                    // =========================

                    bool alternate = false;

                    foreach (var item in _filteredHistoryList)
                    {
                        alternate = !alternate;

                        string bg = alternate ? "#F8F9FA" : "#FFFFFF";

                        table.Cell()
                            .Background(bg)
                            .Border(1)
                            .BorderColor("#E0E0E0")
                            .Padding(5)
                            .Text(item.CreatedDate.ToString("dd-MM-yyyy hh:mm tt"))
                            .FontSize(8);

                        table.Cell()
                            .Background(bg)
                            .Border(1)
                            .BorderColor("#E0E0E0")
                            .Padding(5)
                            .Text(item.Product?.ProductName ?? "")
                            .FontSize(8);

                        table.Cell()
                            .Background(bg)
                            .Border(1)
                            .BorderColor("#E0E0E0")
                            .Padding(5)
                            .Text(item.TransactionType.ToString())
                            .FontSize(8);

                        table.Cell()
                            .Background(bg)
                            .Border(1)
                            .BorderColor("#E0E0E0")
                            .Padding(5)
                            .AlignCenter()
                            .Text(item.Quantity.ToString())
                            .FontSize(8);

                        table.Cell()
                            .Background(bg)
                            .Border(1)
                            .BorderColor("#E0E0E0")
                            .Padding(5)
                            .AlignCenter()
                            .Text(item.PreviousStock.ToString())
                            .FontSize(8);

                        table.Cell()
                            .Background(bg)
                            .Border(1)
                            .BorderColor("#E0E0E0")
                            .Padding(5)
                            .AlignCenter()
                            .Text(item.CurrentStock.ToString())
                            .FontSize(8);

                        table.Cell()
                            .Background(bg)
                            .Border(1)
                            .BorderColor("#E0E0E0")
                            .Padding(5)
                            .Text(item.ReferenceNo ?? "")
                            .FontSize(8);

                        table.Cell()
                            .Background(bg)
                            .Border(1)
                            .BorderColor("#E0E0E0")
                            .Padding(5)
                            .Text(item.Remarks ?? "")
                            .FontSize(8);
                    }
                });
        }

        private void BuildFooter(IContainer container)
        {
            container
                .BorderTop(1)
                .PaddingTop(8)
                .Row(row =>
                {
                    // Left

                    row.RelativeItem()
                        .Text($"Generated On : {DateTime.Now:dd MMM yyyy hh:mm tt}")
                        .FontSize(9);

                    // Center

                    row.RelativeItem()
                        .AlignCenter()
                        .Text("Generated By : Admin")
                        .FontSize(9);

                    // Right

                    row.RelativeItem()
                        .AlignRight()
                        .DefaultTextStyle(x => x.FontSize(9))
                        .Text(text =>
                        {
                            text.Span("Page ");
                            text.CurrentPageNumber();
                            text.Span(" of ");
                            text.TotalPages();
                        });
                });
        }

        private string FormatCellValue(object value)
        {
            if (value == null)
                return "";

            if (value is DateTime date)
                return date.ToString("dd-MMM-yyyy");

            if (decimal.TryParse(value.ToString(), out decimal amount))
                return amount.ToString("N2");

            return value.ToString();
        }


    }
}
