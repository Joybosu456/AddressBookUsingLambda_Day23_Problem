using System;

namespace NoteBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program ");
            //CreateContacts name = new CreateContacts();
            //name.PersonDetails();

            //AddNewContact obj = new AddNewContact();
            // obj.AddNewContactInBook();

            //EditDetails obj = new EditDetails();
            //obj.EditDetailsPerson();

            //EditAddressBook ed = new EditAddressBook();
            //ed.EditAddressBookJ();


            //Edit obj = new Edit();
            //obj.Display();
            //obj.DisplayTwo();

            CSVAddressBookFile cSVAddressBookFile = new CSVAddressBookFile();
            cSVAddressBookFile.IplementCsvProgram();


        }
    }
}

