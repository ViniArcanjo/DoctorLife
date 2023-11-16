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
            return result;
        }

        public Doctor GetDoctorById(long id)
        {
            var result = Get(doctor => doctor.DoctorId == id).FirstOrDefault();
            return result;
        }

        public Task<Doctor> Create(Doctor request)
        {
            throw new NotImplementedException();
        }
    }
}
