public interface interfaz {
    
    void Agregar (string Nombre, string Fecha);
    void Borrar (int id);
    void Modificar(int id, string Nombre, string Fecha, bool estadoTarea );
    List <TAREA> Mostrar();
    TAREA VerId(int id);
}
