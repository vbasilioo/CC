   M S B A M L   `   `   `  ����=  9CC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CC.UserControlsCC.UserControls  5          CC.UserControls.Perfil   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:CC.UserControls     5      $
��1335��5   #   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��* �6   .+�5   
   �� $��1��6    �� Padding$ 20q�6!   ���#eff2f7 �� CornerRadius$ 	0 25 25 0��6C    J� RenderTransformOrigin$ 0.348,0.519&�6\   ._�5      � .+�5      �� $��Informações do Usuário��6   $��Center=�6;   $��35(�6X   $��
0,28,0,522q�6f   $��50��6z   
�������$��Poppins)�6�   $��SemiBold"�6�   �� 5      $
��Nome��6   $��458,171,412,0q�6(      text#��[  6?   $	��Top=�6]   
�������6u   �� 5      $��Email��6   $��458,234,412,0q�6)   #��[  6@   $	��Top=�6^   
�������6v   �� 5      -   5         ��Name$ txtEmail��5      $��458,260,412,0q�6-   $	��Top=�6D   
�������$��40��6o   $��15(�6{   �� 5      -   5        $ txtNome��5      $��458,197,412,0q�6,   $	��Top=�6C   
�������$��40��6n   $��15(�6z    �� 
IsReadOnly$
 True��6�   �� 5      -   5        $ txtCargo��5      $��458,0,412,0q�6-   
�������$��40��6U   $��15(�6a   $
 True��6o   �� 5      -   5        $��Salvar��5        buttonMainGreen#��[ 6+   ���	#FFF18047$
��Left=�6l   $��60��6�   $	��238��6�   $��410,696,0,54q�6�   6�   �� 5      -   5        $��Trocar Senha��5      $��60��60   $��719,696,338,54q�6<     
buttonMain#��[ 6T   $	��238��6x   6�   �� 5      -   5        $ txtEndereco��5      $��458,323,412,0q�60   $	��Top=�6G   
�������$��35��6r   $��15(�6~   �� 5      $��Enderço��6   $��458,297,412,0q�6+   #��[  6B   $	��Top=�6`   
�������6x   �� 5      $��Cargo��6   $��458,362,412,0q�6)   #��[  6@   $	��Top=�6^   
�������6v   �� 5       $��Data de Nascimento��6   $��458,427,412,0q�66   #��[  6M   $	��Top=�6k   
�������6�   (  "System.Windows.Controls.DatePicker  5!      -   5          Name$ txtData��5!      $��458,450,412,337q�6/   
������ $ 0.503,0.538&�6b   5$      5&      5)      5+      