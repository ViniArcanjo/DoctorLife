using DoctorLife.DL.Base;

namespace DoctorLife.DL.Model
{
    public class Doctor : EntityAuditBase
    {
        public string Crm { get; set; }
        public string Name { get; set; }
        public string Expertise { get; set; }
        public string? ProfilePicUrl { get; set; }
    }
}
