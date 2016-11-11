using PäronAB.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PäronAB.Domain.Models;

namespace PäronAB.DataAccessLayer.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        static List<Transaction> _transactionList = new List<Transaction>
        {
            new Transaction {ID=new Guid(),Date=DateTime.Now.AddDays(1),ProductId="P001",CostPrice=8900,Quantity=1,WarehouseId=1 },
            new Transaction {ID=new Guid(),Date=DateTime.Now.AddDays(3),ProductId="P002",CostPrice=5700,Quantity=1,WarehouseId=1 },
            new Transaction {ID=new Guid(),Date=DateTime.Now.AddDays(2),ProductId="P001",CostPrice=8900,Quantity=1,WarehouseId=1 },
            new Transaction {ID=new Guid(),Date=DateTime.Now.AddHours(5),ProductId="P003",CostPrice=11000,Quantity=1,WarehouseId=1 },
            new Transaction {ID=new Guid(),Date=DateTime.Now.AddMinutes(100),ProductId="P003",CostPrice=1100,Quantity=1,WarehouseId=1 }
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
