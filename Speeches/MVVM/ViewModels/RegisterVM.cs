using Speeches.Database;
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
    public class RegisterVM
    {
        //Fields
        public User User { get; set; } = new User();
        public string confirmPassword = string.Empty;
        public ICommand RegisterCommand { get; set; }

        public RegisterVM() 
        {
            RegisterCommand = new Command(() =>
            {
                //Validations
                if(CheckEmpty())
                {
                    Application.Current.MainPage.DisplayAlert("Error!", "Please fill all the fields", "Okay");
                    return;
                }
                if (!ConfirmPassword(User, confirmPassword))
                {
                    //ERROR not same
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

        private bool CheckEmpty()
        {
            //Checks if any fields is empty or null
            if(string.IsNullOrEmpty(User.Password) ||
               string.IsNullOrEmpty(User.Username) ||
               string.IsNullOrEmpty(User.Password) ||
               string.IsNullOrEmpty(confirmPassword))
                    return true;
            return false;

        }
    }
}
