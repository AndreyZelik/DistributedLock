using Medallion.Threading.Tests.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallion.Threading.Tests.Data
{
    public class SqlReaderWriter_AlternateClientConnectionProviderTest : SqlDistributedReaderWriterLockTestCases<AlternateClientConnectionProvider> { }
    public class SqlReaderWriter_AlternateClientTransactionProviderTest : SqlDistributedReaderWriterLockTestCases<AlternateClientTransactionProvider> { }
    public class SqlReaderWriter_AzureConnectionStringProviderTest : SqlDistributedReaderWriterLockTestCases<AzureConnectionStringProvider> { }
    public class SqlReaderWriter_ConnectionBasedConnectionStringProviderTest : SqlDistributedReaderWriterLockTestCases<ConnectionBasedConnectionStringProvider> { }
    public class SqlReaderWriter_DefaultClientConnectionProviderTest : SqlDistributedReaderWriterLockTestCases<DefaultClientConnectionProvider> { }
    public class SqlReaderWriter_DefaultClientTransactionProviderTest : SqlDistributedReaderWriterLockTestCases<DefaultClientTransactionProvider> { }
    public class SqlReaderWriter_DefaultConnectionStringProviderTest : SqlDistributedReaderWriterLockTestCases<DefaultConnectionStringProvider> { }
    public class SqlReaderWriter_MultiplexedConnectionStringProviderTest : SqlDistributedReaderWriterLockTestCases<MultiplexedConnectionStringProvider> { }
    public class SqlReaderWriter_NoStrategyConnectionStringProviderTest : SqlDistributedReaderWriterLockTestCases<NoStrategyConnectionStringProvider> { }
    public class SqlReaderWriter_TransactionBasedConnectionStringProviderTest : SqlDistributedReaderWriterLockTestCases<TransactionBasedConnectionStringProvider> { }
    public class SqlSemaphore_AlternateClientConnectionProviderTest : SqlDistributedSemaphoreTestCases<AlternateClientConnectionProvider> { }
    public class SqlSemaphore_AlternateClientTransactionProviderTest : SqlDistributedSemaphoreTestCases<AlternateClientTransactionProvider> { }
    public class SqlSemaphore_AzureConnectionStringProviderTest : SqlDistributedSemaphoreTestCases<AzureConnectionStringProvider> { }
    public class SqlSemaphore_ConnectionBasedConnectionStringProviderTest : SqlDistributedSemaphoreTestCases<ConnectionBasedConnectionStringProvider> { }
    public class SqlSemaphore_DefaultClientConnectionProviderTest : SqlDistributedSemaphoreTestCases<DefaultClientConnectionProvider> { }
    public class SqlSemaphore_DefaultClientTransactionProviderTest : SqlDistributedSemaphoreTestCases<DefaultClientTransactionProvider> { }
    public class SqlSemaphore_DefaultConnectionStringProviderTest : SqlDistributedSemaphoreTestCases<DefaultConnectionStringProvider> { }
    public class SqlSemaphore_MultiplexedConnectionStringProviderTest : SqlDistributedSemaphoreTestCases<MultiplexedConnectionStringProvider> { }
    public class SqlSemaphore_NoStrategyConnectionStringProviderTest : SqlDistributedSemaphoreTestCases<NoStrategyConnectionStringProvider> { }
    public class SqlSemaphore_TransactionBasedConnectionStringProviderTest : SqlDistributedSemaphoreTestCases<TransactionBasedConnectionStringProvider> { }
    public class SqlSemaphoreSelfDeadlock_AlternateClientConnectionProviderTest : SqlDistributedSemaphoreSelfDeadlockTestCases<AlternateClientConnectionProvider> { }
    public class SqlSemaphoreSelfDeadlock_AlternateClientTransactionProviderTest : SqlDistributedSemaphoreSelfDeadlockTestCases<AlternateClientTransactionProvider> { }
    public class SqlSemaphoreSelfDeadlock_DefaultClientConnectionProviderTest : SqlDistributedSemaphoreSelfDeadlockTestCases<DefaultClientConnectionProvider> { }
    public class SqlSemaphoreSelfDeadlock_DefaultClientTransactionProviderTest : SqlDistributedSemaphoreSelfDeadlockTestCases<DefaultClientTransactionProvider> { }
}

