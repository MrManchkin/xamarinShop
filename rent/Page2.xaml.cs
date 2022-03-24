using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public List<string> backetProducts = new List<string>();

        public Page2()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            DisplayAlert("Add to backet", product1.Text, "ok");
            pbData.ListA.count++;
            amount.Text = pbData.ListA.count.ToString();
            backetProducts.Add(product1.Text);
            pbData.ListA.Spisok.Add(product1.Text);
            pbData.ListA.Spisokprice.Add(price1.Text);
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            DisplayAlert("Add to backet", product2.Text, "ok");
            pbData.ListA.count++;
            amount.Text = pbData.ListA.count.ToString();
            backetProducts.Add(product1.Text);
            pbData.ListA.Spisok.Add(product2.Text);
            pbData.ListA.Spisokprice.Add(price2.Text);
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            DisplayAlert("Add to backet", product3.Text, "ok");
            pbData.ListA.count++;
            amount.Text = pbData.ListA.count.ToString();
            backetProducts.Add(product1.Text);
            pbData.ListA.Spisok.Add(product3.Text);
            pbData.ListA.Spisokprice.Add(price3.Text);
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            DisplayAlert("Add to backet", product4.Text, "ok");
            pbData.ListA.count++;
            amount.Text = pbData.ListA.count.ToString();
            backetProducts.Add(product1.Text);
            pbData.ListA.Spisok.Add(product4.Text);
            pbData.ListA.Spisokprice.Add(price4.Text);
        }
    }
}