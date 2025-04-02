using Speeches.MVVM.Models;
using Speeches.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Speeches.MVVM.ViewModels
{
    public class LoginVM
    {
        //Fields
        public User User { get; set; } = new User();

        //Commands
        public ICommand LoginCommand { get; set; }


        //Constructors
        public LoginVM()
        {
            //Custom User
            Database.FakeDatabase.DB_Users.Add(new User()
            {
                Email = "capua@gmail.com",
                Username = "CharlesBIOT",
                Password = "123123"
            });

            //Login
            LoginCommand = new Command(() =>
            {
                
                //Validation
                if(string.IsNullOrEmpty(User.Username) || string.IsNullOrEmpty(User.Password))
                {
                    //Code here
                    return;
                }

                //Get list to compare
                var lstuser = Database.FakeDatabase.DB_Users;
                //Get User
                var user = lstuser.FirstOrDefault(x => x.Username == User.Username && x.Password == User.Password);
                if (user is not null)
                {
                    Application.Current.MainPage = new Home();
                    return;
                }

                //Error User not found!
                //Code to be added
            });
        }
    }
}
