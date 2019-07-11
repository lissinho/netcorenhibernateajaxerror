using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace BLL
{
    public class ConfigManager
    {
        public ISessionFactory CreateSessionFactory()
        {
            var cfg = PostgreSQLConfiguration.PostgreSQL82
                             .ConnectionString(c => c.Is("<<<<database_connection_string>>>>"))
                             .ShowSql();

            return Fluently.Configure()
               .Database(cfg)
               //.Mappings(m =>
               //          m.FluentMappings.AddFromAssemblyOf<Entities.Class>())
               .BuildSessionFactory();
        }
    }
}
