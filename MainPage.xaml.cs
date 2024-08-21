using System;

namespace Module01Exercise01
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

       private void display_value_clicked(object sender, EventArgs e)
        {
            string entry1 = "Name: " + valuen.Text;
            string entry2 = "Email: " + valuee.Text;
            string entry4 = "Bio: " + valuen.Text;

            string message = $"{entry1}\n{entry2}\n{entry4}";

            DisplayAlert("Success!!! These are your information", message, "Ok");
        }

        private void OnChangedBackgroundColorYellow(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.LightYellow;
        }
        private void OnChangedBackgroundColorPurple(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Purple;
        }
        private void OnChangedBackgroundColorRed(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.IndianRed;
        }
    }

}
