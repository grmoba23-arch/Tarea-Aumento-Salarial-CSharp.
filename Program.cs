using System;

class Program
{
    static void Main()
    {
        string cedula;
        string nombre;
        int tipoEmpleado;
        double horas;
        double precioHora;
        double salarioOrdinario;
        double aumento;
        double salarioBruto;
        double deduccion;
        double salarioNeto;
        string continuar;

        do
        {
            Console.WriteLine("CALCULO DE SALARIO");

            Console.Write("Digite la cedula: ");
            cedula = Console.ReadLine();

            Console.Write("Digite el nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Tipo de empleado:");
            Console.WriteLine("1. Operario");
            Console.WriteLine("2. Tecnico");
            Console.WriteLine("3. Profesional");

            Console.Write("Digite el tipo de empleado: ");
            tipoEmpleado = int.Parse(Console.ReadLine());

            Console.Write("Digite las horas trabajadas: ");
            horas = double.Parse(Console.ReadLine());

            Console.Write("Digite el precio por hora: ");
            precioHora = double.Parse(Console.ReadLine());

            salarioOrdinario = horas * precioHora;

            if (tipoEmpleado == 1)
            {
                aumento = salarioOrdinario * 0.15;
            }
            else if (tipoEmpleado == 2)
            {
                aumento = salarioOrdinario * 0.10;
            }
            else
            {
                aumento = salarioOrdinario * 0.05;
            }

            salarioBruto = salarioOrdinario + aumento;

            deduccion = salarioBruto * 0.0917;

            salarioNeto = salarioBruto - deduccion;

            Console.WriteLine("");
            Console.WriteLine("RESULTADOS");
            Console.WriteLine("Cedula: " + cedula);
            Console.WriteLine("Nombre Empleado: " + nombre);
            Console.WriteLine("Tipo Empleado: " + tipoEmpleado);
            Console.WriteLine("Salario por Hora: " + precioHora);
            Console.WriteLine("Cantidad de Horas: " + horas);
            Console.WriteLine("Salario Ordinario: " + salarioOrdinario);
            Console.WriteLine("Aumento: " + aumento);
            Console.WriteLine("Salario Bruto: " + salarioBruto);
            Console.WriteLine("Deduccion CCSS: " + deduccion);
            Console.WriteLine("Salario Neto: " + salarioNeto);

            Console.WriteLine("");
            Console.Write("Desea ingresar otro empleado? S/N: ");
            continuar = Console.ReadLine();

        } while (continuar == "S" || continuar == "s");

        Console.WriteLine("Fin del programa");
    }
}
