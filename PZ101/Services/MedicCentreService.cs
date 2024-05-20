using PZ101.Context;

namespace PZ101.Services
{
    public class MedicCentreService
    {
        private MedicCentreContext _context;

        public MedicCentreService()
        {
            _context = new MedicCentreContext();              
        }

        internal async void Add (Pacient pacient)
        {
            _context.Pacients.Add(pacient);
            await _context.SaveChangesAsync();
        }

        internal async void Add2(Doctors doctors)  
        {
            _context.Doctors.Add(doctors);
            await _context.SaveChangesAsync();
        }

        internal IEnumerable<Doctors> GetDoctors () => 
            _context.Doctors.AsEnumerable();

        internal IEnumerable<Pacient> GetPacients () =>
             _context.Pacients.AsEnumerable();

        internal async void UpdateDoctors (Guid IDDoctor, Doctors newData)
        {
            var doctors = await _context.Doctors.FindAsync(IDDoctor);
            if (doctors != null)
            {
                doctors.FIODoctors = newData.FIODoctors;
                doctors.NumberDoctors = newData.NumberDoctors;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdatePacient(Guid IDPacient, Pacient newData)
        {
            var pacients = await _context.Pacients.FindAsync(IDPacient);
            if (pacients != null)
            {
                pacients.FIOPacient = newData.FIOPacient;
                pacients.GenderPacient = newData.GenderPacient;

                await _context.SaveChangesAsync();
            }
        }


        public async Task DeletePacient(Guid IDPacient)
        {
            var pacientToDelete = await _context.Pacients.FindAsync(IDPacient);
            if (pacientToDelete != null)
            {
                _context.Pacients.Remove(pacientToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteDoctors(Guid IDDoctors)
        {
            var doctordToDelete = await _context.Doctors.FindAsync(IDDoctors);
            if (doctordToDelete != null)
            {
                _context.Doctors.Remove(doctordToDelete);
                await _context.SaveChangesAsync();
            }
        }


    }
}
