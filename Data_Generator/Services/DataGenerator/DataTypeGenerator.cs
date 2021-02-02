using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Data_Generator;
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

        public IDictionary<string, string> GenerateData2(GeneratorSettings generatorSettings)
        {
            string setLanguage = generatorSettings.Language;

            string firstName = new Bogus.DataSets.Name(setLanguage).FirstName();
            string lastName = new Bogus.DataSets.Name(setLanguage).LastName();
            var result = new Dictionary<string, string>();
            result.Add("firstName", firstName);
            result.Add("lastName", lastName);
            return result;
        }

        public IList<IDictionary<string, string>> GenerateData3(GeneratorSettings generatorSettings)
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
