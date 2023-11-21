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
            return result;
        }

        public Patient? GetPatientById(long id)
        {
            var result = Get(patient => patient.PatientId == id).FirstOrDefault();
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
