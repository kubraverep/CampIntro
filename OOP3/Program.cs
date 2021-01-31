using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //INTERFACES,POLIMORFIZM
        static void Main(string[] args)
        {
            /*****Interfaceler de ebeveyn classlar gibi o interfaceyi implemente eden 
             classın referans nosunu tutabiliyor******/

            //IhtiyacCreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            //ihtiyacCreditManager.Calculate();
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();

            //TasıtCreditManager tasıtCreditManager = new TasıtCreditManager();
            //tasıtCreditManager.Calculate();
            ICreditManager tasıtCreditManager = new TasıtCreditManager();

            //KonutCreditManager konutCreditManager = new KonutCreditManager();
            //konutCreditManager.Calculate();
            ICreditManager konutCreditManager = new KonutCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            // ya da
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(ihtiyacCreditManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {ihtiyacCreditManager };
            //applicationManager.KrediOnBilgilendirmesiYap(credits);


        }
    }
}
