using System.ComponentModel.DataAnnotations;

namespace PZ101.Context
{
    public class Pacient
    {
        [Key]
        public Guid IDPacient { get; set; }
        public string FIOPacient { get; set; }
        public string GenderPacient { get; set; }
    }
}
