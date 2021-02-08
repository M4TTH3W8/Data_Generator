using Data_Generator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Generator
{
    public partial class GenerateFieldControl : UserControl
    {
        public DataType DataName { get; private set; }

        public GenerateFieldControl()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(DataType)))
            {
                comboBox1.Items.Add(item);
                
            }
        }

        public void SetText(string text)
        {
            textBox1.Text = text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataType result;
            var temp = Enum.TryParse<DataType>(comboBox1.SelectedItem.ToString(), out result);
            DataName = result;
            
        }


    }
}
