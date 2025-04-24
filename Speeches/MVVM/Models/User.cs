using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Speeches.MVVM.Models
{
    public class User : Person
    {
        //Public Fields
        public string Id { get; }
        public string Username { get; set; }
        public string Password { get; set; }

        //Error Fields
        public string EId { get; set; }
        public string EUsername { get; set; }
        public string EPassword { get; set; }

        //Constructor
        public User()
        {
            //Generate new Id
            _Id = Guid.NewGuid().ToString();
        }
    }
}
