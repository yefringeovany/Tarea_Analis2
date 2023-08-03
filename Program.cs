public class Program {
    public static void Main (string [] args ) {
        int opcion;
        bool salir = false;
        interfaz principal = new Controlador();

        while (!salir)
        {
            Console.WriteLine("-------------------------------Menú------------------------------------------");
            Console.WriteLine("                          1. Crear                                           ");
            Console.WriteLine("                          2. Eliminar                                        ");
            Console.WriteLine("                          3. Actualizar                                      ");
            Console.WriteLine("                          4. Ver                                             ");
            Console.WriteLine("                          5. Salir                                           ");
            Console.Write    ("              Ingrese el número de la opción que desea:                      ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                if (opcion == 1)
                {
                    Console.WriteLine("Opción: Crear");
                    Console.WriteLine("Ingresa Nombre de la tarea: ");
                    string Nombre =Console.ReadLine();
                    Console.WriteLine("Ingresa la fecha de la tarea: ");
                    string Fecha =Console.ReadLine();
                    Thread addThread = new Thread(() => principal.Agregar(Nombre, Fecha));
                    addThread.Start();
                    addThread.Join();

                    Console.WriteLine("Tarea agregada Correctamente.");
                    // Aquí puedes agregar la lógica para crear
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Opción: Eliminar");
                    Console.Write("Ingrese el ID : ");
                    int id = int.Parse(Console.ReadLine());
                    principal.Borrar(id);
                    Console.WriteLine("Tarea eliminada exitosamente...");
                    // Aquí puedes agregar la lógica para eliminar
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Opción: Actualizar");
                    Console.Write("Ingrese el ID.");
                    int id;
                    id = int.Parse(Console.ReadLine());
                    TAREA actualizarTarea = principal.VerId(id);
                    Console.Write("Nuevo Nombre de la tarea: ");
                        string Nombre;
                        Nombre = Console.ReadLine();
                        Console.Write("Nueva fecha de la tarea: ");
                        string fecha;
                        fecha = Console.ReadLine();

                        Console.Write("¿La tarea está completada? (true/false): ");
                        bool completada;
                        completada = bool.Parse(Console.ReadLine());

                        principal.Modificar(id, Nombre, fecha, completada);
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Opción: Ver");
                    // Aquí puedes agregar la lógica para ver
                    foreach (var task in principal.Mostrar())
                    {
                        Console.WriteLine($"ID: {task.Id}, Descripción: {task.Nombre}, Fecha: {task.Fecha}, Completada: {task.estadoTarea}");
                    }
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("Saliendo del programa...");
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número válido.");
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese un número válido.");
            }

            Console.WriteLine(); // Salto de línea para mejorar la presentación
        }
    }
}
