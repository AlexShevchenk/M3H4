using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3H4
{
 class Contact
{
    public string Name { get; set; }
    public string Phone { get; set; }

    public CultureInfo Culture { get; set; }

    public Contact(string name, string phone, CultureInfo culture)
    {
    Name = name;
    Phone = phone;
    Culture = culture;
    }
    }
}
