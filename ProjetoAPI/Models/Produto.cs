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
        private readonly string iDnum = "123";
        //espelho de campos da tabela Produtos do DB MySql
       
        [Column("id")]
        public int Id { get; set; }

        [MaxLength(45, ErrorMessage = "Tamanho Máximo 45 Caracteres")]
        [MinLength(3, ErrorMessage = "Tamanho Mínimo 3 carateres")]
        [Column("nome", TypeName = "varchar")]
        public string Nome { get; set; }
        
        [MaxLength(3, ErrorMessage = "Tamanho Máximo 3 Caracteres")]
        [MinLength(1, ErrorMessage = "Tamanho Mínimo 1 carateres")]
        [Column("tamanho", TypeName = "varchar")]
        public string Tamanho { get; set; }

        [MaxLength(45, ErrorMessage = "Tamanho Máximo 45 Caracteres")]
        [MinLength(3, ErrorMessage = "Tamanho Mínimo 3 carateres")]
        [Column("categoria", TypeName = "varchar")]
        public string Categoria { get; set; }

        [MaxLength(16, ErrorMessage = "Tamanho Máximo 16 Caracteres")]
        [MinLength(3, ErrorMessage = "Tamanho Mínimo 3 carateres")]
        [Column("divisao", TypeName = "varchar")]
        public string Divisao { get; set; }

        [MaxLength(250, ErrorMessage = "Tamanho Máximo 250 Caracteres")]
        [MinLength(3, ErrorMessage = "Tamanho Mínimo 3 carateres")]
        [Column("descricao", TypeName = "varchar")]
        public string Descricao { get; set; }

        [Column("estoque", TypeName = "integer")]
        public int Estoque { get; set; }

        [MaxLength(45, ErrorMessage ="Tamanho Máximo 45 Caracteres")]
        [MinLength(3, ErrorMessage ="Tamanho Mínimo 3 carateres")]
        [Column("fornecedor", TypeName = "varchar")]
        public string Fornecedor { get; set; }

        [MaxLength(300, ErrorMessage = "Tamanho Máximo 300 Caracteres")]
        [Column("imagem", TypeName = "varchar")]
        public string Imagem { get; set; }

        [MaxLength(45, ErrorMessage = "Tamanho Máximo 45 Caracteres")]
        [MinLength(3, ErrorMessage = "Tamanho Mínimo 3 carateres")]
        [Column("usuario_alt", TypeName = "varchar")]
        public string Usuario_alt { get; set; }

        [Column("reg_alt")]
        public DateTime Reg_alt { get; set; } = DateTime.Now;

    }
}
