using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POOD_Ejemplo1
{
    class Casa
    {
        /*
            Miembro de tipo campo (variables): Que almacenara valores 
            correspondientes a la clase en cuestión.         
         */
        #region MiembrosDeTipoCampo
        string nombreDueno,apellidoDueno;
        double metrosCuadrados;
        public  string calle;
        public string colonia;
        public string ciudad;
        public string estado;
        string areasVerdes;
        public const int numeroCasa = 324;
        //Color de la casa
        ConsoleColor colorCasa;
        #endregion

        #region MiembroTipoConstructor
        public Casa(string nombreDueno, string apellidoDueno, ConsoleColor colorCasa) {
            this.nombreDueno = nombreDueno;
            this.apellidoDueno = apellidoDueno;
            this.colorCasa = colorCasa;
        }
        #endregion

        #region MiembrosDeTipoPropiedad
        //propiedades
        //Propiedad para el campo metrosCuadrados
        public double MetrosCuadrados
        {
            get { return metrosCuadrados; }
            set { metrosCuadrados = value; }
        }
        public string NombreDueno
        {
            get { return nombreDueno; }
            set { nombreDueno = value; }
        }
        //Propiedad para apellidoDueno
        //Propiedad GuardarApellidoDueno: Solo escritura
        public string GuardarApellidoDueno
        {            
            set { apellidoDueno = value; }
        }
        //Propiedad LeerApellidoDueno: Solo lectura
        public string LeerApellidoDueno
        {
            get { return apellidoDueno; }
        }
        //Prpiedad para consoloe color
        public ConsoleColor ColorCasa
        {
            get { return colorCasa; }
            set { colorCasa = value; }
        }
        #endregion

        #region MiembrosDeTipoMetodo
        //Métodos
        /*estructura de un metodo:
         * public tipoDato nombreMetodo(params){}
         * Tipo de dato: string, double, int, float...
         * "Tipo de dato" espceial: void
         */
        public void MostrarDetalles() {
            //Impriir detalles
            Console.ForegroundColor = ColorCasa;
            Console.WriteLine("Detalles del prpietario de la Casa");
            Console.WriteLine("Nombre del propitario: {0} {1}", nombreDueno, LeerApellidoDueno);
            Console.WriteLine("\n La casa se ubica en la siguiente dirección");
            Console.WriteLine("Calle: {0}, Colonia: {1}, Ciudad: {2}, Estado: {3}", calle, colonia, ciudad, estado);            
        }
        #endregion        
    }
}
