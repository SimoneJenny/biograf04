using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace biograf01.Tools
{
     class GetfileforSQL
     {
        // static void getfile(string[] args)
        //{
            //var tdiMasterpath = @"C:\Users\hanse11s\Desktop\filer\Projects\Meerwind\tdiMasterData(2).xlsx";
            //var tdiParametersPath = @"C:\Users\hanse11s\Desktop\filer\Projects\Meerwind\xinfo_144.0.0.3_R1.00.xlsx";
            //var tdiSqlScript = @"C:\Users\hanse11s\Desktop\filer\Projects\Meerwind\tdiMasterData.sql";

            //foreach (var gets in args)
            //{
            //    var argSplitArray = gets.Split('=');
            //    switch (argSplitArray[0])
            //    {
            //        case "tdiMasterPath":
            //            string curFile = argSplitArray[1];
            //            Console.WriteLine(File.Exists(curFile) ? "File exits" : "File does not exist");
            //            tdiParametersPath = curFile;
            //            break;
            //        case "tdiParametersPath":
            //            string curFile2 = @argSplitArray[1];
            //            Console.WriteLine(File.Exists(curFile2) ? "File exits" : "File does not exist");
            //            tdiParametersPath = curFile2;
            //            break;
            //        case "tdiSqlScript":
            //            string curFile3 = argSplitArray[1];
            //            string temp = Path.GetDirectoryName(curFile3);
            //            Console.WriteLine(Directory.Exists(temp) ? "Directory exits" : "Directory does not exist");
            //            tdiSqlScript = curFile3;
            //            break;
            //    }
            //}

            //Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //Excel.Workbook xlWb = xlApp.Workbooks.Open(tdiMasterpath);
            //Excel._Worksheet xlws = xlWb.Sheets[1];
            //Excel.Range y = xlws.UsedRange;

            //int rows = y.Rows.Count;
            //int cols = y.Columns.Count;

            //using (var w = new StreamWriter(tdiSqlScript))
            //{
            //    w.WriteLine($"Use EDA_Configuration");
            //    w.WriteLine($"GO");

            //    int counter = 0;
            //    for (int i = 2; i <= rows; i++)
            //    {
            //        var tdiName = "Wtc.TDI." + xlws.Cells[i, 1].Value2;
            //        var unit = xlws.Cells[i, 3].Value2;
            //        var description = xlws.Cells[i, 2].Value2;
            //        var x = Regex.Replace(description, @"(')", "\"");
            //        description = x;
            //        var groupname = xlws.Cells[i, 5].Value2;

            //        w.WriteLine(
            //                                $"INSERT[dbo].[TurbineTag]([TagName], [Unit], [Description], [GroupName]) VALUES(N'{tdiName}', N'{unit}', N'{description}', N'{groupname}')");
            //        counter++;
            //    }

            //    Console.WriteLine("Master Database completed. counter = {0}", counter);

            //    Excel.Application xlApp1 = new Microsoft.Office.Interop.Excel.Application();
            //    Excel.Workbook xlWb1 = xlApp1.Workbooks.Open(tdiParametersPath);
            //    Excel._Worksheet xlws1 = xlWb1.Sheets[6];
            //    Excel.Range y1 = xlws1.UsedRange;

            //    int rows1 = y1.Rows.Count;
            //    int cols1 = y1.Columns.Count;

            //    for (int i = 5; i <= rows1; i++)
            //    {
            //        var readLevel = int.TryParse(xlws1.Cells[i, 12].Value2, out int result);
            //        if (readLevel == false)
            //        {
            //            continue;
            //        }


            //        var Group = "PARA";

            //        if (result > 2)
            //        {
            //            Group = "DPAR";
            //        }

            //        var tdiDefault = "Wtc.TDI.UP" + xlws1.Cells[i, 2].Value2 + ".Default";
            //        var tdiMin = "Wtc.TDI.UP" + xlws1.Cells[i, 2].Value2 + ".Min";
            //        var tdiMax = "Wtc.TDI.UP" + xlws1.Cells[i, 2].Value2 + ".Max";
            //        var tdiResetReq = "Wtc.TDI.UP" + xlws1.Cells[i, 2].Value2 + ".ResetReq";
            //        var tdiValue = "Wtc.TDI.UP" + xlws1.Cells[i, 2].Value2 + ".Value";
            //        var tdiDescription = xlws1.Cells[i, 9].Value2;
            //        var tdiunit = xlws1.Cells[i, 7].Value2;

            //        var x = Regex.Replace(tdiDescription, @"(')", "\"");
            //        tdiDescription = x;

            //        w.WriteLine(
            //            $"INSERT[dbo].[TurbineTag]([TagName], [Unit], [Description], [GroupName]) VALUES(N'{tdiDefault}', N'{tdiunit}', N'{tdiDescription}', N'{Group}')");
            //        w.WriteLine(
            //            $"INSERT[dbo].[TurbineTag]([TagName], [Unit], [Description], [GroupName]) VALUES(N'{tdiMin}', N'{tdiunit}', N'{tdiDescription}', N'{Group}')");
            //        w.WriteLine(
            //            $"INSERT[dbo].[TurbineTag]([TagName], [Unit], [Description], [GroupName]) VALUES(N'{tdiMax}', N'{tdiunit}', N'{tdiDescription}', N'{Group}')");
            //        w.WriteLine(
            //            $"INSERT[dbo].[TurbineTag]([TagName], [Unit], [Description], [GroupName]) VALUES(N'{tdiResetReq}', N'{tdiunit}', N'{tdiDescription}', N'{Group}')");
            //        w.WriteLine(
            //            $"INSERT[dbo].[TurbineTag]([TagName], [Unit], [Description], [GroupName]) VALUES(N'{tdiValue}', N'{tdiunit}', N'{tdiDescription}', N'{Group}')");

            //        counter = counter + 5;

            //    }

            //    Console.WriteLine(counter);
            //}

            //Console.WriteLine("Job complete - Press Enter to exit");
            //Console.ReadKey();
        //}
    }
}
