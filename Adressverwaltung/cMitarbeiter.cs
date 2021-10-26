using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressverwaltung {
    class cMitarbeiter {
        int idNumber;
        string firstName;
        string lastname;
        DateTime birthDate;
        string position;

        List<cMaAdress> adresses;
        List<cMaPhone> phonenumbers;


        // Constructor
        public cMitarbeiter(int idNumber, string firstName, string lastname, DateTime birthDate, string position) {
            this.idNumber = idNumber;
            this.firstName = firstName;
            this.lastname = lastname;
            this.birthDate = birthDate;
            this.position = position;
            phonenumbers = new List<cMaPhone>();
            adresses = new List<cMaAdress>();
        }

        // Setter & Getter
        public int IdNumber { get => idNumber;}
        public string FirstName { get => firstName; set => firstName = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Position { get => position; set => position = value; }



        public void addAdress(cMaAdress adress) {
            adresses.Add(adress);
        }
        public void addPhone(cMaPhone phone) {
            phonenumbers.Add(phone);
        }
    }




    class cMaPhone{
        string phone;
        string mobile;

        // Constructor
        public cMaPhone(string phone = null, string mobile = null) {
            this.phone = phone;
            this.mobile = mobile;
        }

        // Setter & Getter
        public string Phone { get => phone; set => phone = value; }
        public string Mobile { get => mobile; set => mobile = value; }
    }




    class cMaAdress{
        string street;
        string houseNo;
        string zipcode;
        string city;

        // Constructor
        public cMaAdress(string street, string houseNo, string zipcode, string city) {
            this.street = street;
            this.houseNo = houseNo;
            this.zipcode = zipcode;
            this.city = city;
        }

        // Setter & Getter
        public string Street { get => street; set => street = value; }
        public string HouseNo { get => houseNo; set => houseNo = value; }
        public string Zipcode { get => zipcode; set => zipcode = value; }
        public string City { get => city; set => city = value; }
    }
}
