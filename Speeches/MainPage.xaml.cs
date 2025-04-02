using Speeches.MVVM.Views;

namespace Speeches
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Animation ends 
        private async void OnAnimationCompleted(object? sender, EventArgs e)
        {
            await Task.Delay(500);
            //Next page
            Application.Current.MainPage = new Login();
            //await Navigation.PushAsync(new Login());
            //Navigation.RemovePage(this);
        }

    }

}
