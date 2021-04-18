using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PointOfSalesV2.Entities
{
    public class FileAttachment : CommonData
    {
        [MaxLength(200)]
        public string FilePath { get; set; }
        [MaxLength(100)]
        public string FileName { get; set; }


    }

    public class CheckupAttachment : CommonData
    {
        public long PatientChekupId { get; set; }
        public long FileAttachementId { get; set; }
        [ForeignKey("FileAttachementId")]
        public FileAttachment FileAttachment { get; set; }

        [ForeignKey("PatientChekupId")]
        public PatientCheckup PatientCheckup { get; set; }



    }
}
