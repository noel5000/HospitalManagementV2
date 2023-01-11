

namespace PointOfSalesV2.Entities
{
    public class BranchOffice : CommonData
    {
        [MaxLength(100)]
        [Translate]
        public string Name { get; set; }
        [MaxLength(200)]
        [Translate]
        public string Address { get; set; }
        [MaxLength(50)]
        public string PhoneNumber { get; set; }
        [MaxLength(50)]
        public string NRC { get; set; }
        [MaxLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual IEnumerable<Warehouse> Warehouses { get; set; }

        public virtual IEnumerable<User> Users { get; set; }
        public virtual IEnumerable<CashRegister> CashRegisters { get; set; }


    }
}
