// See https://aka.ms/new-console-template for more information
using GestionTareas;

int opcion = 999;
List<Tareas> listaTareas = new List<Tareas>();
List<Tareas> listaTareasRealizadas = new List<Tareas>();


while (opcion != 0)
{
    Console.WriteLine("### Gestion de Tareas ###");
    Console.WriteLine("1_Ingresar tareas");
    Console.WriteLine("2_Modificar Tarea");
    Console.WriteLine("3_Tarea Realizada");
    Console.WriteLine("4_Mostrar Tareas");
    Console.WriteLine("0_Finalizar Sistema de Gestion");
    Console.WriteLine("Ingresar Opcion: ");
    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingresar Tarea: ");
            string descripcionTarea;
            int tiempo;
            Console.WriteLine("Ingresar la descripcion de la tarea");
            descripcionTarea = Console.ReadLine();
            Console.WriteLine("Ingresar el timepo de duracion de la tarea: ");
            int.TryParse(Console.ReadLine(), out tiempo);
            listaTareas.Add(new Tareas(descripcionTarea, tiempo));
            break;
        
    }
}
