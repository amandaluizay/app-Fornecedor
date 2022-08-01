using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class WebApplication4.Models 
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage =" O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisar ter entre {2} e {1}", MinimumLength =2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisar ter entre {2} e {1}", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        public string Imagem { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        // EF relation

        public Fornecedor fornecedor { get; set; }
    }
}
