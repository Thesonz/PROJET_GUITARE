   M S B A M L   `   `   `  ����E  AIHM_CUSTOM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:IHM_CUSTOM
IHM_CUSTOM  5   	       IHM_CUSTOM.C_CADRE   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:IHM_CUSTOM     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��0.15* �6   �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� $��Center=�6   $��Center=�61   $��Projet Guitare��6L   $��32(�6e   �� 5      $��2��6   $��(NOM)��6$   $��32(�64   �� 5      -   5         ��Name$ 
IMGProfile��5      $
��Fill=�6(   $��Right=�67   $��2��6S   $��32��6c   $��32��6n   5      � 5   
   $��1��6    5      �� 5       �� 5!      .+�5$      �� -   5        $ 
IMGGuitare��5$      $��0��6(   $
��Fill=�68   � 5%      $��1��6    5&      �� 5'      $	��87* �6'   �� 5(      $	��13* �6'    5*      �� 5+      �� 5,      �� 5-      �� 5.      �� 5/      �� 50      .+�53      �� -   5         ��Name$ BTNListeBois��53   &   $��1��6   $��Liste des Bois��6<   $��32(�6U   $
��Left=�6c   $��Center=�6   $��	103,0,0,0q�6�   �� 54      -   5        $ BTNListeMicro��54   &   $��2��6   $��Liste des Micro��6=   $��32(�6W   $
��Left=�6e   $��Center=�6�   $��92,0,0,0q�6�   �� 55      -   5        $ BTNListeVibrato��55   &   $��3��6   $��Liste des Vibrato��6?   $��32(�6[   $
��Left=�6i   $��Center=�6�   $��81,0,0,0q�6�   �� 58      -   5        $ BTNAjoutGuitare��58   &   $��5��6   $��Crée votre guitare��6?   $��32(�6\   $
��Left=�6j   $��Center=�6�   $��71,0,0,0q�6�   59      5:      5<      5=      