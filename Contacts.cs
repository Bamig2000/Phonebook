using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Contacts
    {
        private string name, middlename, lastname, address, gender,path;
        private long phone;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public string MiddleName
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;

            }
        }
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }


        }
        public long Phone
        {
            get
            {
                return phone;

            }
            set
            {
                phone = value;

            }
        }
        public string Address
        {
            get
            {
                return address;

            }
            set
            {
                address = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;

            }
        }
        public string Path 
        {
            get { return path; }
            set { path = value; }
        }
        public Contacts(string name, string middlename, string lastname,long phone, string address, string gender,string path )
        {
            this.name = Name;
            this.middlename = MiddleName;
            this.lastname = LastName;
            this.phone = Phone;
            this.address = Address;
            this.gender = Gender;
            this.path = Path;
          }
       
        public Contacts(string name, string middlename, string lastname, long phone, string address, string gender)
        {
            this.name = Name;
            this.middlename = MiddleName;
            this.lastname = LastName;
            this.phone = Phone;
            this.address = Address;
            this.gender = Gender;
         
        }

    }

}


