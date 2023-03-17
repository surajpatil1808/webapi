using System.ComponentModel.DataAnnotations.Schema;

namespace EducationOn.Model
{
    public class Studentdashboard
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Id { get; set; }
        public string? Name { get; set; }

   
        public int Roll { get; set; }
        public int Class { get; set; }

        public string? Section { get; set; }
        public int Year { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? Guardian { get; set; }

        public string? Image { get; set; }
    }
}
