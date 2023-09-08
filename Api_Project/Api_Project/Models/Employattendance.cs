namespace Api_Project.Models
{
    public class Employattendance
    {
       public int id { get; set; }
        public DateTime atDtate { get; set; }
        public int present { get; set; }
        public int isAbsent { get; set; }
        public int isOffday { get; set; }

    }
}
