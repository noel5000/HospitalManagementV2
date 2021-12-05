

namespace PointOfSalesV2.Repository
{
    public class SequenceManagerRepository : Repository<SequenceControl>, ISequenceManagerRepository
    {
        public SequenceManagerRepository(MainDataContext context) : base(context)
        {
        }

        public async Task<string> CreateSequence(Enums.SequenceTypes sequenceCode)
        {
            string result = "";
            var sequence = await _Context.SequencesControl.AsNoTracking().FirstOrDefaultAsync(x => x.Active == true && x.Code == (short)sequenceCode);
            
            if (sequence != null) 
            {
                result = String.Format("{0}{1:00000}", sequence.CodeName , (sequence.NumericControl + 1));
                sequence.NumericControl += 1;
                _Context.SequencesControl.Update(sequence);
              await  _Context.SaveChangesAsync();
            }
            return result;
        }

    }
}
