   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	    IHM_CUSTOM_NETFRAMWORK&    IHM_CUSTOM_NETFRAMWORK.P.C_CADRE   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5   	   -   5          �Name$  
MainWindow��5
   	    � Title$ 
MainWindow��5	   	   $	��740��5   	   $
��1280��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������ .��5      �  � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $
��1030 �6   .+�5   
   ��  �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� 
StartPoint$ 0.5,0&�6&    �� EndPoint$ 0.5,1&�69   .��5      � 	 � Color$	 #223266��6#   
 � Offset$
 0Q�63   � 5      $	 #22396b��6#   $
 1Q�63   5      ._�5       �� .+�5#      �� $	��0.8��6   $��20 30q�6)   ���#46558a68   �� 5'      -   5         ��Name$ BTN_Home��5'         menuButtonActive#��[  6C   .��5(      ��  �� Orientation$ 
Horizontal=�6!   .+�5)      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6'     menuButtonIcon#��[ 63   �� 5*      $��Accueil��6$     menuButtonText#��[ 63   5+      5,      �� 5.      -   5        $ BTN_Bois��5.        
menuButton#��[ 6B   .��5/      �� $ 
Horizontal=�6!   .+�50        $ Square=�6'   #��[ 65   �� 51      $
��Bois��6$   #��[ 60   52      53      �� 55      -   5        $ 	BTN_Micro��55      #��[ 6D   .��56      �� $ 
Horizontal=�6!   .+�57        $ 
Microphone=�6'   #��[ 69   �� 58      $��Micro��6$   #��[ 61   59      5:      �� 5<      -   5        $ BTN_Vibrato��5<      #��[ 6H   .��5=      �� $ 
Horizontal=�6!   .+�5>        $ 
CodeCommit=�6'   #��[ 69   �� 5?      $��Vibrato��6$   #��[ 63   5@      5A      �� 5C      -   5        $ BTN_Commande��5C      #��[ 6J   .��5D      �� $ 
Horizontal=�6!   .+�5E        $ 	FileLines=�6'   #��[ 68   �� 5F      $��Commande��6$   #��[ 64   5G      5H      �� 5J      -   5        $ BTN_Quitter��5J      #��[ 6H   .��5K      �� $ 
Horizontal=�6!   .+�5L        $ PowerOff=�6'   #��[ 67   �� 5M      $��Quitter��6$   #��[ 63   5N      5O      5Q      5T      �� 5V   
   -   5        $��1��5V      $ 	0 10 10 0��6!   ��5W      �� 5X      $	 1,0&�6&   $	 0,1&�67   .��5Y      � $	 #41518f��6#   $
 0Q�63   � 5Z      $	 #2c386c��6#   $
 1Q�63   5[      ._�5^       � -	   5          �Name$ F_Page��5^        � NavigationUIVisibility$ Hidden=�6$   5a      5c      5d      