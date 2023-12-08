using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _19_Atividade_CRUD.Models
{
//DataAnnotation de como será criado o nome da tabela no BD
[Table("Contatos")]
public class Contato
{
[Key] //Falando para o BD que este atributo será uma chave
public int ContatoId { get; set; }
[Required(ErrorMessage="Nome é obrigatório")]
[MaxLength(200, ErrorMessage = "Número pode exceder {1} caracteres")]
public string Nome { get; set; }
public string Numero { get; set; }
public bool Ativo { get; set; }
public int CategoriaId { get; set; }
public virtual Categoria Categoria { get; set; }
}
}