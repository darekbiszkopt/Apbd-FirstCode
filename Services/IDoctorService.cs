using Entity6._0Solution.DTO;

namespace Entity6._0Solution.Services
{
    public interface IDoctorService
    {
        public IEnumerable<DoctorDTO> GetDoctors();
        public DoctorDTO PostDoctor(DoctorDTO doctorDTO);
        public DoctorDTO UpdateDoctors(int idDoctor, DoctorDTO dto);
        public void DeleteDoctor(int idDoctor);
    }
}
