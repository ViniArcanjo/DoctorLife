using DoctorLife.DL.Base;
using System.ComponentModel.DataAnnotations;

namespace DoctorLife.DL.Model
{
    public class Doctor : EntityAuditBase
    {
        [Key]
        public long DoctorId { get; set; }

        public string Crm { get; set; }

        public string Name { get; set; }

        public string Expertise { get; set; }

        public string? ProfilePicUrl { get; set; }
    }
}
