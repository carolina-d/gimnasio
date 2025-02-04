﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominioBase;
using DominioBase.Clases;
using System.ComponentModel.DataAnnotations.Schema;

namespace DominioComun.Entidades
{
    [Table("Clase")]
    public class Clase: Entidad
    {
        [Required(ErrorMessage = Constante.Mensaje.CampoObligatorio)]
        [Column(TypeName = "varchar"), MaxLength(10)]
        public string Codigo { get; set; }

        [Required(ErrorMessage = Constante.Mensaje.CampoObligatorio)]
        [Column(TypeName = "varchar"), MaxLength(30)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = Constante.Mensaje.CampoObligatorio)]
        [Column(TypeName = "int")]
        public int Precio { get; set; }

        [Column(TypeName = "int")]
        public int Cupo { get; set; }

       

        
        //propiedades de navegacion

       public virtual HorarioClase HorarioClase { get; set; }
        
       public virtual ICollection<DatosSocio> Socios { get; set; }
        
        

    }
}
