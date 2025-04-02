using Speeches.MVVM.ViewModels;

namespace Speeches.MVVM.Views;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
        //Binding
        BindingContext = new RegisterVM();
	}

    //Go to Login
    private void Login(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new Login();
    }
}