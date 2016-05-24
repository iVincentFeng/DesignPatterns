namespace DesignPatterns.Factory.Oracle
{
    public class OracleFactory : DbFactory
    {
        public override DbConnection CreateConnection()
        {
            return new OracleConnection();
        }

        public override DbCommand CreateCommand()
        {
            return new OracleCommand();
        }
    }
}
