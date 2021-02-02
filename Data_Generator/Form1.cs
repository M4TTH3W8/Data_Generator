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

namespace Data_Generator
{
    public partial class Form1 : Form
    {
        private GeneratorSettings _generatorSettings;
        private DataTypeGenerator _dataTypeGenerator;

        public Form1()
        {
            InitializeComponent();
            _generatorSettings = new GeneratorSettings();
            _dataTypeGenerator = new DataTypeGenerator();
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
           var result = _dataTypeGenerator.GenerateData2(_generatorSettings);
            textBox1.Text = result["firstName"];
            textBox2.Text = result["lastName"];
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
           var temp = _dataTypeGenerator.GenerateData3(_generatorSettings);
            foreach (var x in temp) {
                Console.WriteLine($"firstName: {x["firstName"]} lastName: {x["lastName"]}");
            }
           // Console.WriteLine(temp.ToString());
        }
    }
}
