using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspireWork.Model;
using System.Collections.ObjectModel;

namespace AspireWork.Services
{
    interface IDataAccessService
    {
        ObservableCollection<Transactions> GetTransactions();
    }

    public class DataAccessService : IDataAccessService
    {
        AspireWorkEntities1 context;
        public DataAccessService()
        {
            context = new AspireWorkEntities1();
        }

        public ObservableCollection<Transactions> GetTransactions()
        {
            ObservableCollection<Transactions> Transactions = new ObservableCollection<Transactions>();
            foreach (var item in context.Transactions)
            {
                Transactions.Add(item);
            }

            return Transactions;
        }

    }
}

  
