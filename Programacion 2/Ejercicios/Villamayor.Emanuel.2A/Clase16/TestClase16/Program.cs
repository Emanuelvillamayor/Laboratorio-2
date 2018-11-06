using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase16;

namespace TestClase16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Clase 16";
            string texto ;

            //V1
            //string pathEscritorio = @"C:\Users\alumno\Desktop\ArchivoEscritorio.txt";
            //string pathMisDocumentos = @"C:\Users\alumno\Documents\ArchivoDocumentos.txt";
            //string pathMisImagenes = @"C:\Users\alumno\Pictures\ArchivoImagenes.txt";

            //V2
            string pathEscritorio = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\ArchivoEscritorioV2.txt");
            string pathMisDocumentos = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ArchivoDocumentosV2.txt");
            string pathMisImagenes = (Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\ArchuvoImagenesV2.txt");
            string pathBase = (AppDomain.CurrentDomain.BaseDirectory) + @"\ArchivoBase.txt"; //la direccion donde esta el /bin/debug
            //V1
            //if (AdministradorArchivos.Escribir(pathEscritorio, "Guardo en Escritorio"))
            //if(AdministradorArchivos.Escribir(pathMisDocumentos,"Guardo en Documentos"))
            //if(AdministradorArchivos.Escribir(pathMisImagenes,"Guardo en Imagenes"))


            //V2
            if (AdministradorArchivos.Escribir(pathEscritorio, "Guardo en Escritorio V2"))
                {
                Console.WriteLine("Archivo Guardado!");
            }

            if(AdministradorArchivos.Escribir(pathMisDocumentos,"Guardo en Documentos V2"))
            {
                Console.WriteLine("Archivo Guardado!");
            }

             if(AdministradorArchivos.Escribir(pathMisImagenes,"Guardo en Imagenes V2"))
            {
                Console.WriteLine("Archivo Guardado!");
            }

             if(AdministradorArchivos.Escribir(pathBase,"Guardo en el directorio base"))
            {
                Console.WriteLine("Archivo Guardado!");
            }

            if ( AdministradorArchivos.Leer(pathEscritorio, out texto))
            {
                Console.WriteLine(texto);
            }

            if(AdministradorArchivos.Leer(pathBase,out texto))
            {
                Console.WriteLine(texto);
            }

            Console.ReadKey();

        }
    }
}
