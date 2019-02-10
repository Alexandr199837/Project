using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prilojenie
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            ToolbarItem tb = new ToolbarItem
            {
                Text = "Позвонить",
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
                Icon = new FileImageSource
                {
                    File = "w512h5121380376664MetroUIPhone.png"
                }
            };
            tb.Clicked += async (s, e) =>
            {
                await DisplayAlert("Вызов", "Идет набор номера...", "Сбросить");
            };
            ToolbarItem tb1 = new ToolbarItem
            {
                Text = "Создать новый контакт",
                Order = ToolbarItemOrder.Secondary,
                Priority = 1,
            };
            ToolbarItem tb2 = new ToolbarItem
            {
                Text = "Удалить",
                Order = ToolbarItemOrder.Secondary,
                Priority = 2,
            };
            ToolbarItem tb3 = new ToolbarItem
            {
                Text = "О программе",
                Order = ToolbarItemOrder.Secondary,
                Priority = 3,
            };



            ToolbarItems.Add(tb);
            ToolbarItems.Add(tb1);
            ToolbarItems.Add(tb2);
            ToolbarItems.Add(tb3);
        }
        private async void Button1_Click(object sender, EventArgs e)
        {
          bool result =  await DisplayAlert("Выбор действия", "Перекрасить фон?", "Да", "Нет");
            if (result)
                StackLayout1.BackgroundColor = Color.FromHex("FFB300");
            else
                await DisplayAlert("", "действие отменено", "OK");
        }
	}
}
