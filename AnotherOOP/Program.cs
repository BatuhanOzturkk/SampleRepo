using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID --> O Harfi -- Sisteme yeni bir özellik eklendiğinde mevcut kodlar bozulmaz.

            ICreditManager personelFinanceCredit = new PersonelFinanceCredit();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService dataLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService> { new DatabaseLoggerService(), new SMSLoggerService() };

            AppealManager appealManager = new AppealManager();
            appealManager.AppealRequest(personelFinanceCredit, loggerServices);


            List<ICreditManager> credits = new List<ICreditManager>() { personelFinanceCredit };
            //appealManager.BeforeCreditInformation(credits);



        }
    }
}
