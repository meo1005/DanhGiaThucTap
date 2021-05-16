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
    public partial class LenhDieuKhienPage : ContentPage
    {
        public LenhDieuKhienViewModel viewModel
        {
            get { return BindingContext as LenhDieuKhienViewModel; }
            set { BindingContext = value; }
        }
        public LenhDieuKhienPage()
        {
            InitializeComponent();
            viewModel = new LenhDieuKhienViewModel();
            dropdown.SelectedIndex = 0;
            dropdown.ItemSelected += OnDropdownSelected;
        }
        private void OnDropdownSelected(object sender, ItemSelectedEventArgs e)
        {
            viewModel.ItemSelect(e.SelectedIndex);
        }
        //hiệu ứng nháy
        private void TapSideMua(object sender, EventArgs e)
        {
            flicker(sender);
            Giaflicker(FrameGia);
            Giaflicker(TabBan);
        }
        private void TapSideBan(object sender, EventArgs e)
        {
            flicker(sender);
            Giaflicker(FrameGia);
            Giaflicker(TabMua);                  
        }
        private void TapGia(object sender, EventArgs e)
        {
            flicker(sender);
            Giaflicker(FrameGia);           
        }
        private void TapKLMax(object sender, EventArgs e)
        {
            flicker(sender);
            Giaflicker(StackKLMax);
        }
        private async void flicker(object sender)
        {            
            var x = sender as StackLayout;
            Color color = Color.FromHex("#c9c9c9");
            Color actuacolor = x.BackgroundColor;
            await x.ChangeBackgroundColorTo(color,100, Easing.CubicOut);
            await x.ChangeBackgroundColorTo(actuacolor,100, Easing.CubicOut);
        }
        private async void Giaflicker(StackLayout stackLayout)
        {           
            Color color = Color.FromHex("#c9c9c9");
            Color actuacolor = stackLayout.BackgroundColor;
            await stackLayout.ChangeBackgroundColorTo(color, 100, Easing.CubicOut);
            await stackLayout.ChangeBackgroundColorTo(actuacolor, 100, Easing.CubicOut);
        }
    }
}