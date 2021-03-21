using System.Collections.Generic;
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
            if (dataName == DataType.Imie)
            {
                return new Bogus.DataSets.Name(language).FirstName().MaximumLengthOfData(size);
            }

            else if (dataName == DataType.Nazwisko)
            {
                return new Bogus.DataSets.Name(language).LastName().MaximumLengthOfData(size);
            }

            else if (dataName == DataType.Miasto)
            {
                return new Bogus.DataSets.Address(language).City().MaximumLengthOfData(size);
            }

            else if (dataName == DataType.Numer_Telefonu)
            {
                return new Bogus.DataSets.PhoneNumbers(language).PhoneNumber().MaximumLengthOfData(size);
            }

            else if (dataName == DataType.Kod_Pocztowy)
            {
                return new Bogus.DataSets.Address(language).ZipCode().MaximumLengthOfData(size);
            }

            else if (dataName == DataType.Karta_Kredytowa)
            {
                return new Bogus.DataSets.Finance().CreditCardNumber().MaximumLengthOfData(size);
            }

            else if (dataName == DataType.Data)
            {
                return new Bogus.DataSets.Date(language).Recent().ToString();
            }

            else if (dataName == DataType.Email)
            {
                return new Bogus.DataSets.Internet(language).Email();
            }

            else if (dataName == DataType.Haslo)
            {
                return new Bogus.DataSets.Internet(language).Password().MaximumLengthOfData(size);
            }

            else if (dataName == DataType.Nick)
            {
                return new Bogus.DataSets.Internet(language).UserName().MaximumLengthOfData(size);
            }

            return string.Empty;
        }

        public IList<IDictionary<string, string>> GenerateMultipleData(GeneratorSettings generatorSettings)
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
                }

                result.Add(items);   
            }
            return result;
        }
    }
}