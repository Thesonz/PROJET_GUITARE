   M S B A M L   `   `   `  ����N  JIHM_VRAI_CUSTOM_NET, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:IHM_VRAI_CUSTOM_NET.F.PIHM_VRAI_CUSTOM_NET.F.P  5      =#clr-namespace:IHM_VRAI_CUSTOM_NET.CIHM_VRAI_CUSTOM_NET.C  6;   .    (IHM_VRAI_CUSTOM_NET.F.P.P_HOME_COMMANDER   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      1local%clr-namespace:IHM_VRAI_CUSTOM_NET.F.P  5      +c#clr-namespace:IHM_VRAI_CUSTOM_NET.C  6;   $	��740��5	      $
��1030��5
   	     N� 
Background
  ����  N� Title$ P_HOME��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ TB_HomeTitle��5      $�� ��6*   $��26(�62   ���#ccd7ff$
��Left=�6U   $��
50 35 0 20q�6p   � 5   
   $��2��6   .+�5      ��  �� CornerRadius$ 20��6    �� Padding$ 35 25q�6'   ���#243771$��
50 0 50 40q�6L   ._�5      �  5      �� 5      $
��auto �6(   �� 5      $
��auto �6(   �� 5       $
��auto �6(   .+�5#      ��  �� Orientation$ 
Horizontal=�6!   $��0 0 0 25q�6:   .+�5$      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Circle=�6'      	titleIcon#��[  65   �� 5%      $��Création de guitare��6$     menuText#��[ 6?   5&      � 5)      $��1��6    5*      �� 5+      $��20 �6,   �� 5,      $��40 �6,   �� 5-      $	��360 �6,   �� 5.      $��70 �6,   .+�51      � $��0��6    � ColumnDefinitions 52      �� 53   "   $	��100 �63   �� 54   "   $	��200 �63   �� 55   "   $	��200 �63   �� 56   "   $	��200 �63   �� 57   "   $	��200 �63   .+�59      �� $
��Bois��6(   $��16(�64   $
��Left=�6B   $��SemiBold"�6]   $��5 0 0 0q�6s   ���#fff6�   �� 5:      $��1��6(   $��Micro��68   $��16(�6E   $��Center=�6S   $��SemiBold"�6p   $��30 0 0 0q�6�   ���#fff6�   �� 5;      $��2��6(   $��Vebrato��68   $��16(�6G   $��Center=�6U   $��SemiBold"�6r   $��20 0 0 0q�6�   ���#fff6�   �� 5<      $��3��6(   $��Verification��68   $��16(�6L   $��Center=�6Z   $��SemiBold"�6w   $��10 0 0 0q�6�   ���#fff6�   �� 5=      $��4��6(   $��	Commandé��68   $��16(�6H   $��Center=�6V   $��SemiBold"�6s   $��0 0 0 0q�6�   ���#fff6�   5@      �� 5B      $��1��6!   $��0 0 0 0q�6.   .+�5C      �� $��1��6(   $��	30 15 0 0q�65   $	��780��6H   $��10��6T   
�������6`   A� 5D      $��0 0 0 0q�6&   $��40��67   $��40��6B   
�������6N   A� 5E      $��	195 0 0 0q�6&   $��40��69   $��40��6D   
�������6P   A� 5F      $��	390 0 0 0q�6&   $��40��69   $��40��6D   
�������6P   A� 5G      $��	585 0 0 0q�6&   $��40��69   $��40��6D   
�������6P   A� 5H      $��	780 0 0 0q�6&   $��40��69   $��40��6D   ���#4953856P   5I      �� 5K      $��2��6%   $ Vertical=�62   .+�5L      �� $"��Votre Commande est validé !��6(   $
��0 10q�6K     	titleText#��[ 6Y   $��Center=�6|   �� 5M      -   5        $ TB_Descriptif��5M   (   $�� ��6?   $
��Wrap=�6G     
normalText#��[ 6[   6�   5N      �� 5P      -   5        	 ��Name$	 BTN_Suivant��5P   !   $��Retourner à l'Accueil��6P   $��3��6p    
 button#��[ 6}   $��0 20 0 0q�6�   $��Right=�6�   5Q      5U      5V      5]      5_      5`      