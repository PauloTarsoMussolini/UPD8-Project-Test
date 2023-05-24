using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Domain.Validations.Base
{
    public class ReportErrors
    {
        public ReportErrors()
        {
            
        }

        public ReportErrors(string message)
        {
            Message = message;
        }
        public string Code { get; set; }
        public string  Message { get; set; }

        public static ReportErrors Create(string message) => new ReportErrors(message);
    }
}
