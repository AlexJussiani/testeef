using System.ComponentModel.DataAnnotations;
using testeef.Models;

namespace testeef.Models
{
  public class Product
  {
    [Key]
      public int Id { get; set; }

    [Required(ErrorMessage = "Este Campo é obrigatório")]
    [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]
    [MinLength(3, ErrorMessage = "Este campó deve conter entre 3 e 0 caracteres")]

    public string Title {get; set ;}

    [MaxLength(1024, ErrorMessage = "Este campo deve conter entre 3 a 60 caracteres")]
    public string Description {get; set ;}

    //[Required(ErrorMessage = "Este Campo é obrigatório")]
    //[Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
    public string Price {get; set ;}

     [Required(ErrorMessage = "Este Campo é obrigatório")]
     [Range(1, int.MaxValue, ErrorMessage = "Categoria inválida")]
    public int CategoryId {get; set ;}

    public Category Category {get; set ;}
  }
}