using Speeches.MVVM.Models;
using Speeches.MVVM.ViewModels;

namespace Speeches.MVVM.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
        //Binding
        BindingContext = new LoginVM();
	}

    //Go to Register
    private void Register_Tapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new Register();
    }
}