using DoctorLife.DL.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorLife.DL.Model
{
    public class Doctor : EntityAuditBase
    {
        [Key]
        [Column("DOCTORID")]
        public long DoctorId { get; set; }

        [Column("CRM")]
        public string Crm { get; set; }

        [Column("NM_NAME")]
        public string Name { get; set; }

        [Column("EXPERTISE")]
        public string Expertise { get; set; }

        [Column("PROFILEPICURL")]
        public string? ProfilePicUrl { get; set; }
    }
}
