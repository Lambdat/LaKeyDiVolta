namespace LaKeyDiVolta.Models
{
    public class Videogame
    {
        //Nullable è stato disattivato in LaKeyDiVolta.csproj
        
        //Proprietà
        public int Id { get; set; } //Chiave Primaria
        public string Title { get; set; }
        public string Description { get; set; }
        public string Poster { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Platform { get; set; }
        public double Price { 
            get => Price; 
            set {
                if (ReleaseDate.Year == DateTime.Now.Year)
                {
                    Price += 20;
                }
                else
                    Price = value;
            }
            
        }

        public List<User> Users { get; set; }







    }
}
