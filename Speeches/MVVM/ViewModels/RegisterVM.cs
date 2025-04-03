using Speeches.Database;
using Speeches.MVVM.Models;
using Speeches.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Speeches.MVVM.ViewModels
{
    public class RegisterVM
    {
        //Fields
        public User User { get; set; } = new User();
        public string confirmPassword { get; set; } = string.Empty;
        public ICommand RegisterCommand { get; set; }

        public RegisterVM() 
        {
            RegisterCommand = new Command(() =>
            {
                //Validations
                if(CheckEmpty(User))
                {
                    Application.Current.MainPage.DisplayAlert("Error!", "Please fill all the fields", "Okay");
                    return;
                }
                if(!CheckValidEmail(User))
                {
                    Application.Current.MainPage.DisplayAlert("Error!","Email address is not in a correct format", "Okay");
                    return;
                }
                if (!ConfirmPassword(User, confirmPassword))
                {
                    Application.Current.MainPage.DisplayAlert("Error!","Password Does not Match", "Okay");
                    return;
                }
                //Add the User
                FakeDatabase.DB_Users.Add(User);
                Application.Current.MainPage = new Home();
            });
        }

        //Methods
        private bool ConfirmPassword(User user, string cp)
        {
            //Checks if password and confirm password is the same
            if(User.Password == cp)
                return true;
            return false;
        }

        private bool CheckEmpty(User user)
        {
            //Checks if any fields is empty or null
           if(string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
                    return true;
            return false;

        }

        private bool CheckValidEmail(User user)
        {
            //Invalid email address
            if(!(user.Email.Contains('@') && user.Email.Contains('.')))
                return false;
            //Check for valid email address
            if(user.Email.IndexOf('@') < user.Email.LastIndexOf('.'))
                return false;
            //split email for checking
            var SplitEmail = User.Email.Split(['@','.']);

            //Check each split
            foreach( var i in SplitEmail)
            {
                //Check if any is null or empty
                if (string.IsNullOrEmpty(i))  
                    return false;
            }

            //Email is accepted
            return true;
        }
    }
}
