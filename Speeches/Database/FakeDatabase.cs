using Speeches.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeches.Database
{
    static class FakeDatabase
    {
        public static List<User> DB_Users = new List<User>()
     
        {
            //Test User
            new User()
            {
                Email = "TestAccount@gmail.com",
                Username = "TestAccount",
                Password = "Password"
            },
        };
    }
}
