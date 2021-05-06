using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DanhGiaThucTap.ViewModel
{
    class LenhDieuKienViewModel : BaseViewModel
    {
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
            set {SetProperty(ref _isExpand, value); }
        }
        public LenhDieuKienViewModel()
        {
            CollapsedList = new Command<bool>(ClickCollapsedList);
            ClickTab = new Command<string>(OnClickTab);
            FontFmMua = FontAttributes.Bold;
            FontFmBan = FontAttributes.None;
        }

        private void OnClickTab(string key)
        {
            if (key.Equals("1"))
            {
                FontFmMua = FontAttributes.Bold;
                FontFmBan = FontAttributes.None;
            }
            if (key.Equals("2"))
            {
                FontFmMua = FontAttributes.None;
                FontFmBan = FontAttributes.Bold;
            }
            
        }
        private void ClickCollapsedList(bool key)
        {
            if(key)
            IsExpand = false;
        }
    }
}
