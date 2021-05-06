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
        List<string> Items1 = new List<string>();
        List<string> Items2 = new List<string>();
        bool IsItem1 = true;
        public LenhDieuKienPage()
        {
            InitializeComponent();
            BindingContext = new LenhDieuKienViewModel();
            Items1.Add("Lệnh UP");
            Items1.Add("Lệnh DOWN");
            Items1.Add("Lệnh OCO");
            Items1.Add("Lệnh B&B");
            dropdown.ItemsSource = Items1;
            dropdown.SelectedIndex = 1;
            dropdown.ItemSelected += OnDropdownSelected;
        }
        private void OnDropdownSelected(object sender, ItemSelectedEventArgs e)
        {
           // label.Text = IsItem1 ? Items1[e.SelectedIndex] : Items2[e.SelectedIndex];
        }

    }
}