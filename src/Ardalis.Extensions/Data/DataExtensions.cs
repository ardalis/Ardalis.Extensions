using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Ardalis.Extensions.Data;

public static partial class DataExtensions
{
  // Source: https://stackoverflow.com/a/18553786
  public static List<T> ToListReadUncommitted<T>(this IQueryable<T> query)
  {
    using (var scope = new TransactionScope(
        TransactionScopeOption.Required,
        new TransactionOptions()
        {
          IsolationLevel = IsolationLevel.ReadUncommitted
        }))
    {
      List<T> toReturn = query.ToList();
      scope.Complete();
      return toReturn;
    }
  }

  // Source: https://stackoverflow.com/a/18553786
  public static int CountReadUncommitted<T>(this IQueryable<T> query)
  {
    using (var scope = new TransactionScope(
        TransactionScopeOption.Required,
        new TransactionOptions()
        {
          IsolationLevel = IsolationLevel.ReadUncommitted
        }))
    {
      int toReturn = query.Count();
      scope.Complete();
      return toReturn;
    }
  }
}
