namespace GestionTareas
{
    class Tareas
    {
        static int cont = 0;
        private int idTarea;
        private string? descripcionTarea;
        private int duracionTarea;


        public int IdTarea { get => idTarea; set => idTarea = value; }
        public string DescripcionTarea { get => descripcionTarea; set => descripcionTarea = value; }
        public int DuracionTarea { get => duracionTarea; set => duracionTarea = value; }
        public Tareas(string? Descripcion, int Duracion)
        {
            IdTarea = cont++;
            DescripcionTarea = Descripcion;
            DuracionTarea = Duracion;
        }
    }
}