using System;

namespace POOD_Ejemplo1
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            #region ObjetosCasa
            Casa objetoCasa1 = new Casa("Nacho","Ramírez", ConsoleColor.Yellow);
            Casa objetoCasa2 = new Casa("Pedro","Leos", ConsoleColor.Blue);
            // objetoCasa2.MostrarDetalles();
            //objetoCasa1.MostrarDetalles();
            #endregion


            //Objeto alumno
            Alumno objetoAlumno3 = new Alumno("Miriam", "Mireles", "Ortiz", "ISIC", 2022);
            Alumno objetoAlumno1 = new Alumno();
           
            //Alumno objetoAlumno3 = new Alumno();
            //Acceder a los miembros de Alumno
            //Instancia
            

            objetoAlumno1.MensajeDeBienvenida();
            objetoAlumno3.MensajeDeBienvenida();
          

            //llamar una propiedad
            objetoAlumno1.CalleAlumno = "Centro";



            Console.ReadKey();
        }
    }
}
