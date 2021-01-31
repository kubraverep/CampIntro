using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Gerçek-Bireysel müşteri
    class IndividualCustomer:Customer
    {
        //public int Id { get; set; }
        //public string CustomerNo { get; set; }
        //Ortak özellikleri Customer(ebeveyn) classına alıyoruz
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
