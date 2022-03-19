using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VenusAndAdonisMVC.Models
{
    public class Category
    {
        [Key] //dodaje Id jako klucz inkrementowany w bazie danych
        public int Id { get; set; }

        //uzywane prop i dwa taby
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1 , int.MaxValue, ErrorMessage = "Display Order for category must be grater than 0")]
        [DisplayName("Displays Order")]
        public int DysplayOrder { get; set; }



    }
}
