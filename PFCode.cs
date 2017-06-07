using Infragistics.Documents.Excel;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using JAAB.Common;
using JAAB.Common.Table;
using JAAB.Common.Table.Query;
using JAAB.External.BoA;
using JAAB.Service;
using JAAB.Service.Payment;
using JAAB.Service.Payroll;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAAB.Processes;
using System.Drawing;
using System.Drawing.Imaging;
using Infragistics.Documents.Excel.Sorting;
using LogLibrary;
using JAAB.External.Messaging;
using System.Net.Mail;
using JAAB.Service.Shared;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CodeCheckerProject
{
    /// <summary>
    /// This project is meant to test specific methods or code found in SAM's many shared libraries. It's primary focus is meant to verify what the returns of whatever method you
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            const int applicationId = 2;
            const string applicationName = "TitanClient";
            JAAB.Service.ApplicationSettingService.InitConfig("Not Published", applicationId, applicationName);
            JAAB.Service.ApplicationSettingService.SetUser(JAAB.Service.UserService.GetEntityByPrimaryKey(2857));

            Console.WriteLine("Enter t to run test method or press e to exit");


            string input;
            while ((input = Console.ReadLine()) != "e")
            {
                if (input == "t")
                {
					Test();
					Console.WriteLine("Complete");
                }
            }
        }

		public static void Test()
		{
			var inStream = new StreamReader(@"C:\Users\jachristensen\Downloads\PFDB_Full.json");

			try
			{
				var serializer = new JsonSerializer();
				JObject superJson = (JObject)serializer.Deserialize(inStream, typeof(JObject));

				var bigJ = superJson.First;
				var json = bigJ.First;
				while (json.FirstOrDefault() != null)
				{
					Console.WriteLine(json.First);
					json.Remove();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				inStream.Close();
				inStream.Dispose();
			}
			
		}

		public static void Test2()
		{
			var dir = new DirectoryInfo(@"C:\Users\jachristensen\Downloads\Pathfinder Helper");
			var files = dir.GetFiles("PFDB*.xlsx");
			var outStream = new StreamWriter(@"C:\Users\jachristensen\Downloads\PFDB_Full.json");

			try
			{
				// load all workbooks in folder
				// foreach, go through and get length of columns

				var superJson = new JObject();
				
				foreach (var file in files)
				{
					var bigJ = new JObject();
					var colSizes = new List<int>();
					var colNames = new List<string>();
					var workbook = Workbook.Load(file.FullName);
					var worksheet = workbook.Worksheets.First();
					foreach (var cell in worksheet.Rows[0].Cells)
					{
						colNames.Add(cell.Value.ToString());
						colSizes.Add(0);
					}
					int r = 0;
					foreach (var row in worksheet.Rows)
					{
						var json = new JObject();
						int i = 0;
						foreach (var cell in row.Cells)
						{
							json.Add(colNames[i], cell.Value.ToString());
							i++;
						}
						bigJ.Add("row" + r++, json.ToString());
					}
					superJson.Add(file.Name, bigJ.ToString());

					Console.WriteLine("==> " + file.Name);
					for (int i = 0; i < colSizes.Count; i++)
					{
						Console.WriteLine(colNames[i] + ": " + colSizes[i].ToString());
					}
					Console.WriteLine();
				}

				outStream.Write(superJson.ToString());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				outStream.Close();
				outStream.Dispose();
			}
			
		}

		
	}
}
