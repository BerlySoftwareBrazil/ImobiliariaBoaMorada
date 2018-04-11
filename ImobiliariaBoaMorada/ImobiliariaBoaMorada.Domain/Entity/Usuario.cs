using System;
using System.Collections.Generic;
#region Imports
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion
namespace ImobiliariaBoaMorada.Domain.Entity
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public int NivelAcesso { get; set; }
    }
}
