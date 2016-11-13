using PäronAB.Domain.Interfaces;
using PäronAB.Domain.Models;
using System;
using System.Collections.Generic;

namespace PäronAB.Domain.Services
{
    public class TransactionService : ITransactionService
    {
        ITransactionRepository _transactionRepo;
        public TransactionService(ITransactionRepository transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }

        public List<Transaction> GetTransactions()
        {
            return _transactionRepo.GetTransactions();
        }

        public Guid SaveTransaction(Transaction t)
        {
            return _transactionRepo.SaveTransaction(t);
        }
    }
}
