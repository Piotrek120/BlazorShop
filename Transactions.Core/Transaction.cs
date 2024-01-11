using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transactions.Core;

public class Transaction<T1, T2>
{
    public List<T1> Products { get; set; }
    public T2 User { get; set; }

    public Transaction(List<T1> products, T2 user)
    {
        this.User = user;
        this.Products = products;
    }
}
