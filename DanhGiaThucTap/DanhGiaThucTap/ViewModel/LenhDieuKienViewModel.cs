using DanhGiaThucTap.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;
namespace DanhGiaThucTap.ViewModel
{
    public class LenhDieuKienViewModel : BaseViewModel
    {
        public Command<string> ClickTranfer { get; }
        public Command ClickShowPass { get; }
        public Command ClickListOnNavigation { get; }
        public Command<ItemListNavi> ClickItemOnNavigationList { get; }
        public Command<bool> CollapsedList { get; }
        public Command<string> ClickTab { get; }
        public Command<string> ClickSelectTab { get; }
        public Command<string> BtnPlus { get; }
        public Command<string> BtnMinus { get; }

        private string _itemListNavigation;
        public string ItemListNavigation
        {
            get { return _itemListNavigation; }
            set { SetProperty(ref _itemListNavigation, value); }
        }

        private bool _listOnNavigationIsVisible;
        public bool ListOnNavigationIsVisible
        {
            get { return _listOnNavigationIsVisible; }
            set { SetProperty(ref _listOnNavigationIsVisible, value); }
        }

        private List<ItemListNavi> _listOnNavigation;
        public List<ItemListNavi> ListOnNavigation
        {
            get { return _listOnNavigation; }
            set { SetProperty(ref _listOnNavigation, value); }
        }

        private Color _tab3Color;
        public Color Tab3Color
        {
            get { return _tab3Color; }
            set { SetProperty(ref _tab3Color, value); }
        }

        private Color _tab1Color;
        public Color Tab1Color
        {
            get { return _tab1Color; }
            set { SetProperty(ref _tab1Color, value); }
        }

        private Color _tab2Color;
        public Color Tab2Color
        {
            get { return _tab2Color; }
            set { SetProperty(ref _tab2Color, value); }
        }

