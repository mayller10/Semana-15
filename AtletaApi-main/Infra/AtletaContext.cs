using System;
using AtletaApi.Models;

namespace AtletaApi.Infra;

public class AtletaContext : DbContext
{
    public DbSet<Atleta> Atletas {get; set;}
    public DbSet<Usuario> Usuarios {get; set;}

    public AtletaContext(){
        caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "atleta.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options){
        options.UseSqlite($"Data Source={caminho}");
    }

    private readonly string caminho;
}

public class DbContext
{
}

public class DbSet<T>
{
}

public class DbContextOptionsBuilder
{
    internal void UseSqlite(string v)
    {
        throw new NotImplementedException();
    }
}