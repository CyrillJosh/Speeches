using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Speeches.MVVM.Models
{
    public class Person
    {
        //Public Fields
        public string Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

        //Error Fields
        public string EFirstName { get; set; }
        public string ELastName { get; set; }
        public string EEmailAddress { get; set; }
        public string EPhoneNumber { get; set; }
        public string EBirthDate { get; set; }
        public string EGender { get; set; }
    }
}
