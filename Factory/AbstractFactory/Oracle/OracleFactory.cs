using DesignPatterns.Factory.AbstractFactory.Interfaces;

namespace DesignPatterns.Factory.Oracle.AbstractFactory
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
