using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Spreadsheet;
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
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using Color = System.Drawing.Color;
using Colors = QuestPDF.Helpers.Colors;
using IContainer = QuestPDF.Infrastructure.IContainer;
namespace StockManagementSystem.Forms.Reports
{
    public partial class RrmReports : BaseForm
    {


        public event Action? LoadingCompleted;
        private readonly IReportService _reportService;
        public RrmReports(IReportService reportService)
        {
            InitializeComponent();
            _reportService = reportService;

    

            
        }
        private byte[] BitmapToBytes(Bitmap bitmap)
        {
            using var ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
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
            dgvReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);

            dgvReport.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvReport.ColumnHeadersHeight = 42;
            dgvReport.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvReport.GridColor = Color.LightGray;


            cmbReportType_SelectedIndexChanged(null, EventArgs.Empty);

            await LoadReport();

            LoadingCompleted?.Invoke();


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
            //MessageBox.Show($"Records : {data.Count}");
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
        //private void GeneratePdf(string filePath)
        //{
        //    Document.Create(container =>
        //    {
        //        container.Page(page =>
        //        {
        //            page.Margin(20);

        //            //page.Header()
        //            //    .Text(cmbReportType.Text)
        //            //    .FontSize(20)
        //            //    .Bold();

        //            page.Header().Column(column =>
        //            {
        //                column.Item().Row(row =>
        //                {
        //                    // Left Side (Logo)
        //                    row.RelativeItem(1)
        //                        .Height(60)
        //                        .Border(1)
        //                        .AlignCenter()
        //                        .AlignMiddle()
        //                        .Text("LOGO")
        //                        .Bold();

        //                    // Right Side (Company Details)
        //                    row.RelativeItem(4).Column(col =>
        //                    {
        //                        col.Item()
        //                            .AlignCenter()
        //                            .Text("IQBAL CAR ACCESSORIES")
        //                            .FontSize(22)
        //                            .Bold();

        //                        col.Item()
        //                            .AlignCenter()
        //                            .Text("Car Accessories & Auto Parts")
        //                            .FontSize(11);

        //                        col.Item()
        //                            .AlignCenter()
        //                            .Text("Jaipur, Rajasthan");

        //                        col.Item()
        //                            .AlignCenter()
        //                            .Text("Mobile : +91-9876543210 | Email : info@company.com");

        //                        col.Item()
        //                            .AlignCenter()
        //                            .Text("GST No : XXXXXXXXXXXXXX");
        //                    });
        //                });

        //                column.Item().PaddingTop(10);

        //                column.Item()
        //                    .LineHorizontal(1);

        //                column.Item().PaddingTop(8);

        //                column.Item()
        //                    .AlignCenter()
        //                    .Text(cmbReportType.Text.ToUpper())
        //                    .FontSize(18)
        //                    .Bold();

        //                column.Item()
        //                    .AlignCenter()
        //                    .Text($"From : {dtpFrom.Value:dd MMM yyyy}     To : {dtpTo.Value:dd MMM yyyy}")
        //                    .FontSize(11);

        //                column.Item().PaddingBottom(10);

        //                column.Item()
        //                    .LineHorizontal(1);
        //            });

        //            page.Content().Table(table =>
        //            {
        //                int columnCount = dgvReport.Columns.Count;

        //                table.ColumnsDefinition(columns =>
        //                {
        //                    for (int i = 0; i < columnCount; i++)
        //                    {
        //                        columns.RelativeColumn();
        //                    }
        //                });

        //                // Header
        //                foreach (DataGridViewColumn column in dgvReport.Columns)
        //                {
        //                    table.Cell()
        //                        .Border(1)
        //                        .Padding(5)
        //                        .Text(column.HeaderText)
        //                        .Bold();
        //                }

        //                // Rows
        //                foreach (DataGridViewRow row in dgvReport.Rows)
        //                {
        //                    foreach (DataGridViewCell cell in row.Cells)
        //                    {
        //                        table.Cell()
        //                            .Border(1)
        //                            .Padding(5)
        //                            .Text(cell.Value?.ToString() ?? "");
        //                    }
        //                }
        //            });

        //            page.Footer()
        //                .AlignCenter()
        //                .Text(x =>
        //                {
        //                    x.Span("Generated on ");
        //                    x.Span(DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
        //                });
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

                    // Header
                   // page.Header().Element(BuildHeader);

                    // Content
                    //page.Content().Element(BuildContent);

