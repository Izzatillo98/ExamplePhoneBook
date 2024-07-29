using PhoneBookWithFile.Models;
using System.Collections.Generic;

namespace PhoneBookWithFile.Services;

internal interface IFileService
{
    Contact AddContact(Contact contact);
    bool DeleteContact(string phoneNumber);
    List<Contact> ReadAllContacts();
}