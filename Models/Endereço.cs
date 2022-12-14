using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisar ter entre {2} e {1}", MinimumLength = 2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisar ter entre {2} e {1}", MinimumLength = 2)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        [StringLength(8, ErrorMessage = "O campo {0} precisar ter entre {2} e {1}", MinimumLength = 8)]
        public string CEP { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisar ter entre {2} e {1}", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisar ter entre {2} e {1}", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisar ter entre {2} e {1}", MinimumLength = 2)]
        public string Estado { get; set; }

        // EF relation 
        public Fornecedor Fornecedor { get; set; }

    }

}
