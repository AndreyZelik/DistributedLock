using Medallion.Threading.Internal;
using System.Threading;
using System.Threading.Tasks;

namespace Medallion.Threading.Data
{
    /// <summary>
    /// There are several strategies for implementing SQL-based locks; this interface
    /// abstracts between them to keep the implementation of <see cref="SqlDistributedLock"/> manageable
    /// </summary>
    internal interface IInternalSqlDistributedLock
    {
        // the contextHandle argument to these methods is used when acquiring a nested lock, such as upgrading
        // from an upgradeable read lock to a write lock. This allows the implementation to use the same connection
        // for the nested lock

        bool IsReentrant { get; }

        ValueTask<IDistributedLockHandle?> TryAcquireAsync<TLockCookie>(TimeoutValue timeout, ISqlSynchronizationStrategy<TLockCookie> strategy, CancellationToken cancellationToken, IDistributedLockHandle? contextHandle)
            where TLockCookie : class;
    }
}
