   M S B A M L   `   `   `  ���� U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf   IHM_CUSTOM_NETFRAMWORK&    IHM_CUSTOM_NETFRAMWORK.P.C_CADRE   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  -     �Name$  
MainWindow�� � Title$ 
MainWindow��$	��740��$
��1280�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������ .���  � ColumnDefinitions �� $	��250 ��� $
��1030 �.+���  �� CornerRadius$ 	10 0 0 10������  �� 
StartPoint$ 0.5,0&� �� EndPoint$ 0.5,1&�.��� 	 � Color$	 #223266��
 � Offset$
 0Q�� $	 #22396b��$
 1Q�._��� .+���  �� Orientation$ 
Horizontal=�$��Center=�$��0 35 0 0q�.+��� $ 10��$��40��$��40������ $	 0,0&�$	 1,2&�.��� $	 #7f7cf1��$
 0Q�� $	 #d3b7ff��$
 1Q�._��� $��TS�����#fff$��22(�$��SemiBold"� �� TextAlignment$ Center=�$��Center=�$��3 0 0 2q��� $��10 0 0 0q�$��Center=�.+��� $��Theo Sonzogni��$��15(�$��0 0 0 5q����#c2cfff�� $��Beta 1.0��$��11(����#7788bf�� $	��0.8��$��20 30q����#46558a�� -    ��Name$ BTN_Home��   menuButtonActive#��[  .���� $ 
Horizontal=�.+�!  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�  menuButtonIcon#��[ �� $��Accueil��  menuButtonText#��[ �� -   $ BTN_Bois��  
menuButton#��[ .���� $ 
Horizontal=�.+�  $ Square=�#��[ �� $
��Bois��#��[ �� -   $ 	BTN_Micro��#��[ .���� $ 
Horizontal=�.+�  $ 
Microphone=�#��[ �� $��Micro��#��[ �� -   $ BTN_Vibrato��#��[ .���� $ 
Horizontal=�.+�  $ 
CodeCommit=�#��[ �� $��Vibrato��#��[ �� -   $ BTN_Commande��#��[ .���� $ 
Horizontal=�.+�  $ 	FileLines=�#��[ �� $��Commande��#��[ �� -   $ BTN_Quitter��#��[ .���� $ 
Horizontal=�.+�  $ PowerOff=�#��[ �� $��Quitter��#��[ �� -   $��1��$ 	0 10 10 0������ $	 1,0&�$	 0,1&�.��� $	 #41518f��$
 0Q�� $	 #2c386c��$
 1Q�._� � -	     �Name$ F_Page��  � NavigationUIVisibility$ Hidden=