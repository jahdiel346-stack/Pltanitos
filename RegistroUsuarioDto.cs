using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pltanitos
{
    public class RegistroUsuarioDto
    {
        public class RegistroUsuarioDto
        {
            public string CodigoPais { get; set; } = "+51";
            public string Telefono { get; set; }
            public string MetodoVerificacion { get; set; }
            public string Correo { get; set; }
            public string TipoDoc { get; set; }
            public string NumeroDoc { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public bool AceptaTerminos { get; set; }
            public bool AutorizaProspeccion { get; set; }
        }
    }
}