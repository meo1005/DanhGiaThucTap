using DanhGiaThucTap.Custom;
using DanhGiaThucTap.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DanhGiaThucTap.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LenhDieuKienPage : ContentPage
    {       
        public LenhDieuKienViewModel viewModel
        {
            get { return BindingContext as LenhDieuKienViewModel; }
            set { BindingContext = value; }
        }
        public LenhDieuKienPage()
        {
            InitializeComponent();
            viewModel = new LenhDieuKienViewModel();
            BindingContext = new LenhDieuKienViewModel();           
            dropdown.SelectedIndex = 0;
            dropdown.ItemSelected += OnDropdownSelected;
        }
        private void OnDropdownSelected(object sender, ItemSelectedEventArgs e)
        {
            viewModel.ItemSelect(e.SelectedIndex);
        }

        private async void Tap00(object sender, EventArgs e)
        {
            flicker(sender, e);
            Color color = Color.Gray;
            Color actuacolor = TabBan.BackgroundColor;
            await TabBan.ChangeBackgroundColorTo(color, 150, Easing.CubicOut);
            await TabBan.ChangeBackgroundColorTo(actuacolor, 150, Easing.CubicOut);

        }
        private async void Tap01(object sender, EventArgs e)
        {
            flicker(sender, e);
            Color color = Color.Gray;
            Color actuacolor = TabMua.BackgroundColor;
            await TabMua.ChangeBackgroundColorTo(color, 150, Easing.CubicOut);
            await TabMua.ChangeBackgroundColorTo(actuacolor, 150, Easing.CubicOut);
        }

        private async void Tap10(object sender, EventArgs e)
        {
            flicker(sender, e);
            Color color = Color.Gray;
            Color actuacolor = TabBan.BackgroundColor;
            await TabBan.ChangeBackgroundColorTo(color, 150, Easing.CubicOut);
            await TabBan.ChangeBackgroundColorTo(actuacolor, 150, Easing.CubicOut);
        }

        private async void Tap11(object sender, EventArgs e)
        {
            flicker(sender, e);
            Color color = Color.Gray;
            Color actuacolor = TabMua.BackgroundColor;
            await TabMua.ChangeBackgroundColorTo(color, 150, Easing.CubicOut);
            await TabMua.ChangeBackgroundColorTo(actuacolor, 150, Easing.CubicOut);
        }

        private async void Tap20(object sender, EventArgs e)
        {
            flicker(sender,e);
            Color color = Color.Gray;
            Color actuacolor = TabBan.BackgroundColor;
            await TabBan.ChangeBackgroundColorTo(color, 150, Easing.CubicOut);
            await TabBan.ChangeBackgroundColorTo(actuacolor, 150, Easing.CubicOut);
        }

        private async void Tap21(object sender, EventArgs e)
        {
            flicker(sender, e);
            Color color = Color.Gray;
            Color actuacolor = TabMua.BackgroundColor;
            await TabMua.ChangeBackgroundColorTo(color, 150, Easing.CubicOut);
            await TabMua.ChangeBackgroundColorTo(actuacolor, 150, Easing.CubicOut);
        }
        private async void flicker (object sender, EventArgs e)
        {
            var x = sender as StackLayout;
            Color color = Color.Gray;
            Color actuacolor = x.BackgroundColor;
            await x.ChangeBackgroundColorTo(color, 150, Easing.CubicOut);
            await x.ChangeBackgroundColorTo(actuacolor, 150, Easing.CubicOut);
        }
    }
}