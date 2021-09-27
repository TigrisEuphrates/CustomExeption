using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExeption
{
    [Serializable]
    class CarIsDeadExeption : ApplicationException
    {
        //private string messageDetails = String.Empty;
        //public DateTime ErrorTimeStamp { get; set; }
        //public string CauseOfError { get; set; }
        public CarIsDeadExeption() { }
        public CarIsDeadExeption(string message, string cause, DateTime time):base(message)
        {
            //messageDetails = message;
            //CauseOfError = cause;
            //ErrorTimeStamp = time;
        }
        //public override string Message => $"Car Error Message: {messageDetails}";
        //changes to test smth
    }
}