                    //page.Content().Element(BuildSummary);
                    page.Content().Column(col =>
                    {
                        // Header
                        col.Item().Element(BuildHeader);

                        col.Item().Element(BuildSummary);

                        col.Item().Element(BuildTable);
                    });

                    // Footer
                    page.Footer().Element(BuildFooter);
                });
            })
            .GeneratePdf(filePath);
        }
        //string logoPath = Path.Combine(Application.StartupPath, "ProductImages", "storemangeimg_2_removebg_preview");
        //string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"ProductImages","storemangeimg_1_removebg_preview.png");

    //    string logoPath = Path.Combine(
    //Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.FullName,
    //"ProductImages",
    //"storemangeimg_1_removebg_preview.png");

        private void BuildHeader(IContainer container)
        {
            container.Column(column =>
            {
                column.Item().Border(1).Padding(5).Row(row =>
                {
                    // Logo
                    //row.ConstantItem(80)
                    //    .Height(60)
                    //    .Border(1)
                    //    .AlignCenter()
                    //    .AlignMiddle()
                    //    .Image(logoPath);

    //                row.ConstantItem(80)
    //.Height(60)
    //.Image(BitmapToBytes(Properties.Resources.storemangeimg_1_removebg_preview))
    //.FitWidth();


                    row.ConstantItem(120).Height(80).Element(container =>
                    {
                        try
                        {
                            var logo = Properties.Resources.bg_stockmh2;

                            if (logo != null)
                            {
                                container.AlignCenter()
                                         .AlignMiddle()
                                         .Image(BitmapToBytes(logo))
                                         .FitArea();
                            }
                            else
                            {
                                container.Border(1)
                                         .AlignCenter()
                                         .AlignMiddle()
                                         .Text("LOGO")
                                         .FontSize(12)
                                         .Bold();
                            }
                        }
                        catch
                        {
                            container.Border(1)
                                     .AlignCenter()
                                     .AlignMiddle()
                                     .Text("LOGO")
                                     .FontSize(12)
                                     .Bold();
                        }
                    });
                    //row.ConstantItem(80)
                    //    .Height(60)
                    //    .Element(container =>
                    //    {
                    //        if (File.Exists(logoPath))
                    //        {
                    //            container.Image(logoPath);
                    //        }
                    //        else
                    //        {
                    //            container
                    //                .Border(1)
                    //                .AlignCenter()
                    //                .AlignMiddle()
                    //                .Text("LOGO")
                    //                .Bold();
                    //        }
                    //    });
                    // Company Details (Center)
                    row.RelativeItem()
                        .AlignMiddle()
                        .Column(col =>
                        {
                            col.Item()
                                .AlignCenter()
                                .Text("Stock Monitoring Hub")
                                .FontSize(18)
                                .Bold();

                            //col.Item()
                            //    .AlignCenter()
                            //    .Text("Car Accessories & Auto Parts")
                            //    .FontSize(10);

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

                    // Right Side Blank (Logo ke barabar space)
                    row.ConstantItem(120).Element(x =>
                    {
                        // Blank Space
                    });
                    //row.RelativeItem().Column(col =>
                    //{
                    //    col.Item()
                    //        .AlignCenter()
                    //        .Text("CAR ACCESSORY MANAGEMENT STORE")
                    //        .FontSize(22)
                    //        .Bold();

                    //    col.Item()
                    //        .AlignCenter()
                    //        .Text("Car Accessories & Auto Parts");

                    //    col.Item()
                    //        .AlignCenter()
                    //        .Text("Address : Jaipur, Rajasthan");

                    //    col.Item()
                    //        .AlignCenter()
                    //        .Text("Mobile : +91-9876543210 | Email : info@company.com");

                    //    col.Item()
                    //        .AlignCenter()
                    //        .Text("GST No : XXXXXXXXXXXXX");
                    //});
                });

                column.Item()
    .PaddingTop(10)
    .AlignCenter()
    .Text(cmbReportType.Text.ToUpper())
    .FontSize(18)
    .Bold();

                //column.Item()
                //    .AlignCenter()
                //    .Text(cmbReportType.Text.ToUpper())
                //    .FontSize(18)
                //    .Bold();

                column.Item()
    .PaddingTop(5)
    .AlignCenter()
    .Text($"From : {dtpFrom.Value:dd-MM-yyyy}    To : {dtpTo.Value:dd-MM-yyyy}");


                //column.Item().PaddingBottom(10);

                column.Item()
    .PaddingTop(10)
    .LineHorizontal(1);
            });
        }

        private void BuildSummary(IContainer container)
        {
            container
                .Border(1)
                .Padding(10)
                .Column(column =>
                {
                    if (cmbReportType.Text == "Sales Report")
                    {
                        // Total Sales
                        column.Item().Row(row =>
                        {
                            row.RelativeItem().Text("Total Sales").Bold();
                            row.ConstantItem(150)
                                .AlignRight()
                                .Text($"₹ {lblTotalSales.Text}");
                        });

                        // Purchase Cost
                        column.Item()
                            .PaddingTop(5)
                            .Row(row =>
                            {
                                row.RelativeItem().Text("Purchase Cost").Bold();
                                row.ConstantItem(150)
                                    .AlignRight()
                                    .Text($"₹ {lblTotalPurchase.Text}");
                            });

                        // Profit
                        column.Item()
                            .PaddingTop(5)
                            .Row(row =>
                            {
                                row.RelativeItem().Text("Profit").Bold();
                                row.ConstantItem(150)
                                    .AlignRight()
                                    .Text($"₹ {lblProfit.Text}");
                            });
                    }
                    else if (cmbReportType.Text == "Purchase Report")
                    {
                        column.Item().Row(row =>
                        {
                            row.RelativeItem().Text("Total Purchase").Bold();
                            row.ConstantItem(150)
                                .AlignRight()
                                .Text($"₹ {lblTotalPurchase.Text}");
                        });
                    }
                    else
                    {
                        column.Item().Row(row =>
                        {
                            row.RelativeItem().Text("Total Products").Bold();
                            row.ConstantItem(150)
                                .AlignRight()
                                .Text(lblTotalProducts.Text);
                        });
                    }
                });
        }
        private void BuildTable(IContainer container)
        {
            container
                .PaddingTop(15)
                .Table(table =>
                {
                    int columnCount = dgvReport.Columns.Count;

                    table.ColumnsDefinition(columns =>
                    {
                        for (int i = 0; i < columnCount; i++)
                            columns.RelativeColumn();
                    });

                    // Header
                    foreach (DataGridViewColumn column in dgvReport.Columns)
                    {
                        table.Cell()
                            .Background("#1E88E5")
                            .Border(1)
                            .BorderColor("#D0D0D0")
                            .Padding(6)
                            .AlignCenter()
                            .AlignMiddle()
                            .Text(column.HeaderText)
                            .FontSize(10)
                            .FontColor(QuestPDF.Helpers.Colors.White)
                            .Bold();
                    }

                    // Rows
                    bool alternate = false;

                    foreach (DataGridViewRow row in dgvReport.Rows)
                    {
                        if (row.IsNewRow)
                            continue;

                        alternate = !alternate;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.Cell()
                                .Background(alternate ? "#F8F9FA" : "#FFFFFF")
                                .Border(1)
                                .BorderColor("#E0E0E0")
                                .Padding(5)
                                .Text(FormatCellValue(cell.Value))
                                .FontSize(8);
                        }
                    }
                });
        }

        private void BuildFooter(IContainer container)
        {
            container.BorderTop(1)
                .PaddingTop(8)
                .Row(row =>
                {
                    row.RelativeItem()
                        .Text($"Generated On : {DateTime.Now:dd MMM yyyy hh:mm tt}")
                        .FontSize(9);

                    row.RelativeItem()
                        .AlignCenter()
                        .Text("Generated By : Admin")
                        .FontSize(9);

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

                    //row.RelativeItem()
                    //    .AlignRight()
                    //    .Text(text =>
                    //    {
                    //        text.Span("Page ");
                    //        text.CurrentPageNumber();
                    //        text.Span(" of ");
                    //        text.TotalPages();
                    //    })
                    //    .FontSize(9);
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

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            //if (dgvReport.Rows.Count == 0)
            //{
            //    MessageBox.Show("No data available to export.",
            //        "Information",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);

            //    return;
            //}

            //using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            //{
            //    saveFileDialog.Filter = "Excel Workbook|*.xlsx";
            //    saveFileDialog.FileName = "Report.xlsx";

            //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        using (XLWorkbook workbook = new XLWorkbook())
            //        {
            //            var worksheet = workbook.Worksheets.Add("Report");

            //            // Header
            //            for (int i = 0; i < dgvReport.Columns.Count; i++)
            //            {
            //                worksheet.Cell(1, i + 1).Value = dgvReport.Columns[i].HeaderText;
            //                worksheet.Cell(1, i + 1).Style.Font.Bold = true;
            //            }

            //            // Data
            //            for (int i = 0; i < dgvReport.Rows.Count; i++)
            //            {
            //                for (int j = 0; j < dgvReport.Columns.Count; j++)
            //                {
            //                    worksheet.Cell(i + 2, j + 1).Value =
            //                        dgvReport.Rows[i].Cells[j].Value?.ToString();
            //                }
            //            }

            //            worksheet.Columns().AdjustToContents();

            //            workbook.SaveAs(saveFileDialog.FileName);
            //        }

            //        MessageBox.Show("Excel exported successfully.",
            //            "Success",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Information);
            //    }
            //}

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
                saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = $"Report_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Report");

                    // ==========================
                    // Report Title
                    // ==========================

                    worksheet.Range("A1:H1").Merge();
                    worksheet.Cell("A1").Value = cmbReportType.Text.ToUpper() + " REPORT";
                    worksheet.Cell("A1").Style.Font.Bold = true;
                    worksheet.Cell("A1").Style.Font.FontSize = 18;
                    worksheet.Cell("A1").Style.Font.FontColor = XLColor.White;
                    worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.DarkBlue;
                    worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    worksheet.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    worksheet.Row(1).Height = 28;

                    // ==========================
                    // Date
                    // ==========================

                    worksheet.Range("A2:H2").Merge();
                    worksheet.Cell("A2").Value =
                        $"Generated : {DateTime.Now:dd-MMM-yyyy hh:mm tt}";
                    worksheet.Cell("A2").Style.Alignment.Horizontal =
                        XLAlignmentHorizontalValues.Right;
                    worksheet.Cell("A2").Style.Font.Italic = true;
                    worksheet.Cell("A2").Style.Font.FontColor = XLColor.DimGray;

                    // ==========================
                    // Header
                    // ==========================

                    int headerRow = 4;

                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                    {
                        var cell = worksheet.Cell(headerRow, i + 1);

                        cell.Value = dgvReport.Columns[i].HeaderText;

                        cell.Style.Font.Bold = true;
                        cell.Style.Font.FontColor = XLColor.White;
                        cell.Style.Fill.BackgroundColor = XLColor.DarkBlue;
                        cell.Style.Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center;
                        cell.Style.Alignment.Vertical =
                            XLAlignmentVerticalValues.Center;
                    }

                    // ==========================
                    // Data
                    // ==========================

                    int row = 5;

                    for (int i = 0; i < dgvReport.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvReport.Columns.Count; j++)
                        {
                            worksheet.Cell(row, j + 1).Value =
                                dgvReport.Rows[i].Cells[j].Value?.ToString();
                        }

                        row++;
                    }

                    // ==========================
                    // Create Excel Table
                    // ==========================

                    var tableRange =
                        worksheet.Range(headerRow, 1, row - 1, dgvReport.Columns.Count);

                    var table = tableRange.CreateTable();

                    table.Theme = XLTableTheme.TableStyleMedium2;

                    // ==========================
                    // Borders
                    // ==========================

                    tableRange.Style.Border.OutsideBorder =
                        XLBorderStyleValues.Thin;

                    tableRange.Style.Border.InsideBorder =
                        XLBorderStyleValues.Thin;

                    // ==========================
                    // Alignment
                    // ==========================

                    worksheet.Columns().Style.Alignment.Horizontal =
                        XLAlignmentHorizontalValues.Center;

                    worksheet.Columns().AdjustToContents();

                    worksheet.SheetView.FreezeRows(4);

                    workbook.SaveAs(saveFileDialog.FileName);
                }

                MessageBox.Show("Excel exported successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Process.Start(new ProcessStartInfo(saveFileDialog.FileName)
                {
                    UseShellExecute = true
                });
            }
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableDate = cmbReportType.Text != "Stock Report";

            dtpFrom.Enabled = enableDate;
            dtpTo.Enabled = enableDate;

            dtpFrom.Enabled = enableDate;
            dtpTo.Enabled = enableDate;

            if (!enableDate)
            {
                // Stock Report ke liye dates reset
                dtpFrom.Value = DateTime.Today.AddDays(-30);
                dtpTo.Value = DateTime.Today;
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
