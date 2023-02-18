using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsincronaClase4.entidades;

namespace AsincronaClase4.negocio

{
    public class ClsNegocioConteo 
    {

      public int ContarLetras(EntidadDelConteo entidad)
      {
        return entidad.Texto.Length;
      }  
    }
}