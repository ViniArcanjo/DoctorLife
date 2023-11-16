using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorLife.DL.Base
{
    public abstract class EntityBase
    {
        [Column("ISACTIVE")]
        public char IsActive { get; set; }
    }
}
