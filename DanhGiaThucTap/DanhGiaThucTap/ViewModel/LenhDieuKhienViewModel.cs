using DanhGiaThucTap.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;
namespace DanhGiaThucTap.ViewModel
{
    public class LenhDieuKhienViewModel : BaseViewModel
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
        public Command ShowExpander { get; }
        public Command<string> ClickGia { get; }

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

        private string _temp;
        public string Temp
        {
            get { return _temp; }
            set { SetProperty(ref _temp, value); }
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

        public LenhDieuKhienViewModel()
        {
            Temp = "Tab2";
            EntryBienTruot = "0";
            EntryKhoangLai = "0";
            KLMax = "0";
            IsPass = true;
            ListDK = new List<string>();
            ListOnNavigation = new List<ItemListNavigationModel>();
            AddDataListDK();
            AddDataListOnNavigation();
            FontFmMua = FontAttributes.Bold;
            FontFmBan = FontAttributes.None;
            TextBtnXacNhan = "XÁC NHẬN MUA";
            ItemGT = new ItemGiaTriModel { GTBannerGia = 1765.5, GTMoCua = 1.196, GTCao = 1.132, GTThap = 128.1, GTTongHD = 20.854, GTKLMo = 27.333, GTDuMua00 = 8, GTDuBan01 = 47, GT01 = 138.2, GT00 = 185.7, GTTran = 152.72, GTTB = 118.8, GTSan = 108.6, TileMua = 10, TileBan = 90, GT10 = 132.64, GT11 = 137.72, GT20 = 188.123, GT21 = 135.32, GTDuBan11 = 2, GTDuBan21 = 23, GTDuMua10 = 12, GTDuMua20 = 34, KLMax = 1 };
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
            ShowExpander = new Command(OnClickShowExpander);
            ClickGia = new Command<string>(OnClickGia);
        }
        //click giá sàn, giá trần
        private void OnClickGia(string key)
        {
            if (key.Equals("GiaTran"))
            {
                EntryGia = ItemGT.GTTran.ToString();
            }
            if (key.Equals("GiaTB"))
            {
                EntryGia = ItemGT.GTTB.ToString();
            }
            if (key.Equals("GiaSan"))
            {
                EntryGia = ItemGT.GTSan.ToString();
            }

            SetValue(EntryGia);

        }
        //show expander
        private void OnClickShowExpander()
        {
            if (IsExpand)
            {
                IsExpand = false;
            }
            else
            {
                IsExpand = true;
            }

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
                if (Checknegative(EntryBienTruot))
                {
                    EntryBienTruot = (double.Parse(EntryBienTruot) + 0.1).ToString();
                }
                else
                {
                    EntryBienTruot = "0";
                }
            }
            //dấu công trường khoảng lãi
            else if (key.Equals("KhoangLaiPlus"))
            {
                if (Checknegative(EntryKhoangLai))
                {
                    EntryKhoangLai = (double.Parse(EntryKhoangLai) + 0.1).ToString();
                }
                else
                {
                    EntryKhoangLai = "0";
                }
            }
            // dấu cộng trường giá điều kiện
            else if (key.Equals("GiaDKPlus"))
            {
                if (Checknegative(EntryGiaDK))
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
                        if (!SumLai.Equals(""))
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
                else
                {
                    if (Index == 0 || Index == 1)
                    {
                        EntryGiaDK = ItemGT.GTBannerGia.ToString();
                    }
                    else if (Index == 2)
                    {
                        EntryGiaDK = EntryGia;
                    }
                    else
                    {
                        EntryGiaDK = "0";
                    }
                }
            }
            //dấu cộng trường khối lượng
            else if (key.Equals("KLPlus"))
            {
                if (Checknegative(KLMax))
                {
                    if (Int32.Parse(KLMax) >= ItemGT.KLMax)
                    {
                        App.Current.MainPage.DisplayAlert("Thông báo", "Giá trị không được vượt quá MAX", "OK");
                    }
                    else
                    {
                        KLMax = (Int32.Parse(KLMax) + 1).ToString();
                    }
                }
                else
                {
                    KLMax = "0";
                }
            }
            // dấu cộng trường Giá
            else if (key.Equals("GiaPlus"))
            {
                if (Checknegative(EntryGia))
                {
                    if (double.Parse(EntryGia) >= ItemGT.GTTran)
                    {
                        App.Current.MainPage.DisplayAlert("Thông báo", "Giá không được nhỏ hơn giá trần", "OK");
                    }
                    else
                    {
                        EntryGia = (double.Parse(EntryGia) + 0.1).ToString();
                    }
                }
                else
                {
                    EntryGia = ItemGT.GTTB.ToString();
                }
            }
            //tính tổng tại trường giá đặt điều chỉnh, trường Giá chốt lãi
            if (Index == 3)
            {
                FrameGiaDK = (double.Parse(EntryGia) - double.Parse(EntryGiaDK)).ToString();
                Sum = (double.Parse(FrameGiaDK) - double.Parse(EntryBienTruot)).ToString();
                SumLai = (double.Parse(EntryKhoangLai) + double.Parse(EntryGia)).ToString();
            }
            else if (Index == 2)
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
                if (Checknegative(EntryBienTruot))
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
                else
                {
                    EntryBienTruot = "0";
                }

            }
            //dấu trừ trường khoảng lãi
            else if (key.Equals("KhoangLaiMinus"))
            {
                if (Checknegative(EntryKhoangLai))
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
                else
                {
                    EntryKhoangLai = "0";
                }
            }
            //dấu trừ trường giá điều kiện
            else if (key.Equals("GiaDKMinus"))
            {
                if (Checknegative(EntryGiaDK))
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
                            if (!SumLai.Equals(""))
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
                else
                {
                    if (Index == 0 || Index == 1)
                    {
                        EntryGiaDK = ItemGT.GTBannerGia.ToString();
                    }
                    else if (Index == 2)
                    {
                        EntryGiaDK = EntryGia;
                    }
                    else
                    {
                        EntryGiaDK = "0";
                    }
                }
            }
            //dấu trừ trường Khối lượng
            else if (key.Equals("KLMinus"))
            {
                if (Checknegative(KLMax))
                {
                    if (KLMax.Equals("0"))
                    {
                        KLMax = "0";
                    }
                    else
                    {
                        KLMax = (Int32.Parse(KLMax) - 1).ToString();
                    }
                }
                else
                {
                    KLMax = "0";
                }
            }
            // dấu trừ trường giá
            else if (key.Equals("GiaMinus"))
            {
                if (Checknegative(EntryGia))
                {
                    if (double.Parse(EntryGia) <= ItemGT.GTSan)
                    {
                        App.Current.MainPage.DisplayAlert("Thông báo", "Giá phải có giá trị lớn hơn giá sàn", "OK");
                    }
                    else
                    {
                        EntryGia = (double.Parse(EntryGia) - 0.1).ToString();
                    }
                }
                else
                {
                    EntryGia = ItemGT.GTTB.ToString();
                }

            }
            // tính tổng ở trường giá đặt điều chỉnh, giá chốt lãi
            if (Index == 3)
            {
                FrameGiaDK = (double.Parse(EntryGia) - double.Parse(EntryGiaDK)).ToString();
                Sum = (double.Parse(FrameGiaDK) - double.Parse(EntryBienTruot)).ToString();
                SumLai = (double.Parse(EntryKhoangLai) + double.Parse(EntryGia)).ToString();
            }
            else if (Index == 2)
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
                ItemGT = new ItemGiaTriModel { GTBannerGia = 1358.5, GTMoCua = 1.191, GTCao = 1.192, GTThap = 1188.2, GTTongHD = 20.82, GTKLMo = 27.33, GTDuMua00 = 12, GTDuBan01 = 30, GT01 = 181.9, GT00 = 118.8, GTTran = 172.32, GTTB = 125.18, GTSan = 105.6, TileMua = 23, TileBan = 77, GT10 = 132.64, GT11 = 137.72, GT20 = 188.123, GT21 = 135.32, GTDuBan11 = 2, GTDuBan21 = 23, GTDuMua10 = 12, GTDuMua20 = 34, KLMax = 2 };
            }
            else if (item.ID == 1)
            {
                ItemGT = new ItemGiaTriModel { GTBannerGia = 1399.1, GTMoCua = 1.131, GTCao = 1191, GTThap = 1128.3, GTTongHD = 20.242, GTKLMo = 27.313, GTDuMua00 = 7, GTDuBan01 = 21, GT01 = 188.3, GT00 = 138.6, GTTran = 147.93, GTTB = 128.88, GTSan = 115.6, TileMua = 50, TileBan = 50, GT10 = 132.64, GT11 = 137.72, GT20 = 188.123, GT21 = 135.32, GTDuBan11 = 2, GTDuBan21 = 23, GTDuMua10 = 12, GTDuMua20 = 34, KLMax = 3 };
            }
            else if (item.ID == 2)
            {
                ItemGT = new ItemGiaTriModel { GTBannerGia = 1354.9, GTMoCua = 1.191, GTCao = 1.196, GTThap = 1178.7, GTTongHD = 20.832, GTKLMo = 27.383, GTDuMua00 = 3, GTDuBan01 = 17, GT01 = 118.8, GT00 = 168.7, GTTran = 111.214, GTTB = 108.8, GTSan = 96.6, TileMua = 59.26, TileBan = 40.74, GT10 = 132.64, GT11 = 137.72, GT20 = 188.123, GT21 = 135.32, GTDuBan11 = 2, GTDuBan21 = 23, GTDuMua10 = 12, GTDuMua20 = 34, KLMax = 4 };
            }
            else
            {
                ItemGT = new ItemGiaTriModel { GTBannerGia = 1765.5, GTMoCua = 1.196, GTCao = 1.132, GTThap = 128.1, GTTongHD = 20.854, GTKLMo = 27.333, GTDuMua00 = 8, GTDuBan01 = 47, GT01 = 138.2, GT00 = 185.7, GTTran = 152.72, GTTB = 148.8, GTSan = 108.6, TileMua = 10, TileBan = 90, GT10 = 132.64, GT11 = 137.72, GT20 = 188.123, GT21 = 135.32, GTDuBan11 = 2, GTDuBan21 = 23, GTDuMua10 = 12, GTDuMua20 = 34, KLMax = 5 };
            }
            if (Index == 0 || Index == 1)
            {
                EntryGiaDK = ItemGT.GTBannerGia.ToString();
            }
            if (Index == 2 || Index == 3)
            {
                EntryGia = ItemGT.GTTB.ToString();
                SetValue(EntryGia);
            }
            Sum = "";
            SumLai = "";
            FrameGiaDK = "";
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
                Temp = "Tab1";
            }
            if (key.Equals("Tab2"))
            {
                Temp = "Tab2";
            }
            if (key.Equals("Tab3"))
            {
                Temp = "Tab3";
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
            if (key.Equals("00"))
            {
                EntryGia = ItemGT.GT00.ToString();
                SetValue(EntryGia);
            }
            if (key.Equals("01"))
            {
                EntryGia = ItemGT.GT01.ToString();
                SetValue(EntryGia);
            }
            /////////////////////////////////////////////
            if (key.Equals("10"))
            {
                EntryGia = ItemGT.GT10.ToString();
                SetValue(EntryGia);
            }
            if (key.Equals("11"))
            {
                EntryGia = ItemGT.GT11.ToString();
                SetValue(EntryGia);
            }
            if (key.Equals("20"))
            {
                EntryGia = ItemGT.GT20.ToString();
                SetValue(EntryGia);
            }
            if (key.Equals("21"))
            {
                EntryGia = ItemGT.GT21.ToString();
                SetValue(EntryGia);
            }
        }
        private void SetValue(string a)
        {
            if (Index == 2)
            {
                if (TextBtnXacNhan.Equals("XÁC NHẬN MUA"))
                {
                    EntryGiaDK = (double.Parse(a) + 0.1).ToString();
                }
                else
                {
                    EntryGiaDK = (double.Parse(a) - 0.1).ToString();
                }
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
                    if (FrameGiaDK != null)
                    {
                        FrameGiaDK = (double.Parse(EntryGia) - double.Parse(EntryGiaDK)).ToString();
                        Sum = (double.Parse(FrameGiaDK) - double.Parse(EntryBienTruot)).ToString();
                    }
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
                    if (FrameGiaDK != null)
                    {
                        FrameGiaDK = (double.Parse(EntryGia) + double.Parse(EntryGiaDK)).ToString();
                        Sum = (double.Parse(FrameGiaDK) + double.Parse(EntryBienTruot)).ToString();
                    }
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
                EntryGia = ItemGT.GTTB.ToString();
                /////////////////
                if (TextBtnXacNhan.Equals("XÁC NHẬN BÁN"))
                {
                    EntryGiaDK = (ItemGT.GTTB - 0.1).ToString();
                }
                else
                {
                    EntryGiaDK = (ItemGT.GTTB + 0.1).ToString();
                }

                SumLai = "";
            }
            ////////////////////////////////
            else if (index == 3)
            {
                Index = 3;
                GiaIsVisible = true;
                LbKhoangLai = true;
                LbGiaDK = true;
                EntryGiaDK = "0";
                Sum = "";
                SumLai = "";
                FrameGiaDK = "";
                EntryGia = ItemGT.GTTB.ToString();

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
        private bool Checknegative(string n)
        {
            if (double.Parse(n) < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
