

namespace PointOfSalesV2.Repository
{
    public interface ISequenceManagerRepository : IBase<SequenceControl>
    {
        Task<string> CreateSequence(Enums.SequenceTypes sequenceCode);
    }
}
