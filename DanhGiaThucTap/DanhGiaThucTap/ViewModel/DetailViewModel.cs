using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DanhGiaThucTap.ViewModel
{
    class DetailViewModel : BaseViewModel
    {
        private bool _listLenhIsVisible;
        public bool ListLenhIsVisible
        {
            get { return _listLenhIsVisible; }
            set { SetProperty(ref _listLenhIsVisible, value); }
        }
        public Command ShowListLenh { get; }
        public List<string> ListLenh { get; set; }
        public DetailViewModel()
        {
            ListLenh = new List<string>();
            ListLenh.Add("VN30F2106");
            ListLenh.Add("VN30F2105");
            ListLenh.Add("VN30F2112");
            ListLenh.Add("VN30F2109");
            ListLenh.Add("GB05F2106");
            ListLenh.Add("GB05F2109");
            ListLenh.Add("GB10F2109");
            ListLenh.Add("GB10F2106");
            ShowListLenh = new Command(ClickShowListLenh);
            ListLenhIsVisible = false;
        }

        private void ClickShowListLenh()
            {
            if (!ListLenhIsVisible)
            {
                ListLenhIsVisible = true;
            }
            else
            {
                ListLenhIsVisible = false;
            }
            
        }
    }
}
