﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominioBase.Clases;

namespace DominioComun.Entidades
{
    [Table("Membresia")]
    public class Membresia : DominioBase.Entidad
    {

        [Required(ErrorMessage = Constante.Mensaje.CampoObligatorio)]
        [Column(TypeName = "varchar"), MaxLength(10)]
        public string Codigo { get; set; }

        [Required(ErrorMessage = Constante.Mensaje.CampoObligatorio)]
        [Column(TypeName = "varchar"), MaxLength(30)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = Constante.Mensaje.CampoObligatorio)]
        [Column(TypeName = "varchar"), MaxLength(30)]
        public string Nombre { get; set; }


        //propiedades de Navegacion
        public virtual ICollection<DatosSocio> Socio { get; set; }

    }
}
