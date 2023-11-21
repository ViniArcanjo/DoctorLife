using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorLife.DL.Base
{
    public abstract class EntityAuditBase : EntityBase
    {
        [Column("CREATEDBY")]
        public string? CreatedBy { get; set; }

        [Column("CREATEDAT")]
        public DateTime? CreatedAt { get; set; }

        [Column("MODIFIEDBY")]
        public string? ModifiedBy { get; set; }

        [Column("MODIFIEDAT")]
        public DateTime? ModifiedAt { get; set; }
    }
}
