using Data_Generator.Model;
using System.Collections.Generic;

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
