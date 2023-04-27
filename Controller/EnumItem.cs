using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerConnect.Controller{
    public class EnumItem{
        public static string[] Cargos = { "Candidato", "Coordenador", "Empresa", "Administrador" };
        public static string[] GetCargos() { return Cargos; }
        public static string[] StatusVaga = {"Aberta", "Fechada"};
        public static string[] GetStatusVaga() { return StatusVaga; }
    }
}
