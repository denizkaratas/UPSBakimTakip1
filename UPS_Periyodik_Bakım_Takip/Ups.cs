using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPS_Periyodik_Bakım_Takip
{
    public class Ups
    {
        public string Açıklama { get; set; }
        public string BakımTarihi { get; set; }
        public string BirSonrakiBakimTarihi { get; set; }
        public string BulunduğuYerBölüm { get; set; }
        public string BulunduğuYerleşke { get; set; }
        public string Güç { get; set; }
        public string SeriNo { get; set; }
        public string SorumluKişi { get; set; }
        public string SıraNo { get; set; }
        public string UpsMarkaModel { get; set; }
    }
}