namespace Medallion.Threading.Tests.SqlServer
{
    public class AzureConnectionStrategy_SqlEngineFactoryTest : AzureConnectionStrategyTestCases<TestingSqlDistributedLockEngineFactory> { }
    public class AzureConnectionStrategy_SqlReaderWriterEngineFactoryTest : AzureConnectionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory> { }
    public class AzureConnectionStrategy_SqlSemaphoreEngineFactoryTest : AzureConnectionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory> { }
    public class ConnectionStringStrategy_SqlEngineFactory_AzureConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedLockEngineFactory, AzureConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlEngineFactory_ConnectionBasedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedLockEngineFactory, ConnectionBasedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlEngineFactory_DefaultConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedLockEngineFactory, DefaultConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlEngineFactory_MultiplexedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedLockEngineFactory, MultiplexedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlEngineFactory_NoStrategyConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedLockEngineFactory, NoStrategyConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlEngineFactory_TransactionBasedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedLockEngineFactory, TransactionBasedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlReaderWriterEngineFactory_AzureConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, AzureConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlReaderWriterEngineFactory_ConnectionBasedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, ConnectionBasedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlReaderWriterEngineFactory_DefaultConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, DefaultConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlReaderWriterEngineFactory_MultiplexedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, MultiplexedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlReaderWriterEngineFactory_NoStrategyConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, NoStrategyConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlReaderWriterEngineFactory_TransactionBasedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, TransactionBasedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlSemaphoreEngineFactory_AzureConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, AzureConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlSemaphoreEngineFactory_ConnectionBasedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, ConnectionBasedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlSemaphoreEngineFactory_DefaultConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, DefaultConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlSemaphoreEngineFactory_MultiplexedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, MultiplexedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlSemaphoreEngineFactory_NoStrategyConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, NoStrategyConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlSemaphoreEngineFactory_TransactionBasedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, TransactionBasedConnectionStringProvider> { }
    public class Core_MostlyDrainedSqlSemaphoreEngineTest : DistributedLockCoreTestCases<TestingMostlyDrainedSqlSemaphoreDistributedLockEngine> { }
    public class Core_SqlEngine_AlternateClientConnectionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<AlternateClientConnectionProvider>> { }
    public class Core_SqlEngine_AlternateClientTransactionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<AlternateClientTransactionProvider>> { }
    public class Core_SqlEngine_AzureConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<AzureConnectionStringProvider>> { }
    public class Core_SqlEngine_ConnectionBasedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<ConnectionBasedConnectionStringProvider>> { }
    public class Core_SqlEngine_DefaultClientConnectionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<DefaultClientConnectionProvider>> { }
    public class Core_SqlEngine_DefaultClientTransactionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<DefaultClientTransactionProvider>> { }
    public class Core_SqlEngine_DefaultConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<DefaultConnectionStringProvider>> { }
    public class Core_SqlEngine_MultiplexedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<MultiplexedConnectionStringProvider>> { }
    public class Core_SqlEngine_NoStrategyConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<NoStrategyConnectionStringProvider>> { }
    public class Core_SqlEngine_TransactionBasedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<TransactionBasedConnectionStringProvider>> { }
    public class Core_SqlReaderWriterEngine_AlternateClientConnectionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<AlternateClientConnectionProvider>> { }
    public class Core_SqlReaderWriterEngine_AlternateClientTransactionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<AlternateClientTransactionProvider>> { }
    public class Core_SqlReaderWriterEngine_AzureConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<AzureConnectionStringProvider>> { }
    public class Core_SqlReaderWriterEngine_ConnectionBasedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<ConnectionBasedConnectionStringProvider>> { }
    public class Core_SqlReaderWriterEngine_DefaultClientConnectionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<DefaultClientConnectionProvider>> { }
    public class Core_SqlReaderWriterEngine_DefaultClientTransactionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<DefaultClientTransactionProvider>> { }
    public class Core_SqlReaderWriterEngine_DefaultConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<DefaultConnectionStringProvider>> { }
    public class Core_SqlReaderWriterEngine_MultiplexedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<MultiplexedConnectionStringProvider>> { }
    public class Core_SqlReaderWriterEngine_NoStrategyConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<NoStrategyConnectionStringProvider>> { }
    public class Core_SqlReaderWriterEngine_TransactionBasedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<TransactionBasedConnectionStringProvider>> { }
    public class Core_SqlSemaphoreEngine_AlternateClientConnectionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<AlternateClientConnectionProvider>> { }
    public class Core_SqlSemaphoreEngine_AlternateClientTransactionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<AlternateClientTransactionProvider>> { }
    public class Core_SqlSemaphoreEngine_AzureConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<AzureConnectionStringProvider>> { }
    public class Core_SqlSemaphoreEngine_ConnectionBasedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<ConnectionBasedConnectionStringProvider>> { }
    public class Core_SqlSemaphoreEngine_DefaultClientConnectionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<DefaultClientConnectionProvider>> { }
    public class Core_SqlSemaphoreEngine_DefaultClientTransactionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<DefaultClientTransactionProvider>> { }
    public class Core_SqlSemaphoreEngine_DefaultConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<DefaultConnectionStringProvider>> { }
    public class Core_SqlSemaphoreEngine_MultiplexedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<MultiplexedConnectionStringProvider>> { }
    public class Core_SqlSemaphoreEngine_NoStrategyConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<NoStrategyConnectionStringProvider>> { }
    public class Core_SqlSemaphoreEngine_TransactionBasedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<TransactionBasedConnectionStringProvider>> { }
    public class ExternalConnectionOrTransactionStrategy_SqlEngineFactory_AlternateClientConnectionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedLockEngineFactory, AlternateClientConnectionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlEngineFactory_AlternateClientTransactionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedLockEngineFactory, AlternateClientTransactionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlEngineFactory_DefaultClientConnectionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedLockEngineFactory, DefaultClientConnectionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlEngineFactory_DefaultClientTransactionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedLockEngineFactory, DefaultClientTransactionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlReaderWriterEngineFactory_AlternateClientConnectionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, AlternateClientConnectionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlReaderWriterEngineFactory_AlternateClientTransactionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, AlternateClientTransactionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlReaderWriterEngineFactory_DefaultClientConnectionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, DefaultClientConnectionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlReaderWriterEngineFactory_DefaultClientTransactionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, DefaultClientTransactionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlSemaphoreEngineFactory_AlternateClientConnectionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, AlternateClientConnectionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlSemaphoreEngineFactory_AlternateClientTransactionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, AlternateClientTransactionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlSemaphoreEngineFactory_DefaultClientConnectionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, DefaultClientConnectionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlSemaphoreEngineFactory_DefaultClientTransactionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, DefaultClientTransactionProvider> { }
    public class ExternalConnectionStrategy_SqlEngineFactory_AlternateClientConnectionProviderTest : ExternalConnectionStrategyTestCases<TestingSqlDistributedLockEngineFactory, AlternateClientConnectionProvider> { }
    public class ExternalConnectionStrategy_SqlEngineFactory_DefaultClientConnectionProviderTest : ExternalConnectionStrategyTestCases<TestingSqlDistributedLockEngineFactory, DefaultClientConnectionProvider> { }
    public class ExternalConnectionStrategy_SqlReaderWriterEngineFactory_AlternateClientConnectionProviderTest : ExternalConnectionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, AlternateClientConnectionProvider> { }
    public class ExternalConnectionStrategy_SqlReaderWriterEngineFactory_DefaultClientConnectionProviderTest : ExternalConnectionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, DefaultClientConnectionProvider> { }
    public class ExternalConnectionStrategy_SqlSemaphoreEngineFactory_AlternateClientConnectionProviderTest : ExternalConnectionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, AlternateClientConnectionProvider> { }
    public class ExternalConnectionStrategy_SqlSemaphoreEngineFactory_DefaultClientConnectionProviderTest : ExternalConnectionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, DefaultClientConnectionProvider> { }
    public class ExternalTransactionStrategy_SqlEngineFactory_AlternateClientTransactionProviderTest : ExternalTransactionStrategyTestCases<TestingSqlDistributedLockEngineFactory, AlternateClientTransactionProvider> { }
    public class ExternalTransactionStrategy_SqlEngineFactory_DefaultClientTransactionProviderTest : ExternalTransactionStrategyTestCases<TestingSqlDistributedLockEngineFactory, DefaultClientTransactionProvider> { }
    public class ExternalTransactionStrategy_SqlReaderWriterEngineFactory_AlternateClientTransactionProviderTest : ExternalTransactionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, AlternateClientTransactionProvider> { }
    public class ExternalTransactionStrategy_SqlReaderWriterEngineFactory_DefaultClientTransactionProviderTest : ExternalTransactionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, DefaultClientTransactionProvider> { }
    public class ExternalTransactionStrategy_SqlSemaphoreEngineFactory_AlternateClientTransactionProviderTest : ExternalTransactionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, AlternateClientTransactionProvider> { }
    public class ExternalTransactionStrategy_SqlSemaphoreEngineFactory_DefaultClientTransactionProviderTest : ExternalTransactionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, DefaultClientTransactionProvider> { }
    public class MultiplexingConnectionStrategy_SqlEngineFactoryTest : MultiplexingConnectionStrategyTestCases<TestingSqlDistributedLockEngineFactory> { }
    public class MultiplexingConnectionStrategy_SqlReaderWriterEngineFactoryTest : MultiplexingConnectionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory> { }
    public class MultiplexingConnectionStrategy_SqlSemaphoreEngineFactoryTest : MultiplexingConnectionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory> { }
    public class OwnedTransactionStrategy_SqlEngineFactoryTest : OwnedTransactionStrategyTestCases<TestingSqlDistributedLockEngineFactory> { }
    public class OwnedTransactionStrategy_SqlReaderWriterEngineFactoryTest : OwnedTransactionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory> { }
    public class OwnedTransactionStrategy_SqlSemaphoreEngineFactoryTest : OwnedTransactionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory> { }
}

namespace Medallion.Threading.Tests.WaitHandles
{
    public class Core_EventWaitHandleEngineTest : DistributedLockCoreTestCases<TestingEventWaitHandleDistributedLockEngine> { }
}