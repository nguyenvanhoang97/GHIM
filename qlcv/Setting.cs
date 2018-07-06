using DevExpress.Export;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qlcv
{
    public class Setting
    {
        public static Color GroupColor()
        {
            //return Color.LightCyan;
            //return Color.RoyalBlue;
            //return Color.DarkSeaGreen;
            //return ColorTranslator.FromHtml("#14C30D");
            Color mau = Color.FromArgb(51, 153, 255);
            return mau;
            //return ColorTranslator.FromHtml("#79AE92");
        }
        public static Color RowColor()
        {
            //return Color.LightCyan;
            return Color.LightYellow;
            //return Color.#CEF6CE;
        }
        public static void XuatExcelv2Ten(string _fileName, DevExpress.XtraGrid.Views.Grid.GridView gridView1, GridControl gc)
        {
            //_fileName =  Regex.Replace(_fileName, "[^0-9a-zA-Z]+", "") + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") ;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel 97-2003 Workbook(.xls)|*.xls| Excel Workbook(.xlsx) | *.xlsx";


            dialog.FileName = _fileName.ToUpper();
            DialogResult result = dialog.ShowDialog();
            try
            {
                if (result == DialogResult.OK)
                {
                    string fileName = dialog.FileName;

                    if (dialog.FilterIndex == 0)
                    {
                        XlsExportOptionsEx exportOptions = new XlsExportOptionsEx();
                        //exportOptions.CustomizeSheetHeader += options_CustomizeSheetHeader;

                        //exportOptions.TextExportMode = TextExportMode.Text;
                        exportOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.True;
                        exportOptions.FitToPrintedPageWidth = false;
                        exportOptions.AllowSortingAndFiltering = DevExpress.Utils.DefaultBoolean.True;
                        exportOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
                        exportOptions.ShowPageTitle = DevExpress.Utils.DefaultBoolean.True;
                        gridView1.OptionsPrint.AutoWidth = false;
                        //
                        gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
                        gridView1.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                        gridView1.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
                        gridView1.ColumnPanelRowHeight = 70;

                        gridView1.AppearancePrint.EvenRow.Options.UseTextOptions = true;
                        gridView1.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                        gridView1.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;


                        // gridView1.AppearancePrint.OddRow.Options.UseTextOptions = true;
                        gridView1.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                        gridView1.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;


                        gridView1.OptionsPrint.AllowMultilineHeaders = true;




                        gridView1.OptionsPrint.UsePrintStyles = true;

                        foreach (GridColumn c in gridView1.Columns)
                        {
                            c.AppearanceCell.Options.UseTextOptions = true;
                            c.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;


                        }
                        gridView1.OptionsView.RowAutoHeight = true;
                        //gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
                        //gridView1.OptionsPrint.EnableAppearanceOddRow = true;

                        gridView1.OptionsPrint.AllowMultilineHeaders = true;
                        exportOptions.ExportType = ExportType.WYSIWYG;
                        //exportOptions.ExportType = ExportType.DataAware;


                        gc.ExportToXls(fileName, exportOptions);

                        System.Diagnostics.Process.Start(fileName);
                    }
                    else
                    {
                        XlsxExportOptionsEx exportOptions = new XlsxExportOptionsEx();
                        //exportOptions.CustomizeSheetHeader += options_CustomizeSheetHeader;

                        //exportOptions.TextExportMode = TextExportMode.Text;
                        exportOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.True;
                        exportOptions.FitToPrintedPageWidth = false;
                        exportOptions.AllowSortingAndFiltering = DevExpress.Utils.DefaultBoolean.True;
                        exportOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
                        exportOptions.ShowPageTitle = DevExpress.Utils.DefaultBoolean.True;
                        gridView1.OptionsPrint.AutoWidth = false;
                        //
                        gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
                        gridView1.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                        gridView1.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
                        gridView1.ColumnPanelRowHeight = 70;

                        gridView1.AppearancePrint.EvenRow.Options.UseTextOptions = true;
                        gridView1.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                        gridView1.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;


                        // gridView1.AppearancePrint.OddRow.Options.UseTextOptions = true;
                        gridView1.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                        gridView1.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;


                        gridView1.OptionsPrint.AllowMultilineHeaders = true;




                        gridView1.OptionsPrint.UsePrintStyles = true;

                        foreach (GridColumn c in gridView1.Columns)
                        {
                            c.AppearanceCell.Options.UseTextOptions = true;
                            c.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                        }
                        gridView1.OptionsView.RowAutoHeight = true;
                        //gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
                        //gridView1.OptionsPrint.EnableAppearanceOddRow = true;

                        gridView1.OptionsPrint.AllowMultilineHeaders = true;
                        exportOptions.ExportType = ExportType.WYSIWYG;
                        //exportOptions.ExportType = ExportType.DataAware;


                        gc.ExportToXlsx(fileName, exportOptions);

                        System.Diagnostics.Process.Start(fileName);

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
