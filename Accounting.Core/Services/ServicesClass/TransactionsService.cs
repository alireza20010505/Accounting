using Accounting.Core.Services.Interfaces;
using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;

namespace Accounting.Core.Services.ServicesClass;

public class TransactionsService : ITransactionsService
{
    private readonly AccountingContext _context;

    public TransactionsService(AccountingContext context)
    {
        _context = context;
    }

    public long AddTransaction(Transaction transaction)
    {
        _context.Transactions.Add(transaction);
        _context.SaveChanges();
        return transaction.Id;
    }

    public void UpdateTransaction(Transaction transaction)
    {
        _context.Transactions.Update(transaction);
        _context.SaveChanges();
        
    }

    public void DeleteTransaction(long id)
    {
        var transactionId=_context.Transactions.Find(id);
        _context.Transactions.Remove(transactionId);
        _context.SaveChanges();
    }

    public Transaction? GetTransactionById(int id)
    {
        var transaction = _context.Transactions.FirstOrDefault(t => t.Id==id);
        return transaction;
    }

    public bool TransactionExists(int id)
    {
        return _context.Transactions.Any(t => t.Id == id);
    }

    public List<Transaction> GetAllTransactions()
    {
        var transactions = _context.Transactions.ToList();
        return transactions;
    }
}