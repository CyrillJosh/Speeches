using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Speeches.MVVM.Models
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        //Private Fields
        private string _FirstName { get; set; }
        private string _LastName { get; set; }
        private string _EmailAddress { get; set; }
        private string _PhoneNumber { get; set; }
        private DateTime _BirthDate { get; set; }
        private string _Gender { get; set; }

        //Public Fields
        public string FirstName
        {
            get => _FirstName;
            set
            {
                if (_FirstName != value) _FirstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get => _LastName;
            set
            {
                if (_LastName != value) _LastName = value;
                OnPropertyChanged();
            }
        }

        public string EmailAddress
        {
            get => _EmailAddress;
            set
            {
                if (_EmailAddress != value) _EmailAddress = value;
                OnPropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get => _PhoneNumber;
            set
            {
                if (_PhoneNumber != value) _PhoneNumber = value;
                OnPropertyChanged();
            }
        }
        public DateTime BirthDate
        {
            get => _BirthDate;
            set
            {
                if (_BirthDate != value) _BirthDate = value;
                OnPropertyChanged();
            }
        }
        public string Gender
        {
            get => _Gender;
            set
            {
                if (_Gender != value) _Gender = value;
                OnPropertyChanged();
            }
        }

        //Error Fields
        public string EFirstName { get; set; }
        public string ELastName { get; set; }
        public string EEmailAddress { get; set; }
        public string EPhoneNumber { get; set; }
        public string EBirthDate { get; set; }
        public string EGender { get; set; }

        //PropertyChanged method
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
       PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
