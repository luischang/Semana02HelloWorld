// See https://aka.ms/new-console-template for more information
using Semana02HelloWorld;

Console.WriteLine("Hello, World!");

string curso = "Desarrollo de Ambiente Web";
int edad = 20;
double salario = 10000;

var alumno = "Luis Chang";
var notaFinal = 19.50;

var persona = new Persona();
persona.Dni = 20204040;
persona.Telefono = "317-5200";
persona.NombreCompleto = "Paolo Guerrero";
persona.Estado = true;

var persona2 = new Persona()
{
    Dni = 20205050,
    Telefono = "317-5600",
    NombreCompleto="Gianluca Lapadula",
    Estado = true
};

var persona3 = 
    new Persona(20206060,"Alex Valera","317-7500",false);

var personas = new List<Persona>();
personas.Add(persona);
personas.Add(persona2);
personas.Add(persona3);

//Personas activas
var busqueda = personas.Where(x => x.Estado == true).ToList();

//Busqueda por DNI
var busquedaDNI = personas
                .Where(z=>z.Dni == 20205050).FirstOrDefault();

var busquedaLINQ = (from p in personas
                    where p.Dni == 20205050
                    select p).FirstOrDefault();

Console.WriteLine("Finalizando ejercicio");