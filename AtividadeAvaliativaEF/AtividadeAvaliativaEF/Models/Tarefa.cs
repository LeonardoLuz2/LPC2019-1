using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeAvaliativaEF.Models
{
    public class Tarefa
    {
        public Tarefa() { }

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Nome { get; set; }

        public int Prioridade { get; set; }

        [Display(Name = "Data limite")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? DataLimite { get; set; }

        [Display(Name = "Percentual de conclusão")]
        [Range(0, 100)]
        public int PercentualConclusao { get; set; }
    }
}
