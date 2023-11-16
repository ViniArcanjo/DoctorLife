using DoctorLife.DL.Model;

namespace DoctorLife.DAL.Interface
{
    public interface IDoctorRepository
    {
        List<Doctor> GetAllDoctors();
        Doctor GetDoctorById(long id);
        public Task<Doctor> Create(Doctor request);
    }
}
