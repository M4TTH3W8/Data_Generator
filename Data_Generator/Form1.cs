using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bogus;
using Data_Generator.Utils;
using Data_Generator.Services.DataGenerator;
using Data_Generator.Model;

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

            _generatorSettings.Language = comboBoxLanguage.SelectedItem.ToString();
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
            //just for testing purposes
            Console.WriteLine(languageId);
            _generatorSettings.Language = languageId;
        }

        private void buttonMultipleResults_Click(object sender, EventArgs e)
        {
            labelAmount.Visible = true;
            numericAmount.Visible = true;
            labelExport.Visible = true;
            checkBoxXLS.Visible = true;
            checkBoxCSV.Visible = true;
            checkBoxXml.Visible = true;
            buttonGenerate.Visible = true;
        }

        private void numericAmount_ValueChanged(object sender, EventArgs e)
        {
            int Amount = int.Parse(numericAmount.Value.ToString());
            _generatorSettings.Amount = Amount;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            decimal amount = numericAmount.Value;
            _generatorSettings.Amount = Convert.ToInt32(amount);

            decimal size = numericSize.Value;
            _generatorSettings.Size = Convert.ToInt32(size);

            _generatorSettings.DataSets = new Dictionary<string, DataType>();
            foreach (var control in _generateFieldControls)
            {
                //need to find a way to instead of getting control name get wat type of data we want and possibly a check that only once
                //we get specific type or something
                _generatorSettings.DataSets.Add(control.Name, control.DataName);

            }

            var temp = _dataTypeGenerator.GenerateSingleData2(_generatorSettings);
            foreach (var x in temp)
            {
                //Console.WriteLine($"firstName: {x["item.Key"]}");
            }
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(temp);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(@"C:\Output.json", json);
            //Console.WriteLine(temp.ToString());
        }
/*        private void kopiamultiple()
        {
            var temp = _dataTypeGenerator.GenerateMultipleData(_generatorSettings);
            foreach (var x in temp)
            {
                Console.WriteLine($"firstName: {x["firstName"]} lastName: {x["lastName"]}");
            }
            // Console.WriteLine(temp.ToString());
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(temp);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(@"C:\Output.json", json);
        }*/

        private void buttonAddField_Click(object sender, EventArgs e)
        {
            int controlX = 1;
            int controlY = 60 + 35 * _generateFieldControls.Count();
            GenerateFieldControl newGenerateFieldControl = new GenerateFieldControl();
            newGenerateFieldControl.Location = new Point(controlX, controlY);
            newGenerateFieldControl.Name = "Control" + (_generateFieldControls.Count() + 1);
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
