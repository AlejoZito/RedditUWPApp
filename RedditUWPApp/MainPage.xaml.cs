using RedditUWPApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RedditUWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MainPageViewModel ViewModel;

        public MainPage()
        {
            ViewModel = new MainPageViewModel();
            
            //ToDo: handle no items in list
            ViewModel.SelectPost(ViewModel.RedditPosts.FirstOrDefault());

            this.InitializeComponent();            
        }

        private void PostsLists_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ViewModel.SelectPost((RedditPostViewModel)e.ClickedItem);
            }
            catch (Exception ex)
            {
                
            }
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            await ViewModel.GetData();
        }

        private async void ListItem_DismissButton_Click(object sender, RoutedEventArgs e)
        {            
            await ViewModel.Dismiss((RedditPostViewModel)((Button)e.OriginalSource).DataContext);
        }
    }
}
