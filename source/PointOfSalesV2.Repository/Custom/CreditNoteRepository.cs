

namespace PointOfSalesV2.Repository
{
    public class CreditNoteRepository : Repository<CreditNote>, ICreditNoteRepository
    {
        public CreditNoteRepository(MainDataContext context) : base(context)
        {
        }

        public async Task<CreditNote> GetBySequence(string sequence)
        {
            return await _Context.CreditNotes.AsNoTracking().FirstOrDefaultAsync(x => x.Active == true && x.Sequence == sequence);
        }
    }
}
