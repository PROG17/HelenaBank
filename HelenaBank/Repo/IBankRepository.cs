using HelenaBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelenaBank.Repo
{
    public interface IBankRepository
    {
        List<Customer> ImportCustomers();
    }
}
