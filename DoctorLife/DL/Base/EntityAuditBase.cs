namespace DoctorLife.DL.Base
{
    public abstract class EntityAuditBase : EntityBase
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
