using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Conexion
    {
        public static string Get()
        {
            String Conexion= "Data Source=.;Initial Catalog=MRangelProgramacionNCapas;Persist Security Info=True;User ID=sa;Password=pass@word1";
            return Conexion;
        }
    }
}
