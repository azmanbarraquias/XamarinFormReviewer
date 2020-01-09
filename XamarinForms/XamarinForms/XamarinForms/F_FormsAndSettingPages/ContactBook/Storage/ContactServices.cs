using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using XamarinForms.F_FormsAndSettingPages.ContactBook.Models;

namespace XamarinForms.F_FormsAndSettingPages.ContactBook.Storage
{
    public class ContactServices
    {
        private  readonly ObservableCollection<Contact> _contact = new ObservableCollection<Contact>()
        {
            new Contact { FirstName = "Azman", LastName = "Barraquias", Phone = "09669881766", Email = "Azmanbarraquias@gmail.com" },
            new Contact { FirstName = "Grace", LastName = "Barraquias", Phone = "09456465464", Email = "LuckyGrace123@gmail.com" },
            new Contact { FirstName = "Caroline", LastName = "Candilario", Phone = "0946546146", Email = "Caroll123@gmail.com", Blocked=true}
        };

        public IEnumerable<Contact> GetList(string name=null)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return _contact.Where(c => c.FullName.StartsWith(name, StringComparison.CurrentCultureIgnoreCase));

            }
            return _contact;
        }

        public void RemoveContact(Contact contact)
        {
            _contact.Remove(contact);
        }

        public void AddNewContact(Contact contact)
        {
            _contact.Add(contact);
        }
    }
}
