using System.ComponentModel.DataAnnotations.Schema;

namespace EducationOn.Model
{
    public class Lecture
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string LectureName
        {
            get; set;
        }
        public string FacultyName { get; set; }
        public string time { get; set; }
        public string Description { get; set; }
        public string image { get; set; }

    }
}
