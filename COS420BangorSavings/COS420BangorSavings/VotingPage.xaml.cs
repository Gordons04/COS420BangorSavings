using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COS420BangorSavings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VotingPage : ContentPage
    {
        public VotingPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            charity1_button2.IsEnabled = false;
            charity1_button3.IsEnabled = false;
            charity1_button4.IsEnabled = false;
            charity1_button5.IsEnabled = false;

        }

        private void charity1_button2_Clicked(object sender, EventArgs e)
        {
            charity1_button1.IsEnabled = false;
            charity1_button3.IsEnabled = false;
            charity1_button4.IsEnabled = false;
            charity1_button5.IsEnabled = false;
        }

        private void charity1_button2_Clicked_1(object sender, EventArgs e)
        {
            charity1_button2.IsEnabled = false;
            charity1_button1.IsEnabled = false;
            charity1_button4.IsEnabled = false;
            charity1_button5.IsEnabled = false;
        }

        private void charity1_button2_Clicked_2(object sender, EventArgs e)
        {
            charity1_button2.IsEnabled = false;
            charity1_button3.IsEnabled = false;
            charity1_button1.IsEnabled = false;
            charity1_button5.IsEnabled = false;
        }

        private void charity1_button2_Clicked_3(object sender, EventArgs e)
        {
            charity1_button2.IsEnabled = false;
            charity1_button3.IsEnabled = false;
            charity1_button4.IsEnabled = false;
            charity1_button1.IsEnabled = false;
        }
    }
}
