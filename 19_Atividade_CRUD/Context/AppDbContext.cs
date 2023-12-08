using Microsoft.EntityFrameworkCore;
using _19_Atividade_CRUD.Models;
using App.Models;

namespace App.Context
{
    public class AppDbContext : DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    //No meu DbSet carregará todos os jogos salvos no banco de dados
    public DbSet<Contato> Contatos {get; set;}
    public DbSet<Categoria> Categorias {get; set;}
    public DbSet<Usuario> Usuarios { get; set;}
    }
}