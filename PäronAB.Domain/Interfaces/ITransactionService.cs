using PäronAB.Domain.Models;
using System;
using System.Collections.Generic;

namespace PäronAB.Domain.Interfaces
{
    public interface ITransactionService
    {
        List<Transaction> GetTransactions();
        Guid SaveTransaction(Transaction t);
    }
}
