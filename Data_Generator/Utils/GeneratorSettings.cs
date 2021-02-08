using Data_Generator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Generator.Utils
{
    public class GeneratorSettings
    {
        public string Language { get; set; }
        public int Amount { get; set; }
        public int Size { get; set; }
        public IDictionary<string, DataType> DataSets = new Dictionary<string, DataType>();

    }
}
