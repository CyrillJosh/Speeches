using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Speeches.MVVM.Models
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        //Private Fields
        private string _Id { get; set; }
        private string _Username { get; set; }
        private string _Password { get; set; }

        //Public Fields
        public string Id
        {
            get => _Id;
        }
        public string Username
        {
            get => _Username;
            set
            {
                if (_Username != value) _Username = value;
                IsEmpty(value, EUsername);
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => _Password;
            set
            {
                if (_Password != value) _Password = value;
                IsEmpty(value, EPassword);
                OnPropertyChanged();
            }
        }

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

        //PropertyChanged method
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
       PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        //Method
        private void IsEmpty(string v, string e)
        {
            if (string.IsNullOrEmpty(v))
                e = $"Please enter your {nameof(v)}";
            else
                e = "";
        }
    }
}
