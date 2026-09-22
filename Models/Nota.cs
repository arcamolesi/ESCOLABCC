
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ESCOLABCC.Models
{
    public class Nota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [ForeignKey("Aluno")]
        public int AlunoId { get; set; }
        
        [Display(Name = "Aluno")]
        public Aluno Aluno { get; set; }

        [Required]
        [ForeignKey("Disciplina")]
        public int DisciplinaId { get; set; }

        [Display(Name = "Disciplina")]
        public Disciplina Disciplina { get; set; }


        [Display(Name = "Semestre")]
        [Required]
        [Range(1, 2)]
        public int Semestre { get; set; }


        [Display(Name = "Valor")]
        [Required]
        [Range(0, 10)]
        public float Valor { get; set; }
    }

}