using System;
using System.Collections.Generic;
using System.Text;

namespace PerseoMarketing.Core.Entities;

public class Cliente
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid GestorId { get; set; }
    public Usuario? Gestor { get; set; }

    public string NombreEmpresa { get; set; } = string.Empty;

    // Ruta donde Selenium guarda las cookies/perfil de Chrome de este cliente específico
    public string ChromeProfilePath { get; set; } = string.Empty;
    public string ChromeProfileName { get; set; } = "Default";

    public ICollection<GrupoFacebook> Grupos { get; set; } = new List<GrupoFacebook>();
    public ICollection<Anuncio> Anuncios { get; set; } = new List<Anuncio>();
}