/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 17/4/2026
 * Hora: 10:53 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace TallerIujo
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("========Taller 01========");
			
			//1. El dato del usuario 
			
			string registroUsuario = "   ID_222; AndreaArismendi; EVALUCION; 95";
			
			Console.WriteLine(registroUsuario);
			string registroLimpio = registroUsuario.Trim();
			Console.WriteLine(registroLimpio);
			
			string[] partes = registroLimpio.Split(';');
			string id = partes[0].Trim();
			string nombre = partes[1].Trim();
			string tarea = partes[2].Trim();
			string nota = partes[3].Trim();
			
			Console.WriteLine(string.Format("El ID es: {0}, del usuario {1}, con la nota {2}", id,nombre,nota));
			
			
			
			//Flujo en archivos
			string rutaRaiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"DatosIUJO");
			
			if(!Directory.Exists("rutaRaiz"))
			{
				Directory.CreateDirectory("rutaRaiz");
				Console.WriteLine("Creador Directorio correctamente");
			}
			
			string archivoTexto = Path.Combine(rutaRaiz,"notas.txt");
			Console.WriteLine(archivoTexto);
			
			using(StreamWriter sw = new StreamWriter(archivoTexto,true))
			{
				sw.WriteLine(string.Format("  ID: {0}, nota {1}, {yyyy-MM-dd HH:mm}", id, nota, DateTime.Now));
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}