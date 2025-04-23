using Contacts;
using Speeches.Database;
using Speeches.MVVM.Models;
using Speeches.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Speeches.MVVM.ViewModels
{
    public class RegisterVM
    {
        //Fields
        public User User { get; set; } = new User();
        public Person Person { get; set; } = new Person();
        public string confirmPassword { get; set; } = string.Empty;
        public ICommand RegisterCommand { get; set; }

        public RegisterVM() 
        {
            RegisterCommand = new Command(() =>
            {
                //Validations
                if (IsValid())
                {

                    return;
                }
                //Add the User
                FakeDatabase.DB_Users.Add(User);
                Application.Current.MainPage = new Home();
            });
        }

        //Methods
        private bool IsValid()
        {
            return true;
        }

        private bool IsEmpty(string s)
        {
            return !string.IsNullOrEmpty(s);
        }

        private bool ValidateUser()
        {
            return IsEmpty(Person.FirstName) &&
                   IsEmpty(Person.LastName) &&
                   IsEmpty(Person.EmailAddress) &&
                   IsEmpty(Person.PhoneNumber) &&
                   IsEmpty(Person.BirthDate.ToString()) &&
                   IsEmpty(Person.Gender) &&
                   IsEmpty(User.Username) &&
                   IsEmpty(User.Password) &&
                   IsEmpty(confirmPassword);
        }
    }
}
