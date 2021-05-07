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

    }
}