using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace Data_Generator.Services.DataGenerator
{
    public class DataType
    {
        private void DataSets(string setLanguage)
        {
            //language need to have "" so for example "pl"
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

    }
}
