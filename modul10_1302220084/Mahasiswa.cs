namespace modul10_1302220084
{
    public class Mahasiswa
    {
        public String name { get;set;}
        public String NIM {  get;set;}
        public List<String> course { get;set;}
        public int year { get;set;}
        public Mahasiswa(String name, String NIM, List<String> course, int year)
        {
            this.name = name;
            this.NIM = NIM;
            this.course = course;
            this.year = year;
        }

    }
}
