using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Data_Generator.Utils;
using Data_Generator.Services.DataGenerator;
using Data_Generator.Model;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using System.Data;
using ClosedXML.Excel;

namespace Data_Generator
{
    public partial class Form1 : Form
    {
        private GeneratorSettings _generatorSettings;
        private DataTypeGenerator _dataTypeGenerator;
        private IList<GenerateFieldControl> _generateFieldControls;

    public Form1()
        {
            InitializeComponent();
            _generatorSettings = new GeneratorSettings();
            _dataTypeGenerator = new DataTypeGenerator();
            _generateFieldControls = new List<GenerateFieldControl>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxLanguage.SelectedIndex = 0;
            numericAmount.Value = 1;
            numericSize.Value = 100;
        }

        private void buttonSingleResult_Click(object sender, EventArgs e)
        {
            _generatorSettings.Amount = 1;
            decimal size = numericSize.Value;
            _generatorSettings.Size = Convert.ToInt32(size);

            _generatorSettings.DataSets = new Dictionary<string, DataType>();

            foreach (var control in _generateFieldControls)
            {
                _generatorSettings.DataSets.Add(control.Name, control.DataName);
            }

            var result = _dataTypeGenerator.GenerateSingleData(_generatorSettings);

            foreach (var res in result)
            {
                var control = _generateFieldControls.SingleOrDefault(x => x.Name.Equals(res.Key));
                if (control != null)
                {
                    control.SetText(res.Value);
                }
            }
        }

        public void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string languageId = comboBoxLanguage.SelectedItem.ToString();
            if (languageId == "Polski")
            {
                _generatorSettings.Language = "pl";
            }

            else if (languageId == "Angielski")
            {
                _generatorSettings.Language = "en_GB";
            }

            else if (languageId == "Niemiecki")
            {
                _generatorSettings.Language = "de";
            }
        }

        private void buttonMultipleResults_Click(object sender, EventArgs e)
        {
            labelAmount.Visible = true;
            numericAmount.Visible = true;
            labelExport.Visible = true;
            checkBoxXLS.Visible = true;
            checkBoxCSV.Visible = true;
            checkBoxXml.Visible = true;
            checkBoxJson.Visible = true;
            buttonGenerate.Visible = true;
        }

        private void numericAmount_ValueChanged(object sender, EventArgs e)
        {
            int Amount = int.Parse(numericAmount.Value.ToString());
            _generatorSettings.Amount = Amount;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string subPath = @"C:\GeneratedData\";

            decimal amount = numericAmount.Value;
            _generatorSettings.Amount = Convert.ToInt32(amount);

            decimal size = numericSize.Value;
            _generatorSettings.Size = Convert.ToInt32(size);

            _generatorSettings.DataSets = new Dictionary<string, DataType>();
            
            foreach (var control in _generateFieldControls)
            {
                string dataType = control.DataName.ToString();
                _generatorSettings.DataSets.Add(dataType, control.DataName);
            }

            var temp = _dataTypeGenerator.GenerateMultipleData(_generatorSettings);
            var json = JsonConvert.SerializeObject(temp);

            if (checkBoxJson.Checked)
            {
                //this contains verification if directory already exists
                Directory.CreateDirectory(subPath);
                File.WriteAllText(@"C:\GeneratedData\GeneratedData.json", json);
            }

            if (checkBoxXml.Checked)
            {
                //this contains verification if directory already exists
                Directory.CreateDirectory(subPath);
                XmlDocument xml = JsonConvert.DeserializeXmlNode("{\"element\":" + json + "}", "root");
                xml.Save(@"C:\GeneratedData\GeneratedData.xml");
            }

            if (checkBoxCSV.Checked)
            {
                XmlDocument xml = JsonConvert.DeserializeXmlNode("{\"element\":" + json + "}", "root");
                XmlDocument xmldoc = new XmlDocument();

                xmldoc.LoadXml(xml.InnerXml);
                XmlReader xmlReader = new XmlNodeReader(xml);

                DataSet dataSet = new DataSet();
                dataSet.ReadXml(xmlReader);

                var dataTable = dataSet.Tables[0];

                var lines = new List<string>();

                string[] columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();

                var header = string.Join(",", columnNames);
                lines.Add(header);
                var valueLines = dataTable.AsEnumerable().Select(row => string.Join(",", row.ItemArray));
                lines.AddRange(valueLines);

                //this contains verification if directory already exists
                Directory.CreateDirectory(subPath);
                File.WriteAllLines(@"C:\GeneratedData\GeneratedData.csv", lines);
            }

            if (checkBoxXLS.Checked)
            {
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));
                XLWorkbook wb = new XLWorkbook();

                //this contains verification if directory already exists
                Directory.CreateDirectory(subPath);
                wb.Worksheets.Add(dt, "Spreadsheet");
                wb.SaveAs(@"C:\GeneratedData\GeneratedData.xlsx");
            }
        }

        private void buttonAddField_Click(object sender, EventArgs e)
        {
            int controlX = 1;
            int controlY = 60 + 35 * _generateFieldControls.Count();

            GenerateFieldControl newGenerateFieldControl = new GenerateFieldControl();

            newGenerateFieldControl.Location = new Point(controlX, controlY);
            newGenerateFieldControl.Name = "Typ" + (_generateFieldControls.Count() + 1);

            this.Controls.Add(newGenerateFieldControl);
            _generateFieldControls.Add(newGenerateFieldControl);
        }

        private void numericSize_ValueChanged(object sender, EventArgs e)
        {
            int Size = int.Parse(numericSize.Value.ToString());
            _generatorSettings.Size = Size;
        }

        private void buttonRemoveField_Click_1(object sender, EventArgs e)
        {
            if (_generateFieldControls.Count <= 0)
            {
                return;
            }

            var toRemove = _generateFieldControls.Last();
            this.Controls.Remove(toRemove);
            _generateFieldControls.Remove(toRemove);
        }
    }
}