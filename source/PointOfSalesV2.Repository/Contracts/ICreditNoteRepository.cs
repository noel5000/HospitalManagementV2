

namespace PointOfSalesV2.Repository
{
    public interface ICreditNoteRepository : IBase<CreditNote>
    {
        Task<CreditNote> GetBySequence(string sequence);
    }
}
