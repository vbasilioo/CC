using CC.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CC
{

    public partial class FecharVaga : Window
    {
        public FecharVaga(string titulo)
        {
            InitializeComponent();

            List<Candidato> candidatos = Candidato.RetornarCandidatosPorCNPJ(Usuario.UsuarioLogado.CNPJEmpresa, titulo);
            listaUsuarios.Items.Clear();

            foreach(Candidato usuario in candidatos)
            {
                listaUsuarios.Items.Add(usuario.NomeCandidato);
            }
        }
    }
}
