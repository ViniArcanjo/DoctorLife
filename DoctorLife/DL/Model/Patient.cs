using DoctorLife.DL.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorLife.DL.Model
{
    public class Patient : EntityAuditBase
    {
        [Key]
        [Column("PATIENTID")]
        public long PatientId { get; set; }

        [Column("NM_NAME")]
        public string Name { get; set; }

        [Column("CPF")]
        public string Cpf { get; set; }

        [Column("BIRTHDAY")]
        public DateTime BirthDay { get; set; }

        [Column("PROFILEPICURL")]
        public string? ProfilePicUrl { get; set; }
    }
}
