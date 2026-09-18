// ENCABEZADO DEL PROGRAMA

// Muestra en la consola el nombre o número del ejercicio.
Console.WriteLine("EJERCICIO_5");

// Muestra el título que describe lo que realiza el programa.
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");

// Deja una línea en blanco para separar visualmente el encabezado.
Console.WriteLine();

// --------------------------------------------------------------------
// ENTRADAS DE DATOS

double suma = 0;

for (int numero = 1; numero <= 5; numero++)
{
    Console.Write($"Ingrese la calificación {numero}: ");

    double calificacion = Convert.ToDouble(Console.ReadLine());

    suma = suma + calificacion;
}

// --------------------------------------------------------------------
// OPERACIONES

double promedio = suma / 5;

// --------------------------------------------------------------------
// SALIDAS DE DATOS

Console.WriteLine($"El promedio de las cinco calificaciones es: {promedio}");

if (promedio >= 90 && promedio <= 100)
{
    Console.WriteLine("Excelente");
}
else if (promedio >= 80 && promedio < 90)
{
    Console.WriteLine("Alumno Bueno");
}
else if (promedio >= 70 && promedio < 80)
{
    Console.WriteLine("Alumno Regular");
}
else if (promedio >= 60 && promedio < 70)
{
    Console.WriteLine("Requiere Apoyo");
}
else if (promedio >= 10 && promedio < 60)
{
    Console.WriteLine("Alumno Deficiente");
}
else if (promedio >= 0 && promedio < 10)
{
    Console.WriteLine("Baja Definitiva");
}
