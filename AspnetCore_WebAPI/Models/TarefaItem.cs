
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspnetCore_WebApi.Models
{
    public class TarefaItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Chave { get; set; }
        public string Nome { get; set; }
        public bool EstaComplata { get; set; }
    }
}