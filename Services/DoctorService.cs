using Entity6._0Solution.DTO;
using Entity6._0Solution.Models;

namespace Entity6._0Solution.Services
{
    public class DoctorService : IDoctorService

    {
        private readonly MainContext mainContext;

        public DoctorService(MainContext mainC)
        {
            this.mainContext = mainC;
        }

        public IEnumerable<DoctorDTO> GetDoctors()
        {
            using (var context = this.mainContext)
            {
                var doctors = new List<DoctorDTO>();
                foreach (var d in context.Doctor)
                {
                    var doc = new DoctorDTO(d.FirstName, d.LastName, d.Email);
                    doctors.Add(doc);
                }
                return doctors;
             };
        }

        public DoctorDTO PostDoctor(DoctorDTO doctorDTO)
        {
            var doc = new Doctor();
            using (var context = this.mainContext)
            {
                doc.FirstName = doctorDTO.FirstName;
                doc.LastName = doctorDTO.LastName;
                doc.Email = doctorDTO.Email;
                context.Add(doc);
                context.SaveChanges();
            }
            return doctorDTO;
        }

        public DoctorDTO UpdateDoctors(int idDoctor, DoctorDTO dto)
        {
            using (var context = this.mainContext)
            {
                var doctor = context.Doctor.Where(x => x.IdDoctor == idDoctor).First();
                doctor.FirstName = dto.FirstName;
                doctor.LastName = dto.LastName;
                doctor.Email = dto.Email;
                context.SaveChanges();
            };
            return dto;
        }

        public void DeleteDoctor(int idDoctor)
        {
            using (var context = this.mainContext)
            {
                var doctor = context.Doctor.Where(x => x.IdDoctor == idDoctor).First();
                context.Remove(doctor);
                context.SaveChanges();
            };
        }

    }
}
