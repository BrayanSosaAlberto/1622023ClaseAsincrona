using AsincronaClase4.entidades;
using AsincronaClase4.negocio;

EntidadDelConteo Texto = new EntidadDelConteo ();
ClsNegocioConteo clsNegocioConteo = new ClsNegocioConteo();



  Console.WriteLine("Por favor ingrese su texto:");
  string textoQueIngreso = Console.ReadLine();

  EntidadDelConteo entidad = new EntidadDelConteo();
  entidad.Texto = textoQueIngreso;

  ClsNegocioConteo negocio = new ClsNegocioConteo();
  int LacantidadDeLetras = negocio.ContarLetras(entidad);

  Console.WriteLine ("La cantidad de letras que usted ingreso son: " + LacantidadDeLetras);