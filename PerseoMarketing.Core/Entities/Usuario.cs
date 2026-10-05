using System;
using System.Collections.Generic;
using System.Text;



namespace PerseoMarketing.Core.Entities;

public enum TipoPerfil
{
    Personal,
    Gestor
}

public class Usuario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public TipoPerfil Perfil { get; set; } = TipoPerfil.Personal;

    // Relación para el perfil Gestor (Un gestor administra varios clientes)
    public ICollection<Cliente> ClientesAdministrados { get; set; } = new List<Cliente>();
}
