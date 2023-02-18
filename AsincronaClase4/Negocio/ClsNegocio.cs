using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarea4.entidades;

namespace tarea4.negocio

{
    public class ClsNegocioContador
    {

      public int ContarLetras(EntidadContador entidad)
      {
        return entidad.Texto.Length;
      }  
    }
}