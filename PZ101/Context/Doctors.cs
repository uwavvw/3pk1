using System.ComponentModel.DataAnnotations;

namespace PZ101.Context
{
    public class Doctors
    {
        [Key]
        public Guid IDDoctors { get; set; }
        public string FIODoctors { get; set; }
        public string NumberDoctors { get; set; }
    }
}
