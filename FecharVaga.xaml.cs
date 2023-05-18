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

            List<Candidato> candidatos = Candidato.RetornarCandidatosPorTitulo(titulo);
            listaCandidatos.DataContext = new { Candidatos = candidatos };
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBlock textBlock && textBlock.DataContext is Candidato candidato)
            {
                string mensagem = $"Nome: {candidato.NomeCandidato}\n" +
                                  $"Telefone: {candidato.Telefone}\n" +
                                  $"Comentários: {candidato.Comentarios}";

                MessageBox.Show(mensagem);
            }
        }
    }
}
