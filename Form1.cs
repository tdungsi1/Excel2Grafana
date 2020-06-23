using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Newtonsoft.Json;
using System.IO;
using System.Linq.Expressions;
using System.Data.OleDb;
using System.Data.Common;
using ExcelDataReader;
using Google.Apis.Sheets.v4.Data;
using System.Diagnostics;
using System.Xml;
using Excel2Grafana.Properties;
using System.Reflection;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btinput.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            
        }
        /*private static void Convert2Json(string inputFile, string outputFile)
        {
            //"HDR=Yes;" indicates that the first row contains column names, not data.
            using (var inFile = File.Open(inputFile, FileMode.Open, FileAccess.Read))
            using (var outFile = File.CreateText(outputFile))
            using (var reader = ExcelReaderFactory.CreateReader(inFile,
            new ExcelReaderConfiguration { FallbackEncoding = Encoding.GetEncoding(1252) }))
            using (var writer = new JsonTextWriter(outFile))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartArray();
                //You can skip the first row, as it contains the titles.
                reader.Read();
                do
                {
                    while (reader.Read())
                    {
                        //We don't need an empty object
                        var LeasedLine = reader.GetString(0);
                        if (string.IsNullOrEmpty(LeasedLine)) break;

                        writer.WriteStartObject();
                        //Select Columns and values
                        writer.WritePropertyName("LeasedLine");
                        writer.WriteValue(LeasedLine);

                        writer.WritePropertyName("DeviceLayer2");
                        writer.WriteValue(reader.GetString(1));

                        writer.WritePropertyName("InterfaceLayer2");
                        writer.WriteValue(reader.GetString(2));

                        writer.WritePropertyName("DeviceLayer3");
                        writer.WriteValue(reader.GetString(3));

                        writer.WritePropertyName("InterfaceLayer3");
                        writer.WriteValue(reader.GetString(4));

                        writer.WritePropertyName("IpAddress");
                        writer.WriteValue(reader.GetString(5));

                        writer.WritePropertyName("Provider");
                        writer.WriteValue(reader.GetString(6));

                        writer.WritePropertyName("Bandwidth");
                        writer.WriteValue(reader.GetString(7));

                        writer.WritePropertyName("Location");
                        writer.WriteValue(reader.GetString(8));

                        writer.WritePropertyName("Cost");
                        writer.WriteValue(reader.GetDouble(9));

                        writer.WritePropertyName("CircuitID");
                        writer.WriteValue(reader.GetString(10));

                        writer.WritePropertyName("ContractDueDate");
                        writer.WriteValue(reader.GetString(11));

                        writer.WritePropertyName("PaidBy");
                        writer.WriteValue(reader.GetString(12));

                        writer.WritePropertyName("Tag");
                        writer.WriteValue(reader.GetString(13));


                        writer.WriteEndObject();
                    }
                } while (reader.NextResult());

                writer.WriteEndArray();
            }
        }
    */
        /*public static void ConvertToJson(string excel)
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;

                //The workbook is opened.
                try
                {
                    /*FileStream fileStream = new FileStream(excel.ToString(), FileMode.Open);



                    IWorkbook workbook = application.Workbooks.Open(fileStream, ExcelOpenType.Automatic);
                    IWorksheet worksheet = workbook.Worksheets[0];

                    //Export worksheet data into CLR Objects
                    IList<Leaseline> LL = worksheet.ExportData<Leaseline>(1, 1, worksheet.UsedRange.LastRow, workbook.Worksheets[0].UsedRange.LastColumn);

                    //open file stream
                    using (StreamWriter file = File.CreateText("output.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();

                        //serialize object directly into file stream
                        serializer.Serialize(file, LL);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Environment.Exit(0);
                }
            }
        }*/

 private void btinput_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileinput = new OpenFileDialog();
            fileinput.ShowDialog();
           
            //MessageBox.Show("Output path!");
            //SaveFileDialog fileoutput = new SaveFileDialog();
            //fileoutput.ShowDialog();
            /*if (fileinput.FileName == "")
            {
                MessageBox.Show("Nothing!");
                Environment.Exit(0);
            }
            else
            {
                
                //Convert2Json(fileinput.FileName.ToString(), fileoutput.FileName);
                MessageBox.Show("Successful");
            }*/
        }

        private void btjson_Click(object sender, EventArgs e)
        {
            string xmlbase = "";
            OpenFileDialog fileinput = new OpenFileDialog();
            fileinput.ShowDialog();
            Assembly asm = Assembly.GetExecutingAssembly();
            using (Stream stream = asm.GetManifestResourceStream("Excel2Grafana.Resources.xmlex.xml"))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    xmlbase = reader.ReadToEnd();
                }
            }
            string xmlinput = xmlbase;
            //MessageBox.Show(xmlinput); // Completed storing xml-based 
            //It's time to get the input json
            string json_string = "";
            JObject json;
            using (StreamReader r = new StreamReader(fileinput.FileName))
            {
                json_string = r.ReadToEnd();
                json = JObject.Parse(json_string);
            }
            int i = 0; int n = 0;
            foreach (var item in json["Leased line"])
            {
                n++;
            }
            //MessageBox.Show(n.ToString());
            foreach (var item in json["Leased line"])
            {

                i++;
                if (i % 2 != 0 && i < n)
                {
                    xmlinput = xmlbase;

                    //tbdebug.AppendText(item["Provider"].ToString());
                    // tbdebug.AppendText("\n");

                    xmlinput = xmlinput.Replace("dvlayer2", item["Device Layer 2"].ToString());
                    xmlinput = xmlinput.Replace("iflayer2", item["Interface Layer 2"].ToString());
                    xmlinput = xmlinput.Replace("dvlayer3", item["Device Layer 3"].ToString());
                    xmlinput = xmlinput.Replace("intlayer3", item["Inteface Layer 3"].ToString());
                    xmlinput = xmlinput.Replace("ipaddress_1content", item["IP Address"].ToString());
                    xmlinput = xmlinput.Replace("provider_content", item["Provider "].ToString());
                    xmlinput = xmlinput.Replace("bandwidth_content", item["Bandwidth"].ToString());
                    xmlinput = xmlinput.Replace("location_content", item["Location"].ToString());
                    xmlinput = xmlinput.Replace("cost_content", item["Cost"].ToString());
                    xmlinput = xmlinput.Replace("circuit_content", item["CircuitID"].ToString());
                    xmlinput = xmlinput.Replace("contract_content", item["Contract due date"].ToString());
                    xmlinput = xmlinput.Replace("paid_con", item["Paid by"].ToString());
                    xmlinput = xmlinput.Replace("tag_con", item["Tag"].ToString());


                    xmlinput = xmlinput.Replace("dv2layer2", item.Next["Device Layer 2"].ToString());
                    xmlinput = xmlinput.Replace("if2layer2", item.Next["Interface Layer 2"].ToString());
                    xmlinput = xmlinput.Replace("dv2layer3", item.Next["Device Layer 3"].ToString());
                    xmlinput = xmlinput.Replace("int2layer3", item.Next["Inteface Layer 3"].ToString());
                    xmlinput = xmlinput.Replace("ipaddress_2content", item.Next["IP Address"].ToString());
                    xmlinput = xmlinput.Replace("provider_2content", item.Next["Provider "].ToString());
                    xmlinput = xmlinput.Replace("bandwidth_2content", item.Next["Bandwidth"].ToString());
                    xmlinput = xmlinput.Replace("location_2content", item.Next["Location"].ToString());
                    xmlinput = xmlinput.Replace("cost_2content", item.Next["Cost"].ToString());
                    xmlinput = xmlinput.Replace("circuit_2content", item.Next["CircuitID"].ToString());
                    xmlinput = xmlinput.Replace("contract_2content", item.Next["Contract due date"].ToString());
                    xmlinput = xmlinput.Replace("paid_2con", item.Next["Paid by"].ToString());
                    xmlinput = xmlinput.Replace("tag_2con", item.Next["Tag"].ToString());


                    //System.IO.File.WriteAllText(@"C:\TEST\xmlinput.txt", xmlinput);

                    //Thread.Sleep(30000);
                }
                else if (i % 2 == 0)
                {
                    Regex illegalInFileName = new Regex(@"[\\/:*?""<>|]");

                    string Filename = item["Leased Line "].ToString() + ".xml";
                    Filename = illegalInFileName.Replace(Filename, "");
                    //MessageBox.Show(Filename);
                    string path = @"C:\TEST\" + Filename;
                    System.IO.File.WriteAllText(path, xmlinput);
                    xmlinput = xmlbase;
                }  
                    
          

            }
            
            

        }
    }
}
