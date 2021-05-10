using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace DanhGiaThucTap.ViewModel
{
    public class LenhDieuKienViewModel : BaseViewModel
    {
        public Command<string> ClickTranfer { get; }
        public Command ClickShowPass { get; }
        private bool _isPass;

        public bool IsPass
        {
            get { return _isPass; }
            set { SetProperty(ref _isPass, value);}
        }

        private bool _lbKhoangLai;
        public bool LbKhoangLai
        {
            get { return _lbKhoangLai; }
            set { SetProperty(ref _lbKhoangLai, value); }
        }
        private bool _lbGiaDK;
        public bool LbGiaDK
        {
            get { return _lbGiaDK; }
            set { SetProperty(ref _lbGiaDK, value); }
        }
        public List<string> ListDK { get; set; }
        private bool _giaIsVisible;

        public bool GiaIsVisible
        {
            get { return _giaIsVisible; }
            set { SetProperty(ref _giaIsVisible, value); }
        }
        private Color _backgroundBtnXacNhan;
        public Color BackgroundBtnXacNhan
        {
            get { return _backgroundBtnXacNhan; }
            set { SetProperty(ref _backgroundBtnXacNhan, value); }
        }

        private string _textBtnXacNhan;
        public string TextBtnXacNhan
        {
            get { return _textBtnXacNhan; }
            set { SetProperty(ref _textBtnXacNhan, value); }
        }
        public Command<bool> CollapsedList { get; }
        public Command<string> ClickTab { get; }
        private FontAttributes _fontFmMua;
        public FontAttributes FontFmMua
        {
            get { return _fontFmMua; }
            set { SetProperty(ref _fontFmMua, value); }
        }
        private FontAttributes _fontFmBan;
        public FontAttributes FontFmBan
        {
            get { return _fontFmBan; }
            set { SetProperty(ref _fontFmBan, value); }
        }
        private bool _isExpand;
        public bool IsExpand
        {
            get { return _isExpand; }
            set { SetProperty(ref _isExpand, value); }
        }
        public LenhDieuKienViewModel()
        {
            ClickShowPass = new Command(OnClickShowPass);
            IsPass = true;
            ListDK = new List<string>();
            ListDK.Add("Lệnh UP");
            ListDK.Add("Lệnh DOWN");
            ListDK.Add("Lệnh OCO");
            ListDK.Add("Lệnh B&B");
            CollapsedList = new Command<bool>(ClickCollapsedList);
            ClickTab = new Command<string>(OnClickTab);
            FontFmMua = FontAttributes.Bold;
            FontFmBan = FontAttributes.None;
            TextBtnXacNhan = "XÁC NHẬN MUA";
            BackgroundBtnXacNhan = Color.FromHex("#c9c9c9");
            ClickTranfer = new Command<string>(OnClickTranfer);
        }

        private void OnClickTranfer(string key)
        {
            if(key.Equals("00")|| key.Equals("10") || key.Equals("20"))
            {

                FontFmMua = FontAttributes.None;
                FontFmBan = FontAttributes.Bold;
                TextBtnXacNhan = "XÁC NHẬN BÁN";
            }
            if(key.Equals("01") || key.Equals("11") || key.Equals("21"))
            {
                FontFmMua = FontAttributes.Bold;
                FontFmBan = FontAttributes.None;
                TextBtnXacNhan = "XÁC NHẬN MUA";
            }
        }

        private void OnClickShowPass()
        {
            if (IsPass)
            {
                IsPass = false;
            }
            else
            {
                IsPass = true;
            }
        }

        private void OnClickTab(string key)
        {
            if (key.Equals("1"))
            {
                FontFmMua = FontAttributes.Bold;
                FontFmBan = FontAttributes.None;
                TextBtnXacNhan = "XÁC NHẬN MUA";
            }
            if (key.Equals("2"))
            {
                FontFmMua = FontAttributes.None;
                FontFmBan = FontAttributes.Bold;
                TextBtnXacNhan = "XÁC NHẬN BÁN";
            }

        }
        private void ClickCollapsedList(bool key)
        {
            if (key)
                IsExpand = false;
        }
        public void ItemSelect(int index)
        {
            if(index==0 || index == 1)
            {
                GiaIsVisible = false;
                LbGiaDK = false;
                LbKhoangLai = false;
            }
            else if(index == 2)
            {
                GiaIsVisible = true;
                LbKhoangLai = false;
                LbGiaDK = false;
            }else if(index == 3)
            {
                GiaIsVisible = true;
                LbKhoangLai = true;
                LbGiaDK = true;
            }
        }
    }
}
