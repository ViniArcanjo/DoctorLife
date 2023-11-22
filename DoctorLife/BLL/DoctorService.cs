using AutoMapper;
using DoctorLife.BLL.Interface;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;

namespace DoctorLife.BLL
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorService(IDoctorRepository doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
        }
 
        public List<Doctor> GetAll()
        {
            var result = _doctorRepository.GetAllDoctors();
            return result;
        }

        public Doctor? GetById(long id)
        {
            var result = _doctorRepository.GetDoctorById(id);
            return result;
        }

        public Doctor? GetByCrm(string crm)
        {
            var result = _doctorRepository.GetByDoctorCrm(crm);
            return result;
        }

        public Doctor? GetCredentials(string email, string password)
        {
            var result = _doctorRepository.GetDoctorCredentials(email, password);
            return result;
        }
    }
}
