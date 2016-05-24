namespace DesignPatterns.Factory.SqlServer
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
