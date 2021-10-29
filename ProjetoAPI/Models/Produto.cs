using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAPI.Models
{
    public class Produto
    {

        //espelho de campos da tabela Produtos do DB MySql
       
        public int Id { get; set; }
       
        [MaxLength(45), MinLength(3)]
        [Column (TypeName ="varchar")]
        public string nome { get; set; }
       
        [MaxLength(3), MinLength(1)]
        [Column(TypeName = "varchar")]
        public string tamanho { get; set; }

        [MaxLength(45), MinLength(3)]
        [Column(TypeName = "varchar")]
        public string categoria { get; set; }

        [MaxLength(16), MinLength(3)]
        [Column(TypeName = "varchar")]
        public string divisao { get; set; }

        [MaxLength(250), MinLength(3)]
        [Column(TypeName = "varchar")]
        public string descricao { get; set; }

        [Column(TypeName = "integer")]
        public int estoque { get; set; }

        [MaxLength(45), MinLength(3)]
        [Column(TypeName = "varchar")]
        public string fornecedor { get; set; }

        [MaxLength(300)]
        [Column(TypeName = "varchar")]
        public string imagem { get; set; }

        [MaxLength(45), MinLength(3)]
        [Column(TypeName = "varchar")]
        public string usuario_alt { get; set; }

        public DateTime reg_alt { get; set; } = DateTime.Now;

    }
}
