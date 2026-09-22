using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ESCOLABCC.Models
{

    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(30)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public float ValorHora { get; set; }

        [Required]
        [ForeignKey("Curso")]
        public int CursoId { get; set; }


       [Display(Name = "Valor")]
        public Curso Curso { get; set; }

        public ICollection<Nota> Notas { get; set; } = new List<Nota>();
    }



}