using NHibernate;
using System;

namespace BLL
{
    public class ServiceTeste : IServiceTeste
    {
        private ISession _session;

        public ServiceTeste(ISession session)
        {
            _session = session;
        }

        public string Action1()
        {
            return _session.CreateSQLQuery("select NOW()")
                .UniqueResult<DateTime>()
                .ToString();
        }

        public string Action2()
        {
            return _session.CreateSQLQuery("select NOW()")
                .UniqueResult<DateTime>()
                .ToString();
        }

        public string Action3()
        {
            return _session.CreateSQLQuery("select NOW()")
                .UniqueResult<DateTime>()
                .ToString();
        }

    }
}
