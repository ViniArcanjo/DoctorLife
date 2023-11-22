using DoctorLife.DAL.Base;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.Model;

namespace DoctorLife.DAL
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        public PatientRepository(Context context) : base(context) { }
        
        public List<Patient> GetAllPatients()
        {
            var result = GetAll().ToList();

            foreach (var patient in  result)
            {
                patient.Password = string.Empty;
            }

            return result;
        }

        public Patient? GetPatientById(long id)
        {
            var result = Get(patient => patient.PatientId == id).FirstOrDefault();

            if (result != null)
            {
                result.Password = string.Empty;
            }

            return result;
        }

        public Patient? GetPatientByCpf(string cpf)
        {
            var result = Get(patient => patient.Cpf!.ToLower() == cpf).FirstOrDefault();

            if (result != null)
            {
                result.Password = string.Empty;
            }

            return result;
        }

        public Patient? GetPatientCredentials(string email, string password)
        {
            var result = Get(patient => patient.Password == password && patient.Email.ToLower() == email.ToLower()).FirstOrDefault();

            if (result != null)
            {
                result.Password = string.Empty;
            }

            return result;
        }
    }
}
