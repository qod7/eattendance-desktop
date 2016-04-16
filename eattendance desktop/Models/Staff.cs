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
        public String name;

        // Device specific parameters
        public int accountNumber;  // also identifies the staff on the device
        public int password;       // only numbers allowed; max length: 8
        public int privilege;      // check Common.UserPrivilege
        public Dictionary<string, string> fingerprints = new Dictionary<string, string>();   // key => fingerindex from '0' to '9'

        // Passion specific parameters; stored individually in server
        public string cardNumber;     // office specific identification number
        public String email;
        public int? pk;             // primary key, unique for any staff in any organization
        public int? department_id;  // primary key of the dept of the staff
        public String contact;
        public String gender;
        public String address;
        public DateTime? dateOfBirth = Common.UnixTimeStampToDateTime(0);
        public String image;

        public String title;
        public String post;
        public DateTime? dateOfEmployment = Common.UnixTimeStampToDateTime(0);
        public String nationality;
        public String homeAddress;
        public String officeTel;
        public String homeTel;
        public String mobile1;
        public String mobile2;

        // Extras can store anything
        public Dictionary<string, string> extras = new Dictionary<string, string>();

        // TODO ENCAPSULTE THE FIELDS ABOVE

        // CONSTRUCTORS
        public Staff(String name, int accountNumber, int password, int privilege = 0, string cardNumber = null,
                                Dictionary<String, String> fingerprints = null, String email = null, int? pk = null,
                                int? department_id = null, String contact = null, String gender = null,
                                String address = null, DateTime? dateOfBirth = null, String image = null,
                                String title = null, String post = null, DateTime? dateOfEmployment = null,
                                String nationality = null, String homeAddress = null, String officeTel = null,
                                String homeTel = null, String mobile1 = null, String mobile2 = null,
                                Dictionary<String, String> extras = null)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.password = password;
            this.privilege = privilege;
            this.cardNumber = cardNumber;
            if (fingerprints != null)
                this.fingerprints = fingerprints;
            this.email = email;
            this.pk = pk;
            this.department_id = department_id;
            this.contact = contact;
            this.gender = gender;
            this.address = address;
            if (dateOfBirth != null)
                this.dateOfBirth = dateOfBirth;
            this.image = image;
            this.title = title;
            this.post = post;
            if (dateOfEmployment != null)
                this.dateOfEmployment = dateOfEmployment;
            this.nationality = nationality;
            this.homeAddress = homeAddress;
            this.officeTel = officeTel;
            this.homeTel = homeTel;
            this.mobile1 = mobile1;
            this.mobile2 = mobile2;
            if (extras != null)
                this.extras = extras;
        }
    }
}
