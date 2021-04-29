using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab12
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public decimal Spocti(decimal operand1, decimal operand2, string operace)
        {
            switch(operace)
            {
                case "plus":
                    return operand1 + operand2;
                case "minus":
                    return operand1 - operand2;
                case "mult":
                    return operand1 * operand2;
                case "divide":
                    return operand1 / operand2;
                default:
                    return 0;
            }
        }
    }
}
