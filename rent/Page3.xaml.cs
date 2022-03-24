using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Grid grid = (new Grid
            {
                BackgroundColor = Color.White,
            }) ;
            ScrollView scrollView = (new ScrollView
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
            });

            //Поиск цены продуктов 
            int SummPrices = 0;
            Label[] labels = new Label[5];
            for (int i = 0; i < pbData.ListA.Spisokprice.Count; i++)
            {
                SummPrices += Convert.ToInt32(pbData.ListA.Spisokprice[i]);
            }
            labels[1] = (new Label
            {
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.FromHex("#373737")
            });
            labels[1].Text = ("" + string.Format(Convert.ToString(SummPrices)));


            Frame frameBasket = new Frame
            {
                BackgroundColor = Color.FromHex("92CEFD"),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions= LayoutOptions.CenterAndExpand,
                HasShadow = false,
                CornerRadius = 10,
                Margin = new Thickness(20),
                HeightRequest = 300,
                TranslationY = -20,
                Content = new Label { Text = "Total price: " + labels[1].Text },
            };

            //Создание стэка для вывода общей цены сверху
            StackLayout stackLayout = (new StackLayout
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                BackgroundColor = Color.FromHex("2196F3"),
                HeightRequest = 120,
                WidthRequest = 400,
                Children =
                {
                    frameBasket
                },
            });

            //Рамка для продуктов
            scrollView.Content = grid;
            //Вывод всех вьюшек 
            this.Content = new StackLayout 
            {
                BackgroundColor = Color.White,
                Children =
                {   
                    stackLayout,
                    scrollView,
                }
            };

            Frame[] frame = new Frame[pbData.ListA.count];
            Label[] labelArray = new Label[pbData.ListA.count];
            for (int i = 0; i < pbData.ListA.Spisok.Count; i++)
            {

                labelArray[i] = (new Label
                {
                    TextColor = Color.FromHex("#373737"),

                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                });
                frame[i] = (new Frame
                {
                    BackgroundColor = Color.FromHex("#92CEFD"),
                    CornerRadius = 50,
                    WidthRequest = 150,
                    HeightRequest = 5,

                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand

                });
                string searchallspisok = pbData.ListA.Spisok[i];
                string price = pbData.ListA.Spisokprice[i];
                labelArray[i].Text = String.Format("Product: {0}      " + "Price: {1}$", searchallspisok, price);
                grid.Children.Add(frame[i]);
                grid.Children.Add(labelArray[i]);
                Grid.SetRow(labelArray[i], i);
                Grid.SetRow(frame[i], i);
            } // Вывод продуктов
        }
    }
}