public class Controlador : interfaz
{
    private List<TAREA> tareas;
    private int Tareaidsiguiente;

    public Controlador()
    {
        tareas = new List<TAREA>();
        Tareaidsiguiente = 1;
    }
    public void Agregar(string Nombre, string Fecha)
    {
        TAREA nuevaTarea = new TAREA
        {
            Id = Tareaidsiguiente,
            Nombre = Nombre,
            Fecha = Fecha,
            estadoTarea = false
        };
        tareas.Add(nuevaTarea);
        Tareaidsiguiente++;
    }
        
    public void Borrar(int id)
    {
        TAREA tareaABorrar = tareas.FirstOrDefault(t => t.Id == id);
        if (tareaABorrar != null)
        {
            tareas.Remove(tareaABorrar);
        }
        else
        {
            Console.WriteLine("La tarea con el ID especificado no pudo ser encontrado.");
        }
    }

    public void Modificar(int id, string Nombre, string Fecha, bool estadoTarea)
    {
        TAREA tareaAModificar = tareas.FirstOrDefault(t => t.Id == id);
        if (tareaAModificar != null)
        {
            tareaAModificar.Nombre = Nombre;
            tareaAModificar.Fecha = Fecha;
            tareaAModificar.estadoTarea = estadoTarea;
        }
        else
        {
            Console.WriteLine("La tarea con el ID especificado no pudo ser encontrado.");
        }
    }

    public List<TAREA> Mostrar()
    {
        return tareas;
    }

    public TAREA VerId(int id)
    {
        return tareas.FirstOrDefault(t => t.Id == id);
    }
}