using System;
using System.ComponentModel.DataAnnotations;

namespace AtividadeAvaliativa01.Models
{
    public class Tarefa
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Nome { get; set; }

        public decimal Prioridade { get; set; }

        [Display(Name = "Data limite")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? DataLimite { get; set; }

        [Display(Name = "Percentual de conclusão")]
        [Range(0, 100)]
        public decimal PercentualConclusao { get; set; }
    }
}
