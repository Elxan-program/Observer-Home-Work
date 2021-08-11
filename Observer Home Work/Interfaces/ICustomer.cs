using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Home_Work.Interfaces
{
    public interface ICustomer
    {
        string ProductName { get; set; }
        string CustomerEmail { get; set; }
        void GetMessage();
    }
}
