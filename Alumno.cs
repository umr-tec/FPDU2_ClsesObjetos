using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOD_Ejemplo1
{
    class Alumno
    {
        #region CamposAlumno
        //Campos
        private string matriculaAlumno, nombreAlumno, primerApellidoAlumno, segundoApellidoAlumno;
        private string curpAlumno, carreraAlumno, semestreAlumno;
        private string calleAlumno, coloniaAlumno, ciudadAlumno, estadoAlumno, cpAlumno;
        private string telefonoCelularAlumno, telefonoCasaAlumno, emailAlumno;
        private DateTime fechaNacimientoAlumno, fechaIngresoAlumno;       
        #endregion

        //Miembro Constructor
        public Alumno(string nombreAlumno, string primerApellidoAlumno, 
            string segundoApellidoAlumno,string carreraAlumno, int year) 
        {
            //Asuganr a los campos los valores de cada parametro           
            this.nombreAlumno = nombreAlumno;
            this.primerApellidoAlumno = primerApellidoAlumno;
            this.segundoApellidoAlumno = segundoApellidoAlumno;
            this.carreraAlumno = carreraAlumno;
            this.semestreAlumno = "1";

            //Valor constamte para generar la matricula de manera automatica
            const int numeroTecnologico = 100;
            string folio;
            //Incrementar el contador
            Contador.contador = Contador.contador + 1;
            folio = Contador.contador.ToString();
            if (folio.Length == 1)
            {
                folio = "000" + "" + Contador.contador;
            }
            if (folio.Length == 2)
            {
                folio = "00" + "" + Contador.contador;
            }
            this.matriculaAlumno = year.ToString().Substring(2) + "" + numeroTecnologico + "" + folio;

        }//LLave de cierre del Construvtor

        //Crear un segundo constructor
        //Sobrecarga
        public Alumno() {
            //variables
            int year, month, day;
            //Valor constamte para generar la matricula de manera automatica
            const int numeroTecnologico = 100;
            string folio;
            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Ingresa la matrocula del alumno");
            //this.matriculaAlumno = Console.ReadLine();
            Console.WriteLine("Ingresa el nombre del alumno");
            this.nombreAlumno = Console.ReadLine();
            Console.WriteLine("Ingresa el primer apellido del alumno");
            this.primerApellidoAlumno = Console.ReadLine();
            Console.WriteLine("Ingresa el segundo apellido del alumno");
            this.segundoApellidoAlumno = Console.ReadLine();
            Console.WriteLine("Ingresa la carrera del alumno");
            this.carreraAlumno = Console.ReadLine();
            this.semestreAlumno = "1";
            //Asignar valor al tipo de dato no primitivo DateTime
            Console.WriteLine("Teclea el año de ingreso del alumno, en formato yyyy");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Teclea el mes de ingreso del alumno, en formato mm");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Teclea el día de ingreso del alumno, en formato dd");
            day = Convert.ToInt32(Console.ReadLine());
            //
            fechaIngresoAlumno = new DateTime(year, month, day);
            //Generar valor para matricula automatica
            Contador.contador = Contador.contador + 1;
            folio = Contador.contador.ToString();
            if (folio.Length == 1)
            {
                folio = "000" + "" + Contador.contador;
            }
            if (folio.Length == 2)
            {
                folio = "00" + "" + Contador.contador;
            }
            this.matriculaAlumno = year.ToString().Substring(2) +""+ numeroTecnologico +""+  folio;
        }
        //Propiedades
        public string CalleAlumno
        {
            get { return calleAlumno; }
            set { calleAlumno = value; }
        }       
        //Metodo
        public void MensajeDeBienvenida()
        {
            Console.WriteLine("Bienvenido al Tecnológico de San Pedro");
            Console.WriteLine(" Datos del alumno de nuevo ingreso");
            Console.WriteLine("Matricula del alumno: {0}", matriculaAlumno);
            Console.WriteLine("Nombre del alumno: {0} {1} {2}", nombreAlumno, primerApellidoAlumno, segundoApellidoAlumno);
            Console.WriteLine("Carrera del alumno: {0}", carreraAlumno);
            Console.WriteLine("Fecha de inscripción del alumno: {0}", fechaIngresoAlumno);

            if (carreraAlumno == "Ingeniería en Sistemas Computacionales")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Formar Ingenieros en Sistemas Computacionales, capaces de diseñar, implementar y administrar tecnologías de información y comunicación, aportando soluciones innovadoras basadas en las necesidades de almacenamiento, desarrollo y comunicación de información de la sociedad.");
            }
            if (carreraAlumno == "Ingeniería en Logística")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Formar Ingenieros en Logística emprendedores, analíticos y creativos que mejoren los procesos de los sistemas de producción y comercialización, para brindar un valor agregado en tiempo y lugar, que derive en la posesión de un producto, bien o servicio; reduciendo los obstáculos que se presentan en el ámbito empresarial y del comercio.");
            }
            if (carreraAlumno == "Ingeniería en Gestión Empresarial")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Formar integralmente profesionales que contribuyan a la gestión de empresas e innovación de procesos; así como al diseño, implementación y desarrollo de sistemas estratégicos de negocios, optimizando recursos en un entorno global, con ética y responsabilidad social.");
            }
        }
    }//LLave de cierre de la clase
}
