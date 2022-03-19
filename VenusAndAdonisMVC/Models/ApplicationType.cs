using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VenusAndAdonisMVC.Models
{
    public class ApplicationType
    {
        [Key] //dodaje Id jako klucz inkrementowany w bazie danych
        public int Id { get; set; }

        //uzywane prop i dwa taby

        public string Name { get; set; }
    }
}
