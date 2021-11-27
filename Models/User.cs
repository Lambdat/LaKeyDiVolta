using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaKeyDiVolta.Models
{
    public class User
    {
        //Nullable è stato disattivato in LaKeyDiVolta.csproj

        //Proprietà
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber{ get; set; }
        public List<Videogame> Videogames { get; set; }
    }
}
