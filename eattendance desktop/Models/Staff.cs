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
        
        // Device specific parameters
        int enrollNumber;   // identifies the staff on the device
        int privilege;      // check Common.UserPrivilege
        int password;       // only numbers allowed; max length: 8
        Dictionary<int, String> fingerprints = new Dictionary<int, string>();   // int => fingerindex from 0 to 9

        // Passion specific parameters
        String unique_id;
        DateTime dob;
        String contact;
        Image image;

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
