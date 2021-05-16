using DanhGiaThucTap.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DanhGiaThucTap.ViewModel
{
    class MenuViewModel : BaseViewModel
    {
        private List<MenuModel> _listMenuItem;
        public List<MenuModel> ListMenuItem
        {
            get { return _listMenuItem; }
            set { SetProperty(ref _listMenuItem, value); }
        }

        public MenuViewModel()
        {
            AddData();
        }

        private void AddData()
        {
            ListMenuItem = new List<MenuModel>()
            {
                new MenuModel { Title = "Thị trường"},
                new MenuModel { Title = "Tổng quan"},
                new MenuModel { Title = "Bảng giá"},
                new MenuModel { Title = "Đồ thị kỹ thuật"},
                new MenuModel { Title = "Chứng khoán cơ sở"},
                new MenuModel { Title = "Giao dịch"},
                new MenuModel { Title = "Lịch sự kiện"},
                new MenuModel { Title = "Đặt lệnh"},
                new MenuModel { Title = "Báo cáo giao dịch"},
                new MenuModel { Title = "Quản lý tài khoản"},
                new MenuModel { Title = "Chuyển tiền"},
                new MenuModel { Title = "Trợ giúp"},
                new MenuModel { Title = "Thông báo"},
                new MenuModel { Title = "Cài đặt mật khẩu" },
                new MenuModel { Title = "Liên hệ"},
                new MenuModel { Title = "Góp ý"},
                new MenuModel { Title = "Hướng dẫn sử dụng"},
                new MenuModel { Title = "Cài đặt"}
            };

        }
    }
}
