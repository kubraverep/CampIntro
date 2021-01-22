using System;
using System.Collections.Generic;
using System.Text;

namespace CampMethods
{
    public class Product
    {
        //Property-Özellik
        public int Id { get; set; }
        public string  Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }

        /* stok adedi adında yeni bir prop eklersem sepet classındaki ekle2 metodu kullanılamaz hale gelir 
        bunun için 1. ekle metodundaki gibi bir düzene sokulmasına encapsulation denir.*/
        public int StokAdedi { get; set; }

    }
}
