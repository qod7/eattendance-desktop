using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eattendance_desktop.Models
{
    class Staff
    {
        // General paramenters
        String name;
        String email;
        
        // Device specific parameters
        int accountNumber;  // also identifies the staff on the device
        int password;       // only numbers allowed; max length: 8
        int privilege;      // check Common.UserPrivilege
        int cardNumber;     // the rfid card number
        Dictionary<int, String> fingerprints = new Dictionary<int, string>();   // int => fingerindex from 0 to 9

        // Passion specific parameters; stored individually in server
        int pk;             // primary key, unique for any staff in any organization
        int department_pk;  // primary key of the dept of the staff
        String contact;
        String gender;
        String address;
        DateTime dateOfBirth;
        Image image;

        String title;
        String post;
        DateTime dateOfEmployment;
        String nationality;
        String homeAddress;
        String officeTel;
        String homeTel;
        String mobile1;
        String mobile2;

        // Extras can store anything
        Dictionary<String, String> extras = new Dictionary<string, string>();

        // TODO ENCAPSULTE THE FIELDS ABOVE
        //public string name
        //{   get { return _name; }
        //    set { _name = value; }
        //}
        //public int enrollNumber
        //{
        //    get { return _enrollNumber; }
        //    set { _enrollNumber = value; }
        //}
        //public int privilege
        //{
        //    get { return _privilege; }
        //    set { _privilege = value; }
        //}
        //public int password
        //{
        //    get { return _password; }
        //    set { _password = value; }
        //}

    }
}
