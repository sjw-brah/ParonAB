using PäronAB.Domain.Interfaces;
using PäronAB.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PäronAB.DataAccessLayer.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        static List<Transaction> _transactionList = new List<Transaction>
        {
            new Transaction {ID=Guid.NewGuid(),Date=DateTime.Now.AddDays(1),ProductId="P001",Sum=8900,Quantity=1,WarehouseId=1 },
            new Transaction {ID=Guid.NewGuid(),Date=DateTime.Now.AddDays(3),ProductId="P002",Sum=5700,Quantity=1,WarehouseId=2 },
            new Transaction {ID=Guid.NewGuid(),Date=DateTime.Now.AddDays(2),ProductId="P001",Sum=8900,Quantity=1,WarehouseId=1 },
            new Transaction {ID=Guid.NewGuid(),Date=DateTime.Now.AddHours(5),ProductId="P003",Sum=-11000,Quantity=-1,WarehouseId=1 },
            new Transaction {ID=Guid.NewGuid(),Date=DateTime.Now.AddMinutes(100),ProductId="P003",Sum=1100,Quantity=1,WarehouseId=3 }
        };

        public List<Transaction> GetTransactions()
        {
            return _transactionList;
        }

        public Guid SaveTransaction(Transaction t)
        {
            _transactionList.Add(t);
            var transaction = _transactionList.OrderByDescending(tran => tran.ID).Take(1).FirstOrDefault();

            return transaction.ID;
        }
    }
}
