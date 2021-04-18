using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PointOfSalesV2.Common;

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
