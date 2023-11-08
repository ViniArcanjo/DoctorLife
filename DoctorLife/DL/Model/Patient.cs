using DoctorLife.DL.Base;

namespace DoctorLife.DL.Model
{
    public class Patient : EntityAuditBase
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string? ProfilePicUrl { get; set; }
    }
}
