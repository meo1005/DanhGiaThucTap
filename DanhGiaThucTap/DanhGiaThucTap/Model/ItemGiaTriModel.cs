using DanhGiaThucTap.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DanhGiaThucTap.Model
{
    public class ItemGiaTriModel : BaseViewModel
    {
        private int _id;
        public int ID { get { return _id; } set { SetProperty(ref _id, value); } }
        public double GTBannerGia { get; set; }
        public double GTMoCua { get; set; }
        public double GTCao { get; set; }
        public double GTThap { get; set; }
        public double GTTongHD { get; set; }
        public double GTKLMo { get; set; }
        public double GTDuMua00 { get; set; }
        public double GTDuBan01 { get; set; }
        public double GT01 { get; set; }
        public double GT00 { get; set; }
        public double GTSan1 { get; set; }
        public double GTSan2 { get; set; }
        public double GTSan3 { get; set; }
        public double TileMua { get; set; }
        public double TileBan { get; set; }
        public ItemGiaTriModel(int iD, double gTBannerGia, double gTMoCua, double gTCao, double gTThap, double gTTongHD, double gTKLMo, double gTDuMua00, double gTDuBan01, double gT01, double gT00, double gTSan1, double gTSan2, double gTSan3, double tiLeMua, double tileBan)
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
            TileMua = tiLeMua;
            TileBan = tileBan;
        }

        public ItemGiaTriModel()
        {

        }       
    }
}
