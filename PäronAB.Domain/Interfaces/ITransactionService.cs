using PäronAB.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PäronAB.Domain.Interfaces
{
    public interface ITransactionService
    {
        List<Transaction> GetTransactions();
        Guid SaveTransaction(Transaction t);
    }
}
