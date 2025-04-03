using Speeches.Database;
using Speeches.MVVM.Models;

namespace Speeches.MVVM.Views;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();

		//Checking only
		User user = FakeDatabase.DB_Users.Last();
		BindingContext = user;
	}

	//Testing puropose
	private void Test(object sender, EventArgs e)
	{
		Application.Current.MainPage = new Login();
	}
}