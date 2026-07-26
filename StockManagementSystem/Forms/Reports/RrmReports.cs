using ClosedXML.Excel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SkiaSharp;
using StockManagementSystem.Models.Common;
using StockManagementSystem.Services.ReportsService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
namespace StockManagementSystem.Forms.Reports
{
    public partial class RrmReports : BaseForm
    {
        private readonly IReportService _reportService;
        public RrmReports(IReportService reportService)
        {
            InitializeComponent();
            _reportService = reportService;
        }

        private async void RrmReports_Load(object sender, EventArgs e)
        {
            cmbReportType.Items.Clear();

            cmbReportType.Items.Add("Purchase Report");
            cmbReportType.Items.Add("Sales Report");
            cmbReportType.Items.Add("Stock Report");

            cmbReportType.SelectedIndex = 0;

            dtpFrom.Value = DateTime.Today.AddDays(-30);

            dtpTo.Value = DateTime.Today;

            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.MultiSelect = false;
            dgvReport.ReadOnly = true;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.RowHeadersVisible = false;



            // Header Design
            dgvReport.EnableHeadersVisualStyles = false;

            dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);   // Blue
            dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReport.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvReport.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvReport.ColumnHeadersHeight = 42;
            dgvReport.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvReport.GridColor = Color.LightGray;


            cmbReportType_SelectedIndexChanged(null, EventArgs.Empty);

            await LoadReport();



        }

        //    private async Task LoadCartesianChartAsync()
        //    {
        //        var data = await _reportService.GetCartesianChartDataAsync(
        //            cmbReportType.Text,
        //            dtpFrom.Value,
        //            dtpTo.Value);

        //        if (cmbReportType.Text == "Stock Report")
        //        {
        //            cartesianChart1.Series = new ISeries[]
        //            {
        //    new ColumnSeries<decimal>
        //    {
        //        Values = data.Select(x => x.Value).ToArray(),
        //        Name = "Top 10 Products"
        //    }
        //            };
        //        }
        //        else if (cmbReportType.Text == "Sales Report")
        //        {
        //            cartesianChart1.Series = new ISeries[]
        //            {
        //    new LineSeries<decimal>
        //    {
        //        Values = data.Select(x => x.Value).ToArray(),
        //        Name = "Sales"
        //    },

        //    new LineSeries<decimal>
        //    {
        //        Values = data.Select(x => x.SecondValue).ToArray(),
        //        Name = "Profit"
        //    }
        //            };
        //        }
        //        else
        //        {
        //            cartesianChart1.Series = new ISeries[]
        //            {
        //    new LineSeries<decimal>
        //    {
        //        Values = data.Select(x => x.Value).ToArray(),
        //        Name = "Purchase"
        //    }
        //            };
        //        }

        //        cartesianChart1.XAxes = new Axis[]
        //        {
        //new Axis
        //{
        //    Labels = data.Select(x => x.Label).ToArray()
        //}
        //        };

        //        //    cartesianChart1.Series = new ISeries[]
        //        //    {
        //        //new LineSeries<decimal>
        //        //{
        //        //    Values = data.Select(x => x.Value).ToArray(),
        //        //    Name = cmbReportType.Text
        //        //}
        //        //    };

        //        //    cartesianChart1.XAxes = new Axis[]
        //        //    {
        //        //new Axis
        //        //{
        //        //    Labels = data.Select(x => x.Label).ToArray()
        //        //}
        //        //    };

        //        //    if (cmbReportType.Text == "Sales Report")
        //        //    {
        //        //        cartesianChart1.Series = new ISeries[]
        //        //        {
        //        //new LineSeries<decimal>
        //        //{
        //        //    Values = data.Select(x => x.Value).ToArray(),
        //        //    Name = "Sales"
        //        //},

        //        //new LineSeries<decimal>
        //        //{
        //        //    Values = data.Select(x => x.SecondValue).ToArray(),
        //        //    Name = "Profit"
        //        //}
        //        //        };
        //        //    }
        //        //    else
        //        //    {
        //        //        cartesianChart1.Series = new ISeries[]
        //        //        {
        //        //new LineSeries<decimal>
        //        //{
        //        //    Values = data.Select(x => x.Value).ToArray(),
        //        //    Name = cmbReportType.Text
        //        //}
        //        //        };
        //        //    }



        //    }

