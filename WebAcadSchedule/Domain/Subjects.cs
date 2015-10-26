using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Cfg;
using System.Reflection;

namespace WebAcadSchedule.Domain
{
    public class Subjects
    {
        public int id;
        public string Name;
        public int SubjectTypeId;

        static ISessionFactory factory;

        static ISession OpenSession()
        {
            if (factory == null)
            {
                Configuration c = new Configuration();
                c.AddAssembly(Assembly.GetCallingAssembly());
                factory = c.BuildSessionFactory();
            }
                return factory.OpenSession();
        }


        static IList<Subjects> LoadSubjects()
        {
            using (ISession session = OpenSession())
            {
                IQuery query = session.CreateQuery(
                "from Subjects as S order by S.Name asc");
                IList<Subjects> allSubjects = query.List<Subjects>();
                return allSubjects;
            }
        }
    

    }
}