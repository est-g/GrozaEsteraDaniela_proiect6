using System.ComponentModel.DataAnnotations;

namespace GrozaEsteraDaniela_proiect6.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "Nume si Prenume")]
        public string Nume_Prenume { get; set; }
        public int Nr_matricol { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataNasterii { get; set; }

    }
}
