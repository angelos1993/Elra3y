using Elra3y.DAL.Model;

namespace Elra3y.DAL.Repositories.Infrastructure
{
    // ReSharper disable once InconsistentNaming
    public class Elra3yContext
    {
        private static Elra3yEntities _instance;

        private Elra3yContext()
        {
        }

        public static Elra3yEntities Instance => _instance ?? (_instance = new Elra3yEntities());
    }
}