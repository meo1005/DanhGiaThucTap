using DanhGiaThucTap.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DanhGiaThucTap.Model
{
    public class ItemGiaTriModel : BaseViewModel
    {             
        public double GTBannerGia { get; set; }
        public double GTMoCua { get; set; }
        public double GTCao { get; set; }
        public double GTThap { get; set; }
        public double GTTongHD { get; set; }
        public double GTKLMo { get; set; }
        public double GTDuMua00 { get; set; }
        public double GTDuBan01 { get; set; }
        public double GTDuBan11 { get; set; }
        public double GTDuBan21 { get; set; }
        public double GTDuMua10 { get; set; }
        public double GTDuMua20 { get; set; }
        public double GT01 { get; set; }
        public double GT00 { get; set; }
        public double GT10 { get; set; }
        public double GT11 { get; set; }
        public double GT20 { get; set; }
        public double GT21 { get; set; }
        public double GTTran { get; set; }
        public double GTTB { get; set; }
        public double GTSan { get; set; }
        public double TileMua { get; set; }
        public double TileBan { get; set; }
        public int KLMax { get; set; }

        public ItemGiaTriModel(double gTBannerGia, double gTMoCua, double gTCao, double gTThap, double gTTongHD, double gTKLMo, double gTDuMua00, double gTDuBan01, double gTDuBan11, double gTDuBan21, double gTDuMua10, double gTDuMua20, double gT01, double gT00, double gT10, double gT11, double gT20, double gT21, double gTSan1, double gTSan2, double gTSan3, double tileMua, double tileBan, int kLMax)
        {
            GTBannerGia = gTBannerGia;
            GTMoCua = gTMoCua;
            GTCao = gTCao;
            GTThap = gTThap;
            GTTongHD = gTTongHD;
            GTKLMo = gTKLMo;
            GTDuMua00 = gTDuMua00;
            GTDuBan01 = gTDuBan01;
            GTDuBan11 = gTDuBan11;
            GTDuBan21 = gTDuBan21;
            GTDuMua10 = gTDuMua10;
            GTDuMua20 = gTDuMua20;
            GT01 = gT01;
            GT00 = gT00;
            GT10 = gT10;
            GT11 = gT11;
            GT20 = gT20;
            GT21 = gT21;
            GTTran = gTSan1;
            GTTB = gTSan2;
            GTSan = gTSan3;
            TileMua = tileMua;
            TileBan = tileBan;
            kLMax = KLMax;
        }

        public ItemGiaTriModel()
        {

        }       
    }
}
