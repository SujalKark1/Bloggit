namespace Bloggit.Interfaces
{
    public interface IDashboardRepository
    {
        public IDictionary<string, object> GetDashboardData();
    }
}
