using System;

namespace AtletaApi.Dtos;

public class Usuario()
{

    public UsuarioDTO(){ }
    public UsuarioDTO(Usuario obj)
    {
        Id = obj.Id.ToString();
        Nome = obj.Nome;
    }

    public string Id { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;

    public string Email {get; set;} = string.Empty;

    public Usuario GetModel()
    {
        var obj = new Usuario();
        PreencherModel(obj);
        return obj;
    }

    public void PreencherModel(Usuario obj)
    {
        long.TryParse(this.Id, out long id);
        obj.Id = id;
        obj.Nome = this.Nome;
    }
}

