   M S B A M L   `   `   `  ���� b  ^PresentationFramework.Aero2, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes   CC   CC.App   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   YthemeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     �� 	Resources     	topButton �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value  
menuButton  menuButtonIcon.  (MahApps.Metro.IconPacks.PackIconMaterial  campoPesquisar	 ��Name
 J� SnapsToDevicePixels ��Name �� Triggers �� 
TargetName  	addButton �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid ��Name �Name J� Opacity � Points �� Stretch  DataGridStyle15  /System.Windows.Controls.DataGridLengthConverter �� Padding � ColumnDefinitions � RowDefinitions   SelectAllCommand7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name    Column! ��Name" �� CanContentScroll# ��Name$ �� ScrollableHeight% � Maximum& �� Orientation' �� ViewportHeight( �� ViewportSize*) �� #ComputedVerticalScrollBarVisibility* � Value+ �� Mode, �� ScrollableWidth- �� ViewportWidth,. �� %ComputedHorizontalScrollBarVisibility/ ]� 
Conditions0 �� Property1 �� Value  DataGridCellStyle1*  $System.Windows.Controls.DataGridCell  ColumnHeaderGripperStyle  DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader3   -Microsoft.Windows.Themes.DataGridHeaderBorder2   	IsPressed3 J� IsMouseOver4   	IsHovered5   CanUserSort6   IsClickable7   SortDirection8   SortDirection9   SeparatorVisibility:   SeparatorVisibility;   SeparatorBrush<   SeparatorBrush= n�Name 	 DataGridRowStyle2)	  #System.Windows.Controls.DataGridRow?
  9System.Windows.Controls.Primitives.SelectiveScrollingGrid?  9System.Windows.Controls.Primitives.DataGridCellsPresenter> 	  
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter? 	  DetailsVisibility$@ 
  SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientationA   Vertical#B   RowDetailsScrollingConverter:  4System.Windows.Controls.Primitives.DataGridRowHeader
C   Row 
 DataGridRowStyle1  gridEditButton  gridRemoveButtonD �� BasedOn  detailsButton  aproveButton  gridButtonIcon  	titleText  
normalText 
 button  buttonCircle  TextHint  textBox  
mainbutton  ImgCloseE �� ScaleXF �� ScaleY 
 Fechar  
menubutton  
Mainbutton  Secondarybutton  buttonBlack  iconApp  text  TextBoxCadastro   textcadastro ! 	buttonCad " 
buttonMain # buttonMainGreen $ PasswordBoxStyle % TextBoxGest & TextBoxAsso ' PasswordBoxStyle2��%�9  &	        &	 H    &	 �    &	     &	     (�� �    $" DataGridSelectAllButtonStyle��"  )&	 i    &	 �    &	 �    &	 "    7  7  &		 �    &	
 B    &	 �    &	 )    7  &	 �    7  &	 ?    7  &	 �    &	     &	 �    &	 2    &	 �    &	 \     &	 �     &	 �!    &	 i#    &	 D$    &	 %    '�� i&    &	 b(    &	 �)    7  &	 �*    &	 ,    &	 �,    &	 -    &	  3/    &	! �/    &	" �0    &	# >2    7 " &	$ �2    &	% b3    &	& x5    &	' �7    �� " ��.���  � ��
 ���� ��  � �� �#6e7783��  �@�FocusVisualStyle Z� ��  � ��$ 30����  � ��$ 30����  � ��$
 Left=���  � �� �� " ��.R��� #��z��$ 50��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �#dcdcdc�� " ��.���  � ��
 ���� ��  � �� �#6e7783��  �@�FocusVisualStyle Z� ��  � ��$ 45����  � ��$
 15 3q���  � ��$ 18(���  � �� �� " ��.R��� #��z��$ 7��._��� $
��Left=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �#6e7783��  � ��
 ������� "  .���  � ��$ 15����  � ��$ 15����  � ��$ Center=���  � ��$ 	20 2 20 0q��� " ��.���  � �� �#ffffff��  � �� �#b0b9c6��  � ��$ 0q���  � ��$ 14(���  � ��$ 15 10q���  � ��$ Center=���  � ��$
 0 10q���  � �� �� " ��.R��� $	 border��$ 20��#��z��$

 True��$��1q�
�������._��� $ PART_ContentHost��$|�False��$��Hidden=�$��Hidden=� P�  �@J�IsMouseOver$
 True��. ��� $ border�� � �� �#d9d9d9P�  �@J�IsKeyboardFocused$
 True��. ��� $ border�� � �� �#d9d9d9�� " ��.���  � �� �#242f34��  � �� �#ffffff��  �@�FocusVisualStyle Z� ��  � ��$	 150����  � ��$ 35����  � ��$ Right=���  � ��$ 0 20 0 0q���  � ��$ 13(���  � ��$ 1����  � �� �� " ��.R��� #��z��$ 7��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � ��
 � � ���  � �� �#ffffff�� " ��.���  � �� �� " ��.R�� .+��� $ Border��#��� ��$

 True��� $ Arrow��
���   �$��Right=�$��8,8,3,3q�$
 0.15Q� �   ��� ��� ��� ��� $ Uniform=�$��Bottom=� P�  �@J�IsMouseOver$
 True��. ��� $ Border��# � �� � ��P�  � ��$
 True��. ��� $ Border��# � �� � ��P�  � {�$ False��. ��� $ Arrow�� � y�$ 	Collapsed=��� "  .���  � ��
 ���� ��  � �� �#242f34��  � ��$ 0q���   �@ RowDetailsVisibilityMode$ VisibleWhenSelected=���  � ��$
 true����  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled$ False����  �@ AutoGenerateColumns$ False����  �@ HeadersVisibility$ Column=���  � ��$ 0 10 0 0q���  �@ SelectionMode$ Single=���  �@ SelectionUnit$ FullRow=���  �@ CanUserAddRows$ False����  �@ CanUserDeleteRows$ False����  �@ CanUserResizeColumns$ False����  �@ CanUserReorderColumns$ False����  � ��$ 16(���  �@ ColumnWidth$ * ��  �@ GridLinesVisibility$
 None=���  � �� �� "  .R��� #��z��#��z��#��z��# z��$

 True��._��� $ DG_ScrollViewer��$|�false������ " ��.R��  �� $
��Auto ��� $��* ��� $
��Auto � �� $
��Auto ��� $��* ��� $
��Auto �.+��� #��Z $|�false����C� *�� $" DataGridSelectAllButtonStyle��"  +y��� *HeadersVisibility+# Z # Z  �� "  ���� *CellsPanelHorizontalOffset+ �� "    $! PART_ColumnHeadersPresenter��$��1��y��� *HeadersVisibility+# Z  # Z  �� "  �� $!! PART_ScrollContentPresenter��#" z��$��2��$��1���� $# PART_VerticalScrollBar��$��2��#% z$ $& Vertical=�$��1��#( z' #y�z) * �� *VerticalOffset+$+ OneWay=� �� *TemplatedParent+� $��1��$��2�� �� ���� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� $��* �.+��� $# PART_HorizontalScrollBar��$��1��#% z, $& 
Horizontal=�#( z- #y�z. * �� *HorizontalOffset+$+ OneWay=� �� *TemplatedParent+.���� #
 z
  ]� / �� 0 �@��
IsGrouping$
1 true���� "0 �@%�IsVirtualizingWhenGrouping$1 false��./���  � ��$ false���� "  .���  � ��
 ���� ��  � ��$ Center=���  �@�FocusVisualStyle Z� ��  � ��$
 15 0q���  � �� �� "  .R��� #��z��$��0q�$

 True��._��� #
 z
 �� " n�.���  � ��$ 8����  � ��
 ���� ��  �@�Cursor$ SizeWE����  � �� �� " n�.R��� #��z��# z���� "  .���  � ��$ Center=���  � ��
 ���� ��  � �� �#69717d��  � ��$ 
15 0 15 10q���  � �� �� "  .R�� .+�  #��z��#��z��#��z��#2 z��#4 z3 #6 z5 # z��#8 z7 #: z9 #< z; ._��� #��z��$
��True��#
 z
 #��z��n� $= PART_LeftHeaderGripper��$
��Left=�8��  n� $= PART_RightHeaderGripper��$��Right=�8�� �� " 	 .���  � �� �#eff2f7��  �@J�SnapsToDevicePixels$
 true����  �@=�ErrorTemplate Z� ��  �@	 ValidationErrorTemplate �� .R��� 
���  ��$��2,0,0,0q�$��!��$��Center=���  � �� �� " 	 .R��� $	 
DGR_Border��#��z��#��z��#��z��$

 True��._�
   �� $
��Auto ��� $��* � �� $��* ��� $
��Auto �.+�  $��1��#��z> #
 z
   $��1��$��1��#y�z? @ �� *AreRowDetailsFrozen+# ZA # ZB  �� "    $��2��$@ Vertical=�y��� *HeadersVisibility+# ZC # Z  �� "   P�  �@	 	IsNewItem$
 True��. ���  � �� �� *NewItemMargin+ �� "  �� " 	 .���  � ��
 ���� ��  � ��$ 0 4 0 0q���  �@J�SnapsToDevicePixels$
 true����  �@=�ErrorTemplate Z� ��  �@	 ValidationErrorTemplate �� .R��� 
���  ��$��2,0,0,0q�$��!��$��Center=���  � �� �� " 	 .R��� $	 
DGR_Border��$	 0 8q�#��z��$��0q�$ 5��$

 True��._�
   �� $
��Auto ��� $��* � �� $��* ��� $
��Auto �.+�  $��1��#��z> #
 z
   $��1��$��1��#y�z? @ �� *AreRowDetailsFrozen+# ZA # ZB  �� "    $��2��$@ Vertical=�y��� *HeadersVisibility+# ZC # Z  �� "   P�  �@J�IsMouseOver$
 True��. ���  � �� �#F0F8FF��  � ��
 ���� P�  �@	 
IsSelected$
 True��. ���  � �� �#F0F8FF��  � ��
 ���� ]� / �� 0 �@	 
IsSelected$
1 true���� 0 �@��IsSelectionActive$1 false��./���  � ��
 ���� �� " ��.���  � �� �#242f34��  � �� �#242f34��  � ��
 �������  �@�FocusVisualStyle Z� ��  � ��$ Center=���  � �� �� " ��.R��� #��z��$ 5��$ 5q�$��1q�#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �#242f34�� " ��8D   .���  � ��
 �  ����  � ��
 �  �� P�  �@J�IsMouseOver$
 True��. ���  � ��
 �  ���� " ��8D   .���  � �� �#242f34��  � �� �#242f34 P�  �@J�IsMouseOver$
 True��. ���  � �� �#242f34�� " ��8D   .���  � ��
 � � ���  � ��
 � � � P�  �@J�IsMouseOver$
 True��. ���  � ��
 � � ��� "  .���  � ��$ 12����  � ��$ 12����  � ��$ Center=��� " ��.���  � ��$ 36(���  � ��$
 Bold"���  �@��TextAlignment$ Center=���  � �� �#ffff�� " ��.���  � ��$ 16(���  �@��
LineHeight$ 28����  � ��$
 Wrap=���  �@��TextAlignment$ Center=���  � �� �#ffff�� " ��.���  � ��$ 14(���  � ��$	 170����  � ��
 ���� ��  � �� �#fdfefe��  �@�FocusVisualStyle Z� ��  � �� �� " ��.R��� #��z��$ 25��$��1q�
�������$ 15q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �#e8e8e8��  � ��
 �iii�P�  �@J�IsMouseCaptured$
 True��. ���  � �� �#d9d9d9��  � ��
 �iii��� " ��.���  � ��
 ���� ��  �@�FocusVisualStyle Z� ��  � ��$	 8 0q���  � �� �� " ��.R��� #��z��$ 30��$��1q����#f18047$ 15q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �#d9d9d9P�  �@J�IsMouseCaptured$
 True��. ���  � �� �#c4c4c4�� " ��.���  � ��$ 14(���  � ��$ 1����  � ��$ 10 0 0 0q���  �@K�ZIndex$ 1����  � �� �#acb0af�� " ��.���  � ��$ 14(���  � ��$ 1����  � ��$ 10 0 0 0q���  � ��
 �   ���  � ��
 ���� ��  � ��$ 0q��� " ��.���  � ��$ 14(���  � ��$	 150����  � ��$ 0 20 0 0q���  � �� �#f18047��  � �� �#FDFEFE��  �@�FocusVisualStyle Z� ��  � �� �� " ��.R��� #��z��$ 25��$��1q����#f18047$ 15q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �#f18047��  � ��
 �����P�  �@J�IsMouseCaptured$
 True��. ���  � �� �#f18047��  � ��
 ������� " ��.���  � ��$ 30����  � ��$ 30����  � ��$	 Top=���  � ��$ Right=���  � ��$ 	0 13 13 0q� P�  �@J�IsMouseOver$
 True��. ���  � z� �� $	E 1.1Q�$	F 1.1Q��� " ��.���  � ��
 ���� ��  � ��
 ���� ��  � ��
 �   ���  � ��$ 5q���  � ��$ 12(���  � �� �� " ��.R��� #��z��#��z��#��z��._��� $��Center=�$��Center=��� " ��.���  � ��
 ���� ��  � �� �#88878e��  � ��$ 30����  � ��$ 30����  � ��$ 5 0 0 0q���  �@�FocusVisualStyle Z� ��  � �� �� " ��.R��� #��z��$ 50��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �#efefef�� " ��.���  � ��
 ���� ��  � �� �#242f34��  � ��$ 1q���  � �� �#e1e6eb��  � ��$ 16(���  � ��$
 10 8q���  � ��$ Center=���  � �� �� " ��.R��� $	 border��$ 5��#��z��#��z��#��z��$

 True��._��� $ PART_ContentHost��$|�False��$��Hidden=�$��Hidden=� P�  �@J�IsMouseOver$
 True��. ��� $ border�� � �� �#242f34P�  �@J�	IsFocused$
 True��. ��� $ border�� � �� �#242f34�� " ��.���  � �� �#f18047��  � �� �#ffffff��  � ��$	 180����  � ��$ 40����  �@�FocusVisualStyle Z� ��  � ��$ 16(���  � ��$ Light"���  � �� �� " ��.R��� #��z��$ 7��._��� $��Center=�$��Center=�$��0 0 0 1q� P�  �@J�IsMouseOver$
 True��. ���  � �� �#f18047�� " ��8D   .���  � ��
 ���� ��  � �� �#979797��  � �� �� " ��.R��� #��z��$ 7��$	��0.8q����#b9b9b9._��� $��Center=�$��Center=�$��0 0 0 1q� P�  �@J�IsMouseOver$
 True��. ���  � �� �#d0d0d0��  � �� �#ffffff�� " ��.���  � ��
 �������  � ��$ 0q���  � ��$ 60����  � ��$ 60����  � ��$ 0 20 0 0q���  � �� �� " ��.R��� #��z��$ 50��$ 5q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � ��
 �   ��� " ��.���  � ��$	 Top=���  � ��$ Right=� P�  �@J�IsMouseOver$
 True��. ���  � z� �� $	E 1.2Q�$	F 1.2Q��� " ��.���  � ��
 �������  � ��$ SemiBold"���  � ��$ 16(���  � ��$ Center=��� " ��.���  � �� �#f5f7f9��  � ��
 �   ���  � ��$ 1q���  � �� �#abadb3��  � ��$ 12(���  � ��$ 10q���  � ��$
 0 10q���  � ��$ Center=���  � �� �� " ��.R��� $	 border��$ 3��#��z��#��z��#��z��$

 True��._��� $ PART_ContentHost��$|�False��$��Hidden=�$��Hidden=� P�  �@J�IsMouseOver$
 True��. ��� $ border�� � �� �#d9d9d9P�  �@J�IsKeyboardFocused$
 True��. ��� $ border�� � �� �#d9d9d9�� " ��.���  � ��
 �������  � ��$ SemiBold"���  � ��$ 16(���  � ��$ Center=��� " ��.���  � �� �#c6c6c6��  � ��$ 0q���  � ��$ 40����  � ��$ 40����  � �� �� " ��.R��� #��z��$ 50��$ 5q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �#363636P�  �@J�IsMouseCaptured$
 True��. ���  � �� �#161616�� " ��.���  � �� �#363636��  � ��$ 0q���  � ��$ 50����  � ��$ 16(���  � ��$ SemiBold"���  � �� �� " ��.R��� #��z��$ 5��$ 5q�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �#c9c9c9��  � �� �#161616�� " ��8D   .���  � �� �#5fe7c4��  � �� �#ffff P�  �@J�IsMouseOver$
 True��. ���  � �� �#5fe7c4��  � �� �#ffff�� " G�.���  � �� �� " G�.R��� #��z�����#abadb3#��z��$ 5��._��� $ PART_ContentHost��#
 z
 �� " ��.���  � �� �#eff2f7��  � ��
 �   ���  � ��$ 1q���  � �� �#e1e6eb��  � ��$ 13(���  � ��$ 7q���  � ��$
 0 20q���  � ��$ Center=���  � �� �� " ��.R��� $	 border��$ 3��#��z��#��z��#��z��$

 True��._��� $ PART_ContentHost��$|�False��$��Hidden=�$��Hidden=� P�  �@J�IsMouseOver$
 True��. ��� $ border�� � �� �#d9d9d9P�  �@J�IsKeyboardFocused$
 True��. ��� $ border�� � �� �#d9d9d9�� " ��.���  � ��
 �������  � ��
 �   ���  � ��$ 1q���  � �� �#e1e6eb��  � ��$ 13(���  � ��$ 7q���  � ��$
 0 20q���  � ��$ Center=���  � �� �� " ��.R��� $	 border��$ 3��#��z��#��z��#��z��$

 True��._��� $ PART_ContentHost��$|�False��$��Hidden=�$��Hidden=� P�  �@J�IsMouseOver$
 True��. ��� $ border�� � �� �#d9d9d9P�  �@J�IsKeyboardFocused$
 True��. ��� $ border�� � �� �#d9d9d9�� " G�.���  � �� �� " G�.R��� #��z�����#e1e6eb#��z��$ 5��._��� $ PART_ContentHost��#
 z
 