//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen2019
{
    using System;
    using System.Collections.Generic;
    
    public partial class AULAS
    {
        public AULAS()
        {
            this.RESERVAS = new HashSet<RESERVAS>();
        }
    
        public string Cod_aula { get; set; }
        public string Descripcion { get; set; }
        public byte[] Foto { get; set; }
        public Nullable<int> Borrado { get; set; }
    
        public virtual ICollection<RESERVAS> RESERVAS { get; set; }
    }
}
