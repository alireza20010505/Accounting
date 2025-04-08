
using Accounting.DataLayer.Entities;

namespace Accounting.Core.Services.Interfaces;

public interface ITransactionsService
{
    long AddTransaction(Transaction transaction);
    void UpdateTransaction(Transaction transaction);
    void DeleteTransaction(long id);
    Transaction? GetTransactionById(int id);
    
    bool TransactionExists(int id);
    List<Transaction> GetAllTransactions();
    
}