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
        public static string setLanguage = "pl";
        //language need to have "" so for example "pl"

        public void GenerateData(GeneratorSettings generatorSettings)
        {
            string setLanguage = generatorSettings.Language;

            string firstName = new Bogus.DataSets.Name(setLanguage).FirstName();
            string lastName = new Bogus.DataSets.Name(setLanguage).LastName();
            string city = new Bogus.DataSets.Address(setLanguage).City();
            string phoneNumber = new Bogus.DataSets.PhoneNumbers(setLanguage).PhoneNumber();
            string zipCode = new Bogus.DataSets.Address(setLanguage).ZipCode();
            string creditCard = new Bogus.DataSets.Finance().CreditCardNumber();
            string date = new Bogus.DataSets.Date(setLanguage).Recent().ToString();
            string email = new Bogus.DataSets.Internet(setLanguage).Email();
            string password = new Bogus.DataSets.Internet(setLanguage).Password();
            string username = new Bogus.DataSets.Internet(setLanguage).UserName();
        }

        public IDictionary<string, string> GenerateSingleData(GeneratorSettings generatorSettings)
        {
            var result = new Dictionary<string, string>();
            string setLanguage = generatorSettings.Language;
            foreach (var item in generatorSettings.DataSets)
            {
                var tempvalue = GenerateByDataType(item.Value, setLanguage);
                result.Add(item.Key, tempvalue);
            }
            
/*            string firstName = new Bogus.DataSets.Name(setLanguage).FirstName();
            string lastName = new Bogus.DataSets.Name(setLanguage).LastName().ClampLength(generatorSettings.Size, generatorSettings.Size);
            
            result.Add("firstName", firstName);
            result.Add("lastName", lastName);*/
            return result;
        }

        public string GenerateByDataType(DataType dataName, string language)
        {
            switch (dataName)
            {
                case DataType.FirstName:
                    return new Bogus.DataSets.Name(language).FirstName();
                case DataType.LastName:
                    return new Bogus.DataSets.Name(language).LastName();
                case DataType.City:
                    return new Bogus.DataSets.Address(language).City();
                case DataType.PhoneNumber:
                    return new Bogus.DataSets.PhoneNumbers(language).PhoneNumber();
                case DataType.ZipCode:
                    return new Bogus.DataSets.Address(language).ZipCode();
                case DataType.CreditCard:
                    return new Bogus.DataSets.Finance().CreditCardNumber();
                case DataType.Date:
                    return new Bogus.DataSets.Date(language).Recent().ToString();
                case DataType.Email:
                    return new Bogus.DataSets.Internet(language).Email();
                case DataType.Password:
                    return new Bogus.DataSets.Internet(language).Password();
                case DataType.Username:
                    return new Bogus.DataSets.Internet(language).UserName();

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
    }
}