        private bool _isPass;
        public bool IsPass
        {
            get { return _isPass; }
            set { SetProperty(ref _isPass, value); }
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

        private ItemGiaTri _itemGT;
        public ItemGiaTri ItemGT { get { return _itemGT; } set { SetProperty(ref _itemGT, value); } }

        private string _entryBienTruot;
        public string EntryBienTruot
        {
            get { return _entryBienTruot; }
            set { SetProperty(ref _entryBienTruot, value); }
        }

        private string _entryGiaDK;
        public string EntryGiaDK
        {
            get { return _entryGiaDK; }
            set { SetProperty(ref _entryGiaDK, value); }
        }

        private string _sum;
        public string Sum
        {
            get { return _sum; }
            set { SetProperty(ref _sum, value); }
        }

        private string _kLMax;
        public string KLMax
        {
            get { return _kLMax; }
            set { SetProperty(ref _kLMax, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private Color _btnAccept;
        public Color BtnAccept { get { return _btnAccept; } set { SetProperty(ref _btnAccept, value); } }
        public LenhDieuKienViewModel()
        {
            EntryBienTruot = "0";
            IsPass = true;
            ListDK = new List<string>();
            ListOnNavigation = new List<ItemListNavi>();
            AddDataListDK();
            AddDataListOnNavigation();
            FontFmMua = FontAttributes.Bold;
            FontFmBan = FontAttributes.None;
            TextBtnXacNhan = "XÁC NHẬN MUA";
            BackgroundBtnXacNhan = Color.FromHex("#c9c9c9");
            Tab2Color = Color.Green;
            Tab1Color = Color.Gray;
            Tab3Color = Color.Gray;
            ItemGT = new ItemGiaTri(0, 1358.5, "1,191", "1,192", "1188.2", "20,82", "27,33", "12", "30", "1,181.9", "1,118.8", "1,272", "115,18", "1,115.6");
            ItemListNavigation = "VN30F2106";
            EntryGiaDK = ItemGT.GTBannerGia.ToString();
            Sum = (double.Parse(EntryGiaDK) + double.Parse(EntryBienTruot)).ToString();
            ListOnNavigationIsVisible = false;
            ClickTranfer = new Command<string>(OnClickTranfer);
            ClickSelectTab = new Command<string>(OnClickSelectTab);
            ClickItemOnNavigationList = new Command<ItemListNavi>(OnClickItemOnNavigationList);
            CollapsedList = new Command<bool>(ClickCollapsedList);
            ClickTab = new Command<string>(OnClickTab);
            ClickListOnNavigation = new Command(OnClickListOnNavigation);
            ClickShowPass = new Command(OnClickShowPass);
            BtnMinus = new Command<string>(OnClickBtnMinus);
            BtnPlus = new Command<string>(OnClickBtnPlus);
        }

        private void OnClickBtnPlus(string key)
        {
            if (key.Equals("BientruotPlus"))
            {                
                EntryBienTruot = (double.Parse(EntryBienTruot) +  0.1).ToString();
            }
            else if (key.Equals("GiaDKPlus"))
            {
                if (!GiaIsVisible)
                {
                    EntryGiaDK = (double.Parse(EntryGiaDK) + 0.1).ToString();
                }
            }
            else if (key.Equals("KLPlus"))
            {
                KLMax = "0";
            }
            Sum = (double.Parse(EntryGiaDK)+ double.Parse(EntryBienTruot)).ToString();
        }

        private void OnClickBtnMinus(string key)
        {          
            if (key.Equals("BientruotMinnus"))
            {
                if (EntryBienTruot.Equals("0"))
                {
                    EntryBienTruot = "0";
                }
                else
                {
                    EntryBienTruot = (double.Parse(EntryBienTruot) - 0.1).ToString();   
                }
                
            }
            else if (key.Equals("GiaDKMinus"))
            {
                if (!GiaIsVisible)
                {
                    EntryGiaDK = (double.Parse(EntryGiaDK) + 0.1).ToString();
                }
            }
            else if (key.Equals("KLMinus"))
            {
                KLMax = "0";
            }
            Sum = (double.Parse(EntryGiaDK) + double.Parse(EntryBienTruot)).ToString();
        }

        private void OnClickItemOnNavigationList(ItemListNavi item)
        {
            ItemListNavigation = item.Ma;
            ListOnNavigationIsVisible = false;
            EntryGiaDK = ItemGT.GTBannerGia.ToString();
            Sum = (double.Parse(EntryGiaDK) + double.Parse(EntryBienTruot)).ToString(); 
            if (item.ID == 0)
            {
                ItemGT = new ItemGiaTri(0, 1358.5, "1,191", "1,192", "1188.2", "20,82", "27,33", "12", "30", "1,181.9", "1,118.8", "1,272", "115,18", "1,115.6");
            }
            else if (item.ID == 1)
            {
                ItemGT = new ItemGiaTri(1, 1399.1, "1,131", "1,191", "1128.3", "20,242", "27,313", "7", "21", "2,188.3", "1,138.6", "1,479", "118,88", "1,135.6");
            }
            else if (item.ID == 2)
            {
                ItemGT = new ItemGiaTri(2, 1354.9, "1,191", "1,196", "1178.7", "20,832", "27,383", "3", "17", "1,118.8", "1,168.7", "111,214", "1,188.8", "1,106.6");
            }
            else if (item.ID == 3)
            {
                ItemGT = new ItemGiaTri(3, 1289.3, "1,124", "1,199", "1198.8", "20,802", "27,393", "10", "27", "1,168.9", "1,178.1", "11,272", "112,269", "1,106.6");
            }
            else
            {
                ItemGT = new ItemGiaTri(4, 1765.5, "1,196", "1,132", "1128.1", "20,854", "27,333", "8", "47", "1,138.2", "1,185.7", "15,272", "1,188.8", "1,108.6");
            }
        }

        private void OnClickListOnNavigation()
        {
            if (ListOnNavigationIsVisible)
            {
                ListOnNavigationIsVisible = false;
            }
            else
            {
                ListOnNavigationIsVisible = true;
            }
        }

        private void OnClickSelectTab(string key)
        {
            if (key.Equals("Tab1"))
            {
                Tab1Color = Color.Green;
                Tab2Color = Color.Gray;
                Tab3Color = Color.Gray;
            }
            if (key.Equals("Tab2"))
            {
                Tab2Color = Color.Green;
                Tab1Color = Color.Gray;
                Tab3Color = Color.Gray;
            }
            if (key.Equals("Tab3"))
            {
                Tab3Color = Color.Green;
                Tab2Color = Color.Gray;
                Tab1Color = Color.Gray;
            }
        }

        private void OnClickTranfer(string key)
        {
            if (key.Equals("00") || key.Equals("10") || key.Equals("20"))
            {

                FontFmMua = FontAttributes.None;
                FontFmBan = FontAttributes.Bold;
                TextBtnXacNhan = "XÁC NHẬN BÁN";
            }
            if (key.Equals("01") || key.Equals("11") || key.Equals("21"))
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
                Sum = (double.Parse(EntryGiaDK) + double.Parse(EntryBienTruot)).ToString();
                if(KLMax!=null && Password.Length!=0)
                {
                    BtnAccept = Color.Green;
                }
            }
            if (key.Equals("2"))
            {
                FontFmMua = FontAttributes.None;
                FontFmBan = FontAttributes.Bold;
                TextBtnXacNhan = "XÁC NHẬN BÁN";
                Sum = (double.Parse(EntryGiaDK) - double.Parse(EntryBienTruot)).ToString();
            }

        }
        private void ClickCollapsedList(bool key)
        {
            if (key)
                IsExpand = false;
        }
        public void ItemSelect(int index)
        {
            if (index == 0 || index == 1)
            {
                GiaIsVisible = false;
                LbGiaDK = false;
                LbKhoangLai = false;
            }
            else if (index == 2)
            {
                GiaIsVisible = true;
                LbKhoangLai = false;
                LbGiaDK = false;
            }
            else if (index == 3)
            {
                GiaIsVisible = true;
                LbKhoangLai = true;
                LbGiaDK = true;
            }
        }
        private void AddDataListDK()
        {
            ListDK.Add("Lệnh UP");
            ListDK.Add("Lệnh DOWN");
            ListDK.Add("Lệnh OCO");
            ListDK.Add("Lệnh B&B");
        }

        private void AddDataListOnNavigation()
        {
            ListOnNavigation.Add(new ItemListNavi { ID = 0, Ma = "VN30F2106" });
            ListOnNavigation.Add(new ItemListNavi { ID = 1, Ma = "VN30F2105" });
            ListOnNavigation.Add(new ItemListNavi { ID = 2, Ma = "VN30F2112" });
            ListOnNavigation.Add(new ItemListNavi { ID = 3, Ma = "VN30F2109" });
            ListOnNavigation.Add(new ItemListNavi { ID = 4, Ma = "GB05F2106" });
            ListOnNavigation.Add(new ItemListNavi { ID = 5, Ma = "GB05F2109" });
            ListOnNavigation.Add(new ItemListNavi { ID = 6, Ma = "GB10F2109" });
            ListOnNavigation.Add(new ItemListNavi { ID = 7, Ma = "GB10F2106" });
        }

    }
}
