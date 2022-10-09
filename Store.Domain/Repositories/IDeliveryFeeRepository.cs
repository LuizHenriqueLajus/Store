using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Store.Domain.Repositories
{
    public interface IDeliveryFeeRepository
    {
        decimal Get(string ZipCode);
    }
}
