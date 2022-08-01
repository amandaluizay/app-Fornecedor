using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Fornecedor : Entity
    {
        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisar ter entre {2} e {1}", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisar ter entre {2} e {1}", MinimumLength = 11)]
        public string Documento { get; set; }

        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        
       [ DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        // EF relations 
        public IEnumerable<Produto> Produtos { get; set; }
    }

}
