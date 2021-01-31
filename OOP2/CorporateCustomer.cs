using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel müşteri bir musteridir demektir miras alması
    
    class CorporateCustomer :Customer
    {
        //public int Id { get; set; }
        //public string CustomerNo { get; set; }
        //Ortak özellikleri Customer(ebeveyn) classına alıyoruz
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
