

namespace PointOfSalesV2.Entities
{
    public class ExceptionLog : CommonData
    {
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(500)]
        public string Message { get; set; }

        public int Section { get; set; }
        [MaxLength(50)]
        public string SectionName { get; set; }
        [NotMapped]
        public Enums.AppSections SectionEnum 
        {
            get 
            {
                return  (Enums.AppSections)this.Section;
            }
        }


    }
}
