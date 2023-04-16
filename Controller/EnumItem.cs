using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerConnect.Controller{
    internal class EnumItem{
        public static string[] Cargos = {"Selecione", "Candidato", "Coordenador", "Empresa" };
        public static string[] GetCargos() { return Cargos; }
        public static string[] StatusVaga = {"Aberta", "Fechada"};
        public static string[] GetStatusVaga() { return StatusVaga; }
    }
}
