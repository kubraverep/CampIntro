using System;

namespace OOP2
{
    //INHERITENCE
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer1 = new Customer();
            //customer1.Name = "Kübra";
            //customer1.Surname = "Verep";
            //customer1.Id = 1;
            //customer1.TcNo = "22222222222";
            //customer1.CustomerNo = "1234";
            //Gerçek-Tüzel(individual-corporate) nesneler vardır bunlar birbirine benzeyebilir ama farklı nesnelerdir.Ör;Gerçek(bireysel) müşteri,Tüzel müşteri(şirket müsteri);
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "1234";
            customer1.Name = "Kübra";
            customer1.Surname = "Verep";
            customer1.TcNo = "12345678910";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "5678";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            /*************************************************/
            Customer customer3 = new IndividualCustomer();//new diyince ref. nosu yani adres vermiş oluyoruz.Customer classı hem Individual hem de corporate müşterinin referansını (adresini) tutabiliyor.
            Customer customer4 = new CorporateCustomer();
            /*************************************************/
            CustomerManager customerManager = new CustomerManager();
            //Add metoduna hem ındividual müşteriyi hem de corporate müşteriyi gönderebiliriz.
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
