using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3H4
{
 
        class ContactList : IEnumerable<Contact>
        {
            private readonly SortedDictionary<string, List<Contact>> _contacts;

            public ContactList()
            {
                _contacts = new SortedDictionary<string, List<Contact>>();
            }

            public void Add(Contact contact)
            {
                
                string key = Char.IsDigit(contact.Name[0]) ? "0-9" : contact.Name[0].ToString().ToUpperInvariant();

                
                if (!_contacts.ContainsKey(key))
                {
                    _contacts[key] = new List<Contact>();
                }

                _contacts[key].Add(contact);
            }

          
            public override string ToString()
            {
                string result = "";
                foreach (var group in _contacts)
                {
                    result += group.Key + "\n";
                    foreach (var contact in group.Value)
                    {
                        result += "\t" + contact.Name + " " + contact.Phone + "\n";
                    }
                }
                return result;
            }

            public IEnumerator<Contact> GetEnumerator()
            {
                foreach (var group in _contacts)
                {
                    foreach (var contact in group.Value)
                    {
                        yield return contact;
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }