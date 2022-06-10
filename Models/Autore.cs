using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca_EntityFramework.Models
{
    [Table("autori")]
    public class Autore
    {
        [Key]
        public long AutoreId { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public ICollection<Libro>? Libri { get; set; }
    }
}