        private async Task LoadCartesianChartAsync()
        {
            var data = await _reportService.GetCartesianChartDataAsync(
                cmbReportType.Text,
                dtpFrom.Value,
                dtpTo.Value);

            if (cmbReportType.Text == "Stock Report")
            {
                cartesianChart1.Series = new ISeries[]
                {
            new ColumnSeries<decimal>
            {
                Values = data.Select(x => x.Value).ToArray(),
                Name = "Top 10 Best Selling"
            }
                };
            }
            else if (cmbReportType.Text == "Sales Report")
            {
                cartesianChart1.Series = new ISeries[]
                {
            // Sales
            new LineSeries<decimal>
            {
                Values = data.Select(x => x.Value).ToArray(),
                Name = "Sales",

                Stroke = new SolidColorPaint(SKColors.DodgerBlue,3),
                GeometryStroke = new SolidColorPaint(SKColors.DodgerBlue),
                GeometryFill = new SolidColorPaint(SKColors.DodgerBlue),
                Fill = null
            },

            // Profit
            new LineSeries<decimal>
            {
                Values = data.Select(x => x.Profit).ToArray(),
                Name = "Profit",

                Stroke = new SolidColorPaint(SKColors.Green,3),
                GeometryStroke = new SolidColorPaint(SKColors.Green),
                GeometryFill = new SolidColorPaint(SKColors.Green),
                Fill = null
            },

            // Loss
            new LineSeries<decimal>
            {
                Values = data.Select(x => x.Loss).ToArray(),
                Name = "Loss",

                Stroke = new SolidColorPaint(SKColors.Red,3),
                GeometryStroke = new SolidColorPaint(SKColors.Red),
                GeometryFill = new SolidColorPaint(SKColors.Red),
                Fill = null
            }
                };
            }
            else
            {
                cartesianChart1.Series = new ISeries[]
                {
            new LineSeries<decimal>
            {
                Values = data.Select(x => x.Value).ToArray(),
                Name = "Purchase",

                Stroke = new SolidColorPaint(SKColors.Orange,3),
                GeometryStroke = new SolidColorPaint(SKColors.Orange),
                GeometryFill = new SolidColorPaint(SKColors.Orange),
                Fill = null
            }
                };
            }

            cartesianChart1.XAxes = new Axis[]
            {
        new Axis
        {
            Labels = data.Select(x => x.Label).ToArray()
        }
            };
        }

        private async Task LoadPieChartAsync()
        {
            var data = await _reportService.GetPieChartDataAsync(
                cmbReportType.Text,
                dtpFrom.Value,
                dtpTo.Value);

            pieChart1.Series = data
                .Select(x => new PieSeries<int>
                {
                    Values = new[] { x.Value },
                    Name = x.Label,

                    InnerRadius = 60,      // Donut Chart
                    DataLabelsSize = 0     // Labels chart ke upar mat dikhao
                })
                .Cast<ISeries>()
                .ToArray();
        }





        private async Task LoadSummaryCards()
        {
            var summary = await _reportService.GetReportSummaryAsync(
                cmbReportType.Text,
                dtpFrom.Value,
                dtpTo.Value);

            lblTotalProducts.Text = summary.TotalProducts.ToString();

            lblTotalPurchase.Text = summary.TotalPurchase.ToString("N2");

            lblTotalSales.Text = summary.TotalSales.ToString("N2");

            lblProfit.Text = summary.Profit.ToString("N2");
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadReport();
        }

        private async Task LoadReport()
        {
            switch (cmbReportType.Text)
            {
                case "Purchase Report":
                    dgvReport.DataSource =
                        await _reportService.GetPurchaseReportAsync(
                            dtpFrom.Value,
                            dtpTo.Value);
                    break;

                case "Sales Report":
                    dgvReport.DataSource =
                        await _reportService.GetSalesReportAsync(
                            dtpFrom.Value,
                            dtpTo.Value);
                    break;

                case "Stock Report":
                    dgvReport.DataSource =
                        await _reportService.GetStockReportAsync();
                    break;
            }

            dgvReport.ClearSelection();

            await LoadSummaryCards();

            await LoadCartesianChartAsync();
            await LoadPieChartAsync();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvReport.DataSource == null)
                return;

            string keyword = txtSearch.Text.Trim().ToLower();

            CurrencyManager cm = (CurrencyManager)BindingContext[dgvReport.DataSource];
            cm.SuspendBinding();

            foreach (DataGridViewRow row in dgvReport.Rows)
            {
                bool visible = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null &&
                        cell.Value.ToString()!
                            .ToLower()
                            .Contains(keyword))
                    {
                        visible = true;
                        break;
                    }
                }

                row.Visible = visible;
            }

            cm.ResumeBinding();
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data available.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF File|*.pdf";
                saveFileDialog.FileName = "Report.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GeneratePdf(saveFileDialog.FileName);

                    MessageBox.Show("PDF exported successfully.");
                }
            }
        }
        private void GeneratePdf(string filePath)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(20);

                    page.Header()
                        .Text(cmbReportType.Text)
                        .FontSize(20)
                        .Bold();

                    page.Content().Table(table =>
                    {
                        int columnCount = dgvReport.Columns.Count;

                        table.ColumnsDefinition(columns =>
                        {
                            for (int i = 0; i < columnCount; i++)
                            {
                                columns.RelativeColumn();
                            }
                        });

                        // Header
                        foreach (DataGridViewColumn column in dgvReport.Columns)
                        {
                            table.Cell()
                                .Border(1)
                                .Padding(5)
                                .Text(column.HeaderText)
                                .Bold();
                        }

                        // Rows
                        foreach (DataGridViewRow row in dgvReport.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.Cell()
                                    .Border(1)
                                    .Padding(5)
                                    .Text(cell.Value?.ToString() ?? "");
                            }
                        }
                    });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Generated on ");
                            x.Span(DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
                        });
                });
            })
            .GeneratePdf(filePath);
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Workbook|*.xlsx";
                saveFileDialog.FileName = "Report.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Report");

                        // Header
                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvReport.Columns[i].HeaderText;
                            worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                        }

                        // Data
                        for (int i = 0; i < dgvReport.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvReport.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value =
                                    dgvReport.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        worksheet.Columns().AdjustToContents();

                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Excel exported successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableDate = cmbReportType.Text != "Stock Report";

            dtpFrom.Enabled = enableDate;
            dtpTo.Enabled = enableDate;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
