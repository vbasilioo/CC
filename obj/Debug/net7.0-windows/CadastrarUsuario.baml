   M S B A M L   `   `   `  ����=  9CC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CC.UserControlsCC.UserControls  5   	   -clr-namespace:CC.ControllerCC.Controller  5	   	       CC.CadastrarUsuario   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   &ucclr-namespace:CC.UserControls  5   	   %srcclr-namespace:CC.Controller  5	   	     � Title$  CadastrarUsuario��5   	   $	��850��6"   $
��1000��6/   
������  � WindowStyle$
 None=�6U    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��6.   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��380 �6   �� 5      $��* �6   .+�5   
   �� ���	#FF171D20 �� Padding$ 30q�6(    �� CornerRadius$ 	25 0 0 25��65   ._�5      �� $��Center=�6   .+�5      �� $��Imagens/perfil.png��6   $	��160��64   $	��160��6@   $��0 0 0 0q�6M   �� 5      $��Vamos Começar��6    �� TextAlignment$ Center=�61   $��SemiBold"�6H   $��28(�6^   
�������6l   �� 5      $
��Wrap=�6   $��16(�60   $ Center=�6>   
�������$��	0 20 0 20q�6h   $%��Vai levar apenas alguns minutos��6{   5      5      �� 5   
   -   5        $��1��5      $ 20q�6!   ���#242f34$ 	0 25 25 0��6C   ._�5      � .+�5      � .+�5       �� $��0��6    $��Nome Completo��6-      text#��[  6B   $��188,88,168,0q�6`   $	��Top=�6v   �� 5!      $��Email��6    #��[  6-   $��188,155,170,0q�6K   $	��Top=�6b   �� 5#      $��	Endereço��6    #��[  60   $��186,221,166,0q�6N   $	��Top=�6e   �� 5$      $��Cargo��6    #��[  6-   $��190,285,166,0q�6K   $	��Top=�6b   �� 5%      $��Data de Nascimento��6    #��[  6:   $��188,346,168,0q�6X   $	��Top=�6o   �� 5&      $��Senha��6    #��[  6-   $��190,401,166,0q�6K   $	��Top=�6b   �� 5'      -   5         ��Name$ txtBlockCurso��5'       $��Curso��67   #��[  6D   $��190,469,252,0q�6b   $	��Top=�6y   �� 5)      -   5        	 ��Name$	 txtNome��5)      $
��Left=�6/   $	��257��6J   
�������$��40��6j   $��16(�6v   $��186,115,0,0q�6�   $	��Top=�6�   �� 5*      -   5        $	 txtResidencia��5*      $
��Left=�65   $	��257��6Q   
�������$��40��6q   $��16(�6}   $��186,247,0,0q�6�   $	��Top=�6�   �� 5,      -   5        $	 txtEmail��5,      $
��Left=�60   $	��257��6L   
�������$��40��6l   $��16(�6x   $��186,181,0,0q�6�   $	��Top=�6�   �� 5-      -   5        
 ��Name$
 txtCargo��5-      
���   �$��188,311,137,464q�6D   $��16(�6]   .@�5.      �� .��6'   	Empresa50      �� 51      .��6'   	Candidato53      55      (  "System.Windows.Controls.DatePicker  57      -   5          Name$ txtIdade��57   !   
������ $	��Top=�6M   $��186,372,137,0q�6e   $��16(�6|      SelectedDateFormat$ Short=�6�   �� 59      -   5        $
 txtCurso��59      $��188,498,137,278q�61   $��16(�6J   .@�5:      �� .��6'   '%Analise e Desenvolvimento de Sistemas5<      �� 5=      .��6'   	Eventos5?      �� 5@      .��6'   Gestão Empresarial5B      �� 5C      .��6'   " Gestão da Produção Industrial5E      5F      G� 5H      -	   5         G�Name$ txtSenha��5H   "   $
��Left=�64   $	��255��6O   $��8q�6[   $��1q�6g   $��14(�6{   $��190,425,0,345q�6�     PasswordBoxStyle#��[ 6�   $��40��6�   � 5J      $��1��6   $��8��6+   $��	 0 40 0 0q�68    � RowDefinitions 5K      �� 5L      $��7* �6,   �� 5M      $��3* �6,    5O      �� 5P      $��* �6/   �� 5Q      $��* �6/   .+�5S      �� -
   5        $��Voltar��5S   !   $��31,156,31,10q�62     
buttonMain#��[ 6H    J� RenderTransformOrigin$ 0.343,0.447&�6l   $��1��6�   6�   �� 5T      -   5        $��Salvar��5T   !   $��26,156,26,10q�62     buttonMainGreen#��[ 6H   ���	#FFF18047$��1��6�   $��1��6�   6�   5V      %  Xceed.Wpf.Toolkit.MaskedTextBox  5W      -   5          Name$ txtCNPJ��5W   )   $
��Left=�6:   $	��255��6V   
�������$��40��6w   $��16(�6�   $��188,495,0,0q�6�   $	��Top=�6�     TextBoxCadastro#��[ 6�      Mask$ 00,000,000/0001-00��6�   �� 5X      -   5        $ TxtBlockCNPJ��5X       #��[  66   $��190,469,252,0q�6T   $	��Top=�6k   �� 6�    � Language$ pt-br�6�   $
�CNPJ��6�   6�   5[      �� 5\      -   5         ��Name$ LabelSucesso��5\      $%��Sucesso ao cadastrar o usuario!��6.   
��� � �$	��Top=�6k   $��Center=�6�   $
��Bold"�6�   $��18(�6�   �� 5]      -   5        $ 	LabelErro��5]      $.��(O usuario deve possuir nome e sobrenome.��6+   
���  ��$	��Top=�6o   $��Center=�6�   $
��Bold"�6�   $��18(�6�   �� 5^      -   5        $ LabelErroEmail��5^      $��Este e-mail é inválido.��60   
���  ��$	��Top=�6c   $��Center=�6{   $
��Bold"�6�   $��18(�6�   5_      5b      5e      5f      