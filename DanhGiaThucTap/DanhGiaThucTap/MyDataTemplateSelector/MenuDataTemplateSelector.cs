using DanhGiaThucTap.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DanhGiaThucTap.MyDataTemplateSelector
{
    class MenuDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MenuTemplate { get; set; }
        public DataTemplate ItemTemplate { get; set; }
        public DataTemplate DropdownTemplete { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (((MenuModel)item).Title.Equals("Thị trường") || ((MenuModel)item).Title.Equals("Giao dịch") || ((MenuModel)item).Title.Equals("Trợ giúp"))
            {
                return MenuTemplate;
            }
            else if(((MenuModel)item).Title.Equals("Báo cáo giao dịch"))
            {
                return DropdownTemplete;
            }
            else
            {
                return ItemTemplate;
            }
        }
    }
}
