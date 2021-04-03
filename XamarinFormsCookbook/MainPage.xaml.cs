using Xamarin.Forms;
using XamarinFormsCookbook.Views.DatePickerMaximumDateCurrentDate;

namespace XamarinFormsCookbook
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DatePickerMaximumDateCurrentDateView());
        }
    }
}
