   M S B A M L   `   `   `  ����N  JIHM_VRAI_CUSTOM_NET, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:IHM_VRAI_CUSTOM_NETIHM_VRAI_CUSTOM_NET  5   	   =#clr-namespace:IHM_VRAI_CUSTOM_NET.CIHM_VRAI_CUSTOM_NET.C  69   &     IHM_VRAI_CUSTOM_NET.F.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -local!clr-namespace:IHM_VRAI_CUSTOM_NET  5   	   +c#clr-namespace:IHM_VRAI_CUSTOM_NET.C  69     � Title$  
MainWindow��5	   	   $	��740��5
   	   $
��1280��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������ .��5      �  � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $
��1030 �6   .+�5   
   ��  �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� 
StartPoint$ 0.5,0&�6&    �� EndPoint$ 0.5,1&�69   .��5      �  � Color$ #223266��6#   	 � Offset$	 0Q�63   � 5      $ #22396b��6#   $	 1Q�63   5      ._�5      �� .+�5!      �� 
 �� Orientation$
 
Horizontal=�6   $��Center=�66   $��0 35 0 0q�6S   .+�5"      �� $ 10��6   $��40��6/   $��40��6:   ��5#      �� 5$      $	 0,0&�62   $	 1,2&�6C   .��5%   "   � $ #7f7cf1��6/   $	 0Q�6?   � 5&   "   $ #d3b7ff��6/   $	 1Q�6?   5'      ._�5*      �� -   5         ��Name$ TB_PN��5*   $   $�� ��63   ���#fff$��22(�6M   $��SemiBold"�6[    �� TextAlignment$ Center=�5+   $   $��Center=�6;   $��3 0 0 2q�6V   5-      �� 5/      $��10 0 0 0q�6!   $��Center=�63   .+�50      �� $
 
Horizontal=�6%   .+�51      �� $��15(�6O   $��0 0 5 5q�6]   ���#c2cfff��6(   �� *LeClient.PrenomClient+6n   �� 52      $��15(�6L   ���#c2cfff��6(   �� *LeClient.NomClient+6Z   53      �� 54      $��Beta 1.0��6$   $��11(�64   ���#7788bf6C   55      57      �� 59      $	��0.8��6   $��20 30q�6)   ���#46558a68   �� 5=      -   5         ��Name$ BTN_Home��5=         menuButtonActive#��[  6C   .��5>      �� $
 
Horizontal=�6!   .+�5?      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6'     menuButtonIcon#��[ 63   �� 5@      $��Accueil��6$     menuButtonText#��[ 63   5A      5B      �� 5D      -   5        $ BTN_Bois��5D        
menuButton#��[ 6B   .��5E      �� $
 
Horizontal=�6!   .+�5F        $ Square=�6'   #��[ 65   �� 5G      $
��Bois��6$   #��[ 60   5H      5I      �� 5K      -   5        $ 	BTN_Micro��5K      #��[ 6D   .��5L      �� $
 
Horizontal=�6!   .+�5M        $ 
Microphone=�6'   #��[ 69   �� 5N      $��Micro��6$   #��[ 61   5O      5P      �� 5R      -   5        $ BTN_Vibrato��5R      #��[ 6H   .��5S      �� $
 
Horizontal=�6!   .+�5T        $ 
CodeCommit=�6'   #��[ 69   �� 5U      $��Vibrato��6$   #��[ 63   5V      5W      �� 5Y      -   5        $ BTN_Commande��5Y      #��[ 6J   .��5Z      �� $
 
Horizontal=�6!   .+�5[        $ 	FileLines=�6'   #��[ 68   �� 5\      $��Commande��6$   #��[ 64   5]      5^      �� 5a      -   5        $ BTN_Quitter��5a      #��[ 6H   .��5b      �� $
 
Horizontal=�6!   .+�5c        $ PowerOff=�6'   #��[ 67   �� 5d      $��Quitter��6$   #��[ 63   5e      5f      5h      5k      �� 5m   
   -   5        $��1��5m      $ 	0 10 10 0��6!   ��5n      �� 5o      $	 1,0&�6&   $	 0,1&�67   .��5p      � $ #41518f��6#   $	 0Q�63   � 5q      $ #2c386c��6#   $	 1Q�63   5r      ._�5u       � -	   5          �Name$ F_Page��5u        � NavigationUIVisibility$ Hidden=�6$   5x      5z      5{      