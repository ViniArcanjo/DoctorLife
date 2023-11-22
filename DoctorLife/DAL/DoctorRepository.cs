using DoctorLife.DAL.Base;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.Model;

namespace DoctorLife.DAL
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(Context context) : base(context) { }

        public List<Doctor> GetAllDoctors()
        {
            var result = GetAll().ToList();

            foreach (var doctor in result)
            {
                doctor.Password = string.Empty;
            }

            return result;
        }

        public Doctor? GetDoctorById(long id)
        {
            var result = Get(doctor => doctor.DoctorId == id).FirstOrDefault();

            if (result != null)
            {
                result.Password = string.Empty;
            }

            return result;
        }

        public Doctor? GetByDoctorCrm(string crm)
        {
            var result = Get(doctor => doctor.Crm!.ToLower() == crm.ToLower()).FirstOrDefault();

            if (result != null)
            {
                result.Password = string.Empty;
            }

            return result;
        }

        public Doctor? GetDoctorCredentials(string email, string password)
        {
            var result = Get(doctor => doctor.Password == password && doctor.Email.ToLower() == email.ToLower()).FirstOrDefault();

            if (result != null)
            {
                result.Password = string.Empty;
            }

            return result;
        }
    }
}
