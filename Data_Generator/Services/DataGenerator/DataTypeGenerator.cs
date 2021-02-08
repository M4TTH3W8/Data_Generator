using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.Extensions;
using Data_Generator;
using Data_Generator.Model;
using Data_Generator.Utils;

namespace Data_Generator.Services.DataGenerator
{
    public class DataTypeGenerator
    {
        public IDictionary<string, string> GenerateSingleData(GeneratorSettings generatorSettings)
        {
            var result = new Dictionary<string, string>();
            string setLanguage = generatorSettings.Language;
            int size = generatorSettings.Size;

            foreach (var item in generatorSettings.DataSets)
            {
                var tempvalue = GenerateByDataType(item.Value, setLanguage, size);
                result.Add(item.Key, tempvalue);
            }
            return result;
        }

        public string GenerateByDataType(DataType dataName, string language, int size)
        {
            switch (dataName)
            {
                case DataType.FirstName:
                    return new Bogus.DataSets.Name(language).FirstName().MaximumLengthOfData(size, size);
                case DataType.LastName:
                    return new Bogus.DataSets.Name(language).LastName().MaximumLengthOfData(size, size);
                case DataType.City:
                    return new Bogus.DataSets.Address(language).City().MaximumLengthOfData(size, size);
                case DataType.PhoneNumber:
                    return new Bogus.DataSets.PhoneNumbers(language).PhoneNumber().MaximumLengthOfData(size, size);
                case DataType.ZipCode:
                    return new Bogus.DataSets.Address(language).ZipCode().MaximumLengthOfData(size, size);
                case DataType.CreditCard:
                    return new Bogus.DataSets.Finance().CreditCardNumber().MaximumLengthOfData(size, size);
                case DataType.Date:
                    return new Bogus.DataSets.Date(language).Recent().ToString();
                case DataType.Email:
                    return new Bogus.DataSets.Internet(language).Email();
                case DataType.Password:
                    return new Bogus.DataSets.Internet(language).Password().MaximumLengthOfData(size, size);
                case DataType.Username:
                    return new Bogus.DataSets.Internet(language).UserName().MaximumLengthOfData(size, size);
            }
            return string.Empty;
        }

            public IList<IDictionary<string, string>> GenerateMultipleData(GeneratorSettings generatorSettings)
            {
            string setLanguage = generatorSettings.Language;
            var result = new List<IDictionary<string, string>>();
            for (int i = 0; i < generatorSettings.Amount; i++)
            {
                string firstName = new Bogus.DataSets.Name(setLanguage).FirstName();
                string lastName = new Bogus.DataSets.Name(setLanguage).LastName();
                Dictionary<string, string> item = new Dictionary<string, string>();
                item.Add("firstName", firstName);
                item.Add("lastName", lastName);
                result.Add(item);
            }
            return result;
            }
        public IList<IDictionary<string, string>> GenerateSingleData2(GeneratorSettings generatorSettings)
        {
            string setLanguage = generatorSettings.Language;
            var result = new List<IDictionary<string, string>>();
            int size = generatorSettings.Size;
            
            for (int i = 0; i < generatorSettings.Amount; i++)
            {
                Dictionary<string, string> items = new Dictionary<string, string>();
                foreach (var item in generatorSettings.DataSets)
                {
                    var tempvalue = GenerateByDataType(item.Value, setLanguage, size);
                    items.Add(item.Key, tempvalue);
                    result.Add(items);
                }
            }
            return result;
        }
    }
}