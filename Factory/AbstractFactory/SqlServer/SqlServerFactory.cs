using DesignPatterns.Factory.AbstractFactory.Interfaces;

namespace DesignPatterns.Factory.SqlServer.AbstractFactory
{
    public class SqlServerFactory : DbFactory
    {
        public override DbConnection CreateConnection()
        {
            return new SqlServerConnection();
        }

        public override DbCommand CreateCommand()
        {
            return new SqlServerCommand();
        }
    }
}
