using DanhGiaThucTap.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DanhGiaThucTap.Model
{
    public class ItemGiaTri : BaseViewModel
    {
        private int _id;
        public int ID { get { return _id; } set { SetProperty(ref _id, value); } }
        public double GTBannerGia { get; set; }
        public string GTMoCua { get; set; }
        public string GTCao { get; set; }
        public string GTThap { get; set; }
        public string GTTongHD { get; set; }
        public string GTKLMo { get; set; }
        public string GTDuMua00 { get; set; }
        public string GTDuBan01 { get; set; }
        public string GT01 { get; set; }
        public string GT00 { get; set; }
        public string GTSan1 { get; set; }
        public string GTSan2 { get; set; }
        public string GTSan3 { get; set; }

        public ItemGiaTri(int iD, double gTBannerGia, string gTMoCua, string gTCao, string gTThap, string gTTongHD, string gTKLMo, string gTDuMua00, string gTDuBan01, string gT01, string gT00, string gTSan1, string gTSan2, string gTSan3)
        {
            ID = iD;
            GTBannerGia = gTBannerGia;
            GTMoCua = gTMoCua;
            GTCao = gTCao;
            GTThap = gTThap;
            GTTongHD = gTTongHD;
            GTKLMo = gTKLMo;
            GTDuMua00 = gTDuMua00;
            GTDuBan01 = gTDuBan01;
            GT01 = gT01;
            GT00 = gT00;
            GTSan1 = gTSan1;
            GTSan2 = gTSan2;
            GTSan3 = gTSan3;
        }
        public ItemGiaTri()
        {

        }
    }
}
