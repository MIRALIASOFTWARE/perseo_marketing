using System;
using System.Collections.Generic;
using System.Text;

namespace PerseoMarketing.Core.Entities;

public class GrupoFacebook
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid? ClienteId { get; set; }
    public Guid? UsuarioId { get; set; }

    public string Nombre { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public int CantidadMiembros { get; set; }
    public string CategoriaNicho { get; set; } = string.Empty; // Ej: "Emprendedores", "Ventas"
    public bool Activo { get; set; } = true;
}
