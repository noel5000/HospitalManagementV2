

namespace PointOfSalesV2.Repository
{
    public class Repository<T> : Base<T, MainDataContext> where T : class, ICommonData, new()
    {
        public Repository(MainDataContext context) : base(context) { }
    }
}
