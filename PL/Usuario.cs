using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        static public void Add()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese Datos");
            Console.WriteLine("Ingrese Usuario");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingrese Email");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingrese un Password");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingrese Fecha de Nacimiento");
            usuario.FechaDeNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Sexo");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Ingrese Telefono");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese Celular");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingrese CURP");
            usuario.CURP = Console.ReadLine();

            //ML.Result result = BL.Usuario.Add(usuario);
            ML.Result result = BL.Usuario.AddSP(usuario);

            if (result.Correct)
            {
                Console.WriteLine("Usuario insertado correctamente");
            }
            else
            {
                Console.WriteLine("Ocurrio un error al insertar" + result.ErrorMessage);
            }
            Console.ReadLine();

            BL.Usuario.Add(usuario);
        }

        static public void Update()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el ID del usuario que desea actualizar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese Datos");
            Console.WriteLine("Ingrese Usuario");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingrese Email");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingrese un Password");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingrese Fecha de Nacimiento");
            usuario.FechaDeNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Sexo");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Ingrese Telefono");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese Celular");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingrese CURP");
            usuario.CURP = Console.ReadLine();

            // ML.Result result = BL.Usuario.Update(usuario);
            ML.Result result = BL.Usuario.UpdateSP(usuario);

            if (result.Correct)
            {
                Console.WriteLine("Usuario actualizado correctamente");
            }
            else
            {
                Console.WriteLine("Ocurrio un error al actualizar" + result.ErrorMessage);
            }
            Console.ReadLine();

            BL.Usuario.Update(usuario);
        }

        static public void Delete()
        {
            //ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el ID del usuario que desea eliminar");
            int IdUsuario = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Usuario.Delete(IdUsuario);
            ML.Result result = BL.Usuario.DeleteSP(IdUsuario);

            if (result.Correct)
            {
                Console.WriteLine("Usuario eliminado correctamente");
            }
            else
            {
                Console.WriteLine("Ocurrio un error al eliminar" + result.ErrorMessage);
            }
            Console.ReadLine();

           // BL.Usuario.Delete(usuario);
        }

        static public void GetAll()
        {
           // ML.Result result = BL.Usuario.GetAll();
            ML.Result result = BL.Usuario.GetAllSP();

            foreach (ML.Usuario usuario in result.Objects)
            {
                Console.WriteLine("El IdAlumno del usuario es: " + usuario.IdUsuario);
                Console.WriteLine("El Nombre del usuario es: " + usuario.Nombre);
                Console.WriteLine("El ApellidoPaterno del usuario es: " + usuario.ApellidoPaterno);
                Console.WriteLine("El ApellidoMaterno del usuario es: " + usuario.ApellidoMaterno);
                //Console.WriteLine("El Municipio del usuario es: " + usuario.Municipio);
                Console.WriteLine("---------------------------------------------");
            }
            Console.ReadLine();
        }

        static public void GetById()
        {
            //ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el ID del usuario que desea mostrar");
            int IdUsuario = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Usuario.GetById(IdUsuario);
            ML.Result result = BL.Usuario.GetByIdSP(IdUsuario);

            if (result.Correct)
            {
                ML.Usuario usuario = (ML.Usuario) result.Object;
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("El IdAlumno del usuario es: " + usuario.IdUsuario);
                Console.WriteLine("El usuario es: " + usuario.UserName);
                Console.WriteLine("El Nombre del usuario es: " + usuario.Nombre);
                Console.WriteLine("El Apellido Paterno del usuario es: " + usuario.ApellidoPaterno);
                Console.WriteLine("El Apellido Materno del usuario es: " + usuario.ApellidoMaterno);
                Console.WriteLine("El email del usuario es: " + usuario.Email);
                Console.WriteLine("El password es: " + usuario.Password);
                Console.WriteLine("La fecha de nacimiento es: " + usuario.FechaDeNacimiento);
                Console.WriteLine("El sexo es: " + usuario.Sexo);
                Console.WriteLine("El telefono es: "+usuario.Telefono);
                Console.WriteLine("El celular es: " + usuario.Celular);
                Console.WriteLine("El CURP es: " + usuario.CURP);
                Console.WriteLine("---------------------------------------------");
            }
            else
            {
                Console.WriteLine("Ocurrio un Error"+result.ErrorMessage);
            }
            Console.ReadLine();
           // BL.Usuario.GetById(usuario);
        }

        
    }
}

