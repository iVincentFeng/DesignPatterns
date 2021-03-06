﻿namespace DesignPatterns.Factory.AbstractFactory.Interfaces
{
    public abstract class DbFactory
    {
        public abstract DbConnection CreateConnection();

        public abstract DbCommand CreateCommand();
    }
}
