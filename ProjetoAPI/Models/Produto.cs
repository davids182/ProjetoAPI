using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Models
{
    public class Produto
    {

        //espelho de campos da tabela Produtos do DB MySql
        public int Id { get; set; }
        public string nome { get; set; }
        public string tamanho { get; set; }
        public string categoria { get; set; }
        public string divisao { get; set; }
        public string descricao { get; set; }
        public int estoque { get; set; }
        public string fornecedor { get; set; }
        public string imagem { get; set; }
        public string usuario_alt { get; set; }
        public DateTime reg_alt { get; set; } = DateTime.Now;

    }
}
