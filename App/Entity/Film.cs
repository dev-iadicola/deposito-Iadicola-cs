namespace FirstProject.App.Entity
{
    public class Film
    {

        public int id { get; private set; }
        public string title { get; set; }
        public string regist { get; set; }
        public int year { get; set; }
        public string genere { get; set; }

        private static int counter = 1;
       
        public Film(string title, string regist, int year, string genere, int id = 0)
        {
            this.id = id == 0 ? counter++ : id; 
            this.title = title;
            this.regist = regist;
            this.year = year;
            this.genere = genere;
        }


        public void Print()
        {
            Console.WriteLine($"id: {this.id} Titolo: {this.title} \nRegista: {this.regist} \nAnno: {this.year} \nGenere: {this.genere}");
        }
    }
}