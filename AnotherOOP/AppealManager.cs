using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    public class AppealManager
    {
        public void AppealRequest(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void BeforeCreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
