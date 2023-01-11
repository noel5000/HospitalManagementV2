

namespace PointOfSalesV2.Entities
{
    public class MedicalSpeciality : CommonData
    {
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }

        public virtual List<User> Doctors { get; set; }
        [NotMapped]
        public long OldId { get; set; }
    }
}
