using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (checkBox1.Checked)
            {
                string imie = new Bogus.DataSets.Name("pl").FirstName();
                textBox1.Text = imie;
            }
            if (checkBox2.Checked)
            {
                string nazwisko = new Bogus.DataSets.Address("pl").StreetAddress();
                textBox2.Text = nazwisko;
            }*/
            //var result = _dataTypeGenerator.GenerateSingleData(_generatorSettings);
            //textBox1.Text = result["firstName"];
            //textBox2.Text = result["lastName"];
            _generatorSettings.Amount = 1;
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
                if (control != null )
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

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Visible = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int Amount = int.Parse(numericUpDown1.Value.ToString());
            _generatorSettings.Amount = Amount;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           var temp = _dataTypeGenerator.GenerateMultipleData(_generatorSettings);
            foreach (var x in temp) {
                Console.WriteLine($"firstName: {x["firstName"]} lastName: {x["lastName"]}");
            }
            // Console.WriteLine(temp.ToString());
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(temp);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(@"C:\Output.json", json);
        }

        //private static int n = 1;
        private void buttonAddField_Click(object sender, EventArgs e)
        {
            int controlX = 16;
            int controlY = 77 + 55*_generateFieldControls.Count();
            
            GenerateFieldControl newGenerateFieldControl = new GenerateFieldControl();
            newGenerateFieldControl.Location = new Point(controlX, controlY);
            newGenerateFieldControl.Name = "Control" + (_generateFieldControls.Count() + 1);
            this.Controls.Add(newGenerateFieldControl);
            _generateFieldControls.Add(newGenerateFieldControl);
            
            
/*            n = n + 1;
            TextBox[] textBox = new TextBox[n];
            Label[] label = new Label[n];
            int labelX, labelY, textboxX, textboxY;

            labelX = 16;
            labelY = 77;
            textboxX = 104;
            textboxY = 16;

            for (int i = 0; i < n; i++)
            {
                textBox[i] = new TextBox();
                textBox[i].Name = "n" + i;
                textBox[i].Text = "n" + i;
                textBox[i].Location = new Point(textboxX, textboxY);

                label[i] = new Label();
                label[i].Name = "n" + i;
                label[i].Text = "n" + i;
                label[i].Location = new Point(labelX, labelY);

                labelY += 55;
                textboxY += 55;
            }

            for (int i = 0; i < n; i++)
            {
                this.Controls.Add(textBox[i]);
                this.Controls.Add(label[i]);
            }*/
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int Size = int.Parse(numericUpDown2.Value.ToString());
            _generatorSettings.Size = Size;
        }

        private void generateFieldControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
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
