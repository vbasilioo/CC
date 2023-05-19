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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CC.UserControls
{
    /// <summary>
    /// Interação lógica para Notificacoes.xam
    /// </summary>
    public partial class Notificacoes : UserControl
    {
        public Notificacoes()
        {
            InitializeComponent(); 
    
            List<Notificacao> notificacoesUsuario = Notificacao.listaNotificacoes
            .Where(u => u.Destinatario.NomeCandidato == Usuario.UsuarioLogado.Nome).ToList();

            GridNotificacoes.ItemsSource = notificacoesUsuario;
        }
    }
}
