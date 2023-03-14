using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace M3H4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactList contacts = new ContactList();
            contacts.Add(new Contact("John Smith", "1234567890", CultureInfo.GetCultureInfo("en-US")));
            contacts.Add(new Contact("Іван Петров", "0987654321", CultureInfo.GetCultureInfo("uk-UA")));
            contacts.Add(new Contact("Анна Коваль", "5551234", CultureInfo.GetCultureInfo("uk-UA")));
            contacts.Add(new Contact("Вікторія Петренко", "2223334444", CultureInfo.GetCultureInfo("uk-UA")));
            Console.WriteLine(contacts);
        }
    }
}
