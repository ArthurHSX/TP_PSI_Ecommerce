using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Usuario
    {
        #region Propriedades

        public int ID { get; set; }
        public string Nome { get; set; }
        public string NomeUsario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        #endregion

        #region Métodos

        public void ManterCadastro()
        { 
            throw new Exception("Implemmentar método Salvar, Excluir");
        }

        public void BuscarContatos()
        {
            throw new Exception("Implemmentar método de busca");
        }

        #endregion

    }
}
