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
        public Command<ItemListNavigationModel> ClickItemOnNavigationList { get; }
        public Command<bool> CollapsedList { get; }
        public Command<string> ClickTab { get; }
        public Command<string> ClickSelectTab { get; }
        public Command<string> BtnPlus { get; }
        public Command<string> BtnMinus { get; }
        public Command CloseList { get; }

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

        private List<ItemListNavigationModel> _listOnNavigation;
        public List<ItemListNavigationModel> ListOnNavigation
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

        private int _index;
        public int Index
        {
            get { return _index; }
            set { SetProperty(ref _index, value); }
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

        private string _entryKhoangLai;
        public string EntryKhoangLai
        {
            get { return _entryKhoangLai; }
            set { SetProperty(ref _entryKhoangLai, value); }
        }

        private ItemGiaTriModel _itemGT;
        public ItemGiaTriModel ItemGT { get { return _itemGT; } set { SetProperty(ref _itemGT, value); } }

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

        private string _frameGiaDK;
        public string FrameGiaDK
        {
            get { return _frameGiaDK; }
            set { SetProperty(ref _frameGiaDK, value); }
        }

        private string _entryGia;
        public string EntryGia
        {
            get { return _entryGia; }
            set { SetProperty(ref _entryGia, value); }
        }

        private string _sum;
        public string Sum
        {
            get { return _sum; }
            set { SetProperty(ref _sum, value); }
        }

        private string _sumLai;
        public string SumLai
        {
            get { return _sumLai; }
            set { SetProperty(ref _sumLai, value); }
        }

        private string _kLMax;
        public string KLMax
        {
            get { return _kLMax; }
            set { SetProperty(ref _kLMax, value); }
        }


        public LenhDieuKienViewModel()
        {
            EntryBienTruot = "0";
            EntryKhoangLai = "0";
            IsPass = true;
            ListDK = new List<string>();
            ListOnNavigation = new List<ItemListNavigationModel>();
            AddDataListDK();
            AddDataListOnNavigation();
            FontFmMua = FontAttributes.Bold;
            FontFmBan = FontAttributes.None;
            TextBtnXacNhan = "XÁC NHẬN MUA";
            Tab2Color = Color.Green;
            Tab1Color = Color.Gray;
            Tab3Color = Color.Gray;
            ItemGT = new ItemGiaTriModel(1358.5, 1.191, 1.192, 1188.2, 20.82, 27.33, 12, 30, 181.9, 118.8, 1.272, 115.18, 115.6, 75.23, 24.77);
            ItemListNavigation = "VN30F2106";
            EntryGiaDK = ItemGT.GTBannerGia.ToString();
            Sum = (double.Parse(EntryGiaDK) + double.Parse(EntryBienTruot)).ToString();
            ListOnNavigationIsVisible = false;
            ClickTranfer = new Command<string>(OnClickTranfer);
            ClickSelectTab = new Command<string>(OnClickSelectTab);
            ClickItemOnNavigationList = new Command<ItemListNavigationModel>(OnClickItemOnNavigationList);
            CollapsedList = new Command<bool>(ClickCollapsedList);
            ClickTab = new Command<string>(OnClickTab);
            ClickListOnNavigation = new Command(OnClickListOnNavigation);
            ClickShowPass = new Command(OnClickShowPass);
            BtnMinus = new Command<string>(OnClickBtnMinus);
            BtnPlus = new Command<string>(OnClickBtnPlus);
            CloseList = new Command(OnClickCloseList);
        }
        //hàm bắt sự kiện click vào background để tắt list navigation
        private void OnClickCloseList()
        {
            ListOnNavigationIsVisible = false;
        }
        // Command xử lý sự kiện dấu +
        private void OnClickBtnPlus(string key)
        {
            // dấu cộng trường Biên trượt
            if (key.Equals("BientruotPlus"))
            {
                EntryBienTruot = (double.Parse(EntryBienTruot) + 0.1).ToString();
            }
            //dấu công trường khoảng lãi
            else if (key.Equals("KhoangLaiPlus"))
            {
                EntryKhoangLai = (double.Parse(EntryKhoangLai) + 0.1).ToString();
            }
            // dấu cộng trường giá điều kiện
            else if (key.Equals("GiaDKPlus"))
            {
                if (Index == 0)
                {
                    EntryGiaDK = (double.Parse(EntryGiaDK) + 0.1).ToString();
                }
                else if (Index == 1)
                {
                    if (double.Parse(EntryGiaDK) >= ItemGT.GTBannerGia)
                    {
                        App.Current.MainPage.DisplayAlert("Thông báo", "Giá điều kiện phải nhỏ hơn giá thị trường", "OK");
                    }
                    else
                    {
                        EntryGiaDK = (double.Parse(EntryGiaDK) + 0.1).ToString();
                    }
                }
                //dấu cộng trường giá điều kiện với trường hợp mã OCO
                else if (Index == 2)
                {
                    if (SumLai != null)
                    {
                        if (double.Parse(EntryGiaDK) >= double.Parse(SumLai) && TextBtnXacNhan.Equals("XÁC NHẬN BÁN"))
                        {
                            App.Current.MainPage.DisplayAlert("Thông báo", "Giá điều kiện phải nhỏ hơn giá chốt lãi", "OK");
                        }
                        else
                        {
                            EntryGiaDK = (double.Parse(EntryGiaDK) + 0.1).ToString();
                        }
                    }
                }
                else
                {
                    EntryGiaDK = (double.Parse(EntryGiaDK) + 0.1).ToString();
                }
            }
            //dấu cộng trường khối lượng
            else if (key.Equals("KLPlus"))
            {
                KLMax = "0";
            }
            // dấu cộng trường Giá
            else if (key.Equals("GiaPlus"))
            {
                EntryGia = (double.Parse(EntryGia) + 0.1).ToString();
            }
            //tính tổng tại trường giá đặt điều chỉnh, trường Giá chốt lãi
            if (Index == 3)
            {
                FrameGiaDK = (double.Parse(EntryGia) - double.Parse(EntryGiaDK)).ToString();
                Sum = (double.Parse(FrameGiaDK) - double.Parse(EntryBienTruot)).ToString();
            }
            else if (Index == 2 || Index == 3)
            {
                SumLai = (double.Parse(EntryKhoangLai) + double.Parse(EntryGia)).ToString();
                Sum = (double.Parse(EntryGiaDK) + double.Parse(EntryBienTruot)).ToString();
            }
            else
            {
                Sum = (double.Parse(EntryGiaDK) + double.Parse(EntryBienTruot)).ToString();
            }

        }
        // Command xử lý sự kiện dấu -
        private void OnClickBtnMinus(string key)
        {
            // dấu trừ trường biên trượt
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
            //dấu trừ trường khoảng lãi
            else if (key.Equals("KhoangLaiMinus"))
            {
                if (EntryKhoangLai.Equals("0"))
                {
                    EntryKhoangLai = "0";
                }
                else
                {
                    EntryKhoangLai = (double.Parse(EntryKhoangLai) - 0.1).ToString();
                }
            }
            //dấu trừ trường giá điều kiện
            else if (key.Equals("GiaDKMinus"))
            {
                if (EntryGiaDK.Equals("0"))
                {
                    EntryGiaDK = "0";
                }
                else
                {
                    if (Index == 1)
                    {
                        EntryGiaDK = (double.Parse(EntryGiaDK) - 0.1).ToString();
                    }
                    else if (Index == 0)
                    {
                        if (double.Parse(EntryGiaDK) <= ItemGT.GTBannerGia)
                        {
                            App.Current.MainPage.DisplayAlert("Thông báo", "Giá điều kiện phải lớn hơn giá thị trường", "OK");
                        }
                        else
                        {
                            EntryGiaDK = (double.Parse(EntryGiaDK) - 0.1).ToString();
                        }
                    }
                    // dấu trừ trường giá điều kiện khi lệnh OCO 
                    else if (Index == 2)
                    {
                        if (SumLai != null)
                        {
                            if (double.Parse(EntryGiaDK) <= double.Parse(SumLai) && TextBtnXacNhan.Equals("XÁC NHẬN MUA"))
                            {
                                App.Current.MainPage.DisplayAlert("Thông báo", "Giá điều kiện phải lớn hơn giá chốt lãi", "OK");
                            }
                            else
                            {
                                EntryGiaDK = (double.Parse(EntryGiaDK) - 0.1).ToString();
                            }
                        }
                    }
                    else
                    {
                        EntryGiaDK = (double.Parse(EntryGiaDK) - 0.1).ToString();
                    }
                }
            }
            //dấu trừ trường Khối lượng
            else if (key.Equals("KLMinus"))
            {
                KLMax = "0";
            }
            // dấu trừ trường giá
            else if (key.Equals("GiaMinus"))
            {
                EntryGia = (double.Parse(EntryGia) - 0.1).ToString();
            }
            // tính tổng ở trường giá đặt điều chỉnh, giá chốt lãi
            if (Index == 3)
            {
                FrameGiaDK = (double.Parse(EntryGia) - double.Parse(EntryGiaDK)).ToString();
                Sum = (double.Parse(FrameGiaDK) - double.Parse(EntryBienTruot)).ToString();
            }
            else if (Index == 2 || Index == 3)
            {
                SumLai = (double.Parse(EntryKhoangLai) + double.Parse(EntryGia)).ToString();
                Sum = (double.Parse(EntryGiaDK) + double.Parse(EntryBienTruot)).ToString();
            }
            else
            {
                Sum = (double.Parse(EntryGiaDK) + double.Parse(EntryBienTruot)).ToString();
            }
        }
        // hàm bắt sự kiện click vào item của list trên navigation, xét các giá trị
        private void OnClickItemOnNavigationList(ItemListNavigationModel item)
        {
            ItemListNavigation = item.Ma;
            ListOnNavigationIsVisible = false;
            if (item.ID == 0)
            {
                ItemGT = new ItemGiaTriModel(1358.5, 1.191, 1.192, 1188.2, 20.82, 27.33, 12, 30, 181.9, 118.8, 1.272, 115.18, 115.6, 23, 77);
            }
            else if (item.ID == 1)
            {
                ItemGT = new ItemGiaTriModel(1399.1, 1.131, 1191, 1128.3, 20.242, 27.313, 7, 21, 188.3, 138.6, 1.479, 118.88, 135.6, 50, 50);
            }
            else if (item.ID == 2)
            {
                ItemGT = new ItemGiaTriModel(1354.9, 1.191, 1.196, 1178.7, 20.832, 27.383, 3, 17, 118.8, 168.7, 111.214, 188.8, 106.6, 59.26, 40.74);
            }
            else if (item.ID == 3)
            {
                ItemGT = new ItemGiaTriModel(1289.3, 1.124, 1.199, 1198.8, 20.802, 27.393, 10, 27, 168.9, 178.1, 11.272, 112.269, 106.6, 40, 60);
            }
            else
            {
                ItemGT = new ItemGiaTriModel(1765.5, 1.196, 1.132, 128.1, 20.854, 27.333, 8, 47, 138.2, 185.7, 15.272, 188.8, 108.6, 10, 90);
            }
            if (Index == 0 || Index == 1)
            {
                EntryGiaDK = ItemGT.GTBannerGia.ToString();
            }
            if (Index == 2)
            {
                EntryGia = ItemGT.GTSan2.ToString();
                if (TextBtnXacNhan.Equals("XÁC NHẬN BÁN"))
                {
                    EntryGiaDK = (ItemGT.GTSan2 - 0.1).ToString();
                }
                else
                {
                    EntryGiaDK = (ItemGT.GTSan2 + 0.1).ToString();
                }
            }
            if (Index == 3)
            {
                EntryGia = ItemGT.GTSan2.ToString();
            }
            Sum = (double.Parse(EntryGiaDK) + double.Parse(EntryBienTruot)).ToString();
        }
        //hàm bắt sự kiện click ẩn hiện list trên navigation
        public void OnClickListOnNavigation()
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
        //hàm bắt sự kiện click vào 3 tab trên cùng
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
        //hàm bắt sự kiện click hiệu ứng nháy nháy
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
        //hàm bắt sự kiện ẩn hiện password
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
        //hàm bắt sự kiện click vào 2 tab MUA và BÁN
        private void OnClickTab(string key)
        {
            if (key.Equals("1"))
            {
                FontFmMua = FontAttributes.Bold;
                FontFmBan = FontAttributes.None;
                TextBtnXacNhan = "XÁC NHẬN MUA";
                if (Index == 3)
                {
                    FrameGiaDK = (double.Parse(EntryGia) - double.Parse(EntryGiaDK)).ToString();
                    Sum = (double.Parse(FrameGiaDK) - double.Parse(EntryBienTruot)).ToString();
                }
                else
                {
                    Sum = (double.Parse(EntryGiaDK) + double.Parse(EntryBienTruot)).ToString();
                }
            }
            if (key.Equals("2"))
            {
                FontFmMua = FontAttributes.None;
                FontFmBan = FontAttributes.Bold;
                TextBtnXacNhan = "XÁC NHẬN BÁN";
                if (Index == 3)
                {
                    FrameGiaDK = (double.Parse(EntryGia) + double.Parse(EntryGiaDK)).ToString();
                    Sum = (double.Parse(FrameGiaDK) + double.Parse(EntryBienTruot)).ToString();
                }
                else
                {
                    Sum = (double.Parse(EntryGiaDK) - double.Parse(EntryBienTruot)).ToString();
                }
            }

        }
        //hàm bắt sự kiện cho expander
        private void ClickCollapsedList(bool key)
        {
            if (key)
                IsExpand = false;
        }
        //hàm bắt sự kiện khi click vào item của list các lệnh
        public void ItemSelect(int index)
        {

            if (index == 0)
            {
                Index = 0;
                GiaIsVisible = false;
                LbGiaDK = false;
                LbKhoangLai = false;
                EntryGiaDK = ItemGT.GTBannerGia.ToString();
                Sum = "";
            }
            else if (index == 1)
            {
                Index = 1;
                GiaIsVisible = false;
                LbGiaDK = false;
                LbKhoangLai = false;
                EntryGiaDK = ItemGT.GTBannerGia.ToString();
                Sum = "";
            }
            else if (index == 2)
            {
                Index = 2;
                GiaIsVisible = true;
                LbKhoangLai = false;
                LbGiaDK = false;
                EntryGiaDK = ItemGT.GTBannerGia.ToString();
                Sum = "";
                if (Index == 2)
                {
                    EntryGia = ItemGT.GTSan2.ToString();
                    if (TextBtnXacNhan.Equals("XÁC NHẬN BÁN"))
                    {
                        EntryGiaDK = (ItemGT.GTSan2 - 0.1).ToString();
                    }
                    else
                    {
                        EntryGiaDK = (ItemGT.GTSan2 + 0.1).ToString();
                    }

                }
            }
            else if (index == 3)
            {
                Index = 3;
                GiaIsVisible = true;
                LbKhoangLai = true;
                LbGiaDK = true;
                EntryGiaDK = "0";
                Sum = "";
            }
        }
        // thêm dữ liệu vào List lệnh
        private void AddDataListDK()
        {
            ListDK.Add("Lệnh UP");
            ListDK.Add("Lệnh DOWN");
            ListDK.Add("Lệnh OCO");
            ListDK.Add("Lệnh B&B");
        }
        //thêm dữ liệu vào List trên navigation
        private void AddDataListOnNavigation()
        {
            ListOnNavigation.Add(new ItemListNavigationModel { ID = 0, Ma = "VN30F2106" });
            ListOnNavigation.Add(new ItemListNavigationModel { ID = 1, Ma = "VN30F2105" });
            ListOnNavigation.Add(new ItemListNavigationModel { ID = 2, Ma = "VN30F2112" });
            ListOnNavigation.Add(new ItemListNavigationModel { ID = 3, Ma = "VN30F2109" });
            ListOnNavigation.Add(new ItemListNavigationModel { ID = 4, Ma = "GB05F2106" });
            ListOnNavigation.Add(new ItemListNavigationModel { ID = 5, Ma = "GB05F2109" });
            ListOnNavigation.Add(new ItemListNavigationModel { ID = 6, Ma = "GB10F2109" });
            ListOnNavigation.Add(new ItemListNavigationModel { ID = 7, Ma = "GB10F2106" });
        }
    }
}
