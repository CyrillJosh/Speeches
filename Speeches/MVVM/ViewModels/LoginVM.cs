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
            //Login
            LoginCommand = new Command(() =>
            {
                
                //Validation
                if(string.IsNullOrEmpty(User.Username) || string.IsNullOrEmpty(User.Password))
                {
                    //Code here
                    Application.Current.MainPage.DisplayAlert("Error!", "Please Fill all the Fields", "Okay");
                    return;
                }

                //Get list to compare
                var lstuser = Database.FakeDatabase.DB_Users;
                //Get User
                var user = lstuser.FirstOrDefault(x => x.Username == User.Username && x.Password == User.Password);
                //Error User not found!
                if (user is null)
                {
                    Application.Current.MainPage.DisplayAlert("Error", "Username or Password might be wrong", "Okay");
                    return;
                }

                //Go to HomePage
                Application.Current.MainPage = new Home();
            });
        }
    }
}
