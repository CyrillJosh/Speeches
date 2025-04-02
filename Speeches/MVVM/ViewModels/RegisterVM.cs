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
                if(ConfirmPassword(User, confirmPassword))
                {
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
            if(User.Password == cp)
                return true;
            return false;
        }
    }
}
