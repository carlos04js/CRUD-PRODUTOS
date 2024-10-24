using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_PRODUTOS.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Fabricante é obrigatório")]
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "O campo Avaliação é obrigatório")]
        public int Avaliação { get; set; }

        [Required(ErrorMessage = "O campo Aprovado é obrigatório")]
        public bool Aprovado { get; set; }   
    }
}
