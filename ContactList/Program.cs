using System;

namespace ContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Contact List Application");
            Console.WriteLine();

            Contact contact = new Contact();

            String fname = getString("Enter first name: ");
            contact.setFirstName(fname);

            String lname = getString("Enter last name: ");
            contact.setLastName(lname);

            String email = getString("Enter email: ");
            contact.setEmail(email);

            String phone = getString("Enter phone: ");
            contact.setPhone(phone);
            Console.WriteLine();

            Console.Write(contact.displayContact());
            Console.WriteLine();

            Console.Write("Press any key to exit...");
            Console.ReadKey(true);

        }

        private static String getString(String prompt)
        {
            Console.Write(prompt);
            String s = Console.ReadLine();
            return s;
        }
    }

}
