using ML;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("¿Que accion desea realizar?");
            Console.WriteLine("1. Insertar un usuario");
            Console.WriteLine("2. Modificar un usuario");
            Console.WriteLine("3. Borrar un usuario");
            Console.WriteLine("4. Mostrar todos los usuarios");
            Console.WriteLine("5. Mostrar un usuario");
            int Opcion = int.Parse(Console.ReadLine());
            switch (Opcion){
                
                case 1:
                      Console.WriteLine("1. Insertar un usuario");
                      PL.Usuario.Add();
;                    break;
                case 2:
                      Console.WriteLine("2. Modificar un usuario");
                      PL.Usuario.Update();
                    break;
                case 3:
                      Console.WriteLine("3. Borrar un usuario");
                    PL.Usuario.Delete();
                    break;
                case 4:
                      Console.WriteLine("4. Mostrar todos de usuarios");
                    PL.Usuario.GetAll();
                    break;
                case 5:
                      Console.WriteLine("5. Mostrar un usuario");
                    PL.Usuario.GetById();
                    break;
            }
            //PL.Usuario.Add();
            //PL.Usuario.Update();
            //PL.Usuario.Delete();
            //PL.Usuario.GetAll();
            //PL.Usuario.GetById();
        }
    }
}