using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleWebview
{
    public partial class MainPage : ContentPage
    {
        //Label LoadingLabel;
        ActivityIndicator activity_indicator;
        public MainPage()
        {
            InitializeComponent();
            //string URL = "https://www.google.co.in";
            //Browser.Source = URL;
            #region working code
            Label header = new Label
            {
                Text = "WebView",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };
           //LoadingLabel = new Label
           // {
           //     Text = "Loading",
           //     FontSize = 50,
           //     FontAttributes = FontAttributes.Bold,
           //     HorizontalOptions = LayoutOptions.Center
           // };


            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://github.com/",
                },
                VerticalOptions = LayoutOptions.FillAndExpand,

                BackgroundColor = Color.Blue,
                WidthRequest = 1000,
                HeightRequest = 1000,
                
                
            };

            webView.Navigating += OnNavigating;
            webView.Navigated += OnNavigated;

            #endregion
            ActivityIndicator activity_indicator = new ActivityIndicator()
            {
                IsVisible = false,
                IsRunning = false
            };
            #region working code
            this.Content = new StackLayout
            {
                Children =
                        {

                            header,
                           activity_indicator,
                             webView,


                        },
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.Red
            };
            #endregion

            //    //InitializeComponent();

            //}

            //protected async override void OnAppearing()
            //{
            //    base.OnAppearing();
            //    await activity_indicator.ProgressTo(0.9, 900, Easing.SpringIn);

        }

        public async void OnNavigating(object sender, WebNavigatingEventArgs e)
        {

            await DisplayAlert("Alert", "Loading", "OK");

        }

        public  void OnNavigated(object sender, WebNavigatedEventArgs e)
        {

            //await DisplayAlert("Alert", "LOaded", "OK");
           activity_indicator.IsVisible = false;


        }
        //private void BtnWebView_Clicked(object sender, EventArgs e)
        //{
        //    WebView webView = new WebView
        //    {
        //        Source = new UrlWebViewSource
        //        {
        //            Url = "https://blog.xamarin.com/",
        //        },

        //    };

    }

}

