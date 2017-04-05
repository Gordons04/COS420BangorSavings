using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace COS420BangorSavings.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeaderboardPage : ContentPage
    {
        public LeaderboardPage() { 

            InitializeComponent();
            DrawerLayout.InitializeDrawerLayout(); //Intialize drawer  
            string[] menuItems = new string[5] { "Favorite 1", "Faverote 2", "Favorite 3", "Favorite 4", "Favorite 5" };
            ListMenuItems.ItemsSource = menuItems.ToList();  //Set Menu list  
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private void DrawerIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (DrawerLayout.IsDrawerOpen)
                DrawerLayout.CloseDrawer();//Close drawer  
            else
                DrawerLayout.OpenDrawer();//Open drawer  
        }

        private void ListMenuItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListMenuItems.SelectedItem != null)
            {
                //Get selected favorites item value  
                var selecteditem = ListMenuItems.SelectedValue as string;
                DetailsTxtBlck.Text = "SelectedItem is: " + selecteditem;
                DrawerLayout.CloseDrawer();
                ListMenuItems.SelectedItem = null;
            }
        }

        protected void OnNavigatedTo(NavigationEventArgs e)
        {
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        void HardwareButtons_BackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            if (DrawerLayout.IsDrawerOpen)
            {
                DrawerLayout.CloseDrawer();//Close drawer on back press  
                e.Handled = true;
            }
            else
            {
                Application.Current.Exit();//exist app when drawer close on back press  
            }
        }
    }
}
