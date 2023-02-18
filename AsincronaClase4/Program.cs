using tarea4.entidades;
using tarea4.negocio;

EntidadContador Texto = new EntidadContador ();
ClsNegocioContador clsNegocioContador = new ClsNegocioContador();



  Console.WriteLine("Ingrese un Texto:");
  string textoIngresado = Console.ReadLine();

  EntidadContador entidad = new EntidadContador();
  entidad.Texto = textoIngresado;

  ClsNegocioContador negocio = new ClsNegocioContador();
  int cantidadLetras = negocio.ContarLetras(entidad);

  Console.WriteLine ("La cantidad de letras ingresadas es: " + cantidadLetras);