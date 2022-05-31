// See https://aka.ms/new-console-template for more information
using RFPDay10;

Console.WriteLine("Hello, World!");



MultipleAddressBook obj = new MultipleAddressBook();
obj.DictionaryContacts();

AddMultipleContact addressBook = new AddMultipleContact();

addressBook.AddMultipleContact1();

addressBook.AddNewContact();
addressBook.AddNewContact();

AddMultipleContact.PrintAddressBook();
Console.WriteLine("Enter the FirstName to Edit");
string firstName = Console.ReadLine();
addressBook.EditContact(firstName);
AddMultipleContact.PrintAddressBook();

AddMultipleContact.PrintAddressBook();
Console.WriteLine("Enter the FirstName to Delete");
string firstName1 = Console.ReadLine();
addressBook.DeleteContact(firstName1);
AddMultipleContact.PrintAddressBook();
Console.ReadLine();


