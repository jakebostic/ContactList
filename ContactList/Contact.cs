using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList
{
    class Contact
    {
        private String fname;
        private String lname;
        private String email;
        private String phone;

        public Contact()
        {

        }

        public Contact(String fname, String lname, String email, String phone)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.phone = phone;
        }

        public void setFirstName(String fname)
        {
            this.fname = fname;
        }
        public String getFirstName()
        {
            return fname;
        }

        public void setLastName(String lname)
        {
            this.lname = lname;
        }
        public String getLastName()
        {
            return lname;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getEmail()
        {
            return email;
        }

        public void setPhone(String phone)
        {
            this.phone = phone;
        }
        public String getPhone()
        {
            return phone;
        }

        public String displayContact()
        {
            string contact = "--------------------------------------------\n";
            contact += "---- Current Contact -----------------------\n";
            contact += "--------------------------------------------\n";
            contact += "Name:          " + fname + " " + lname + "\n";
            contact += "Email Address: " + email + "\n";
            contact += "Phone Number:  " + phone + "\n";
            contact += "--------------------------------------------\n";
            return contact;
        }
    }
}
