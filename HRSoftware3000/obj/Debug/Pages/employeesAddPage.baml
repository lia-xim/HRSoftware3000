   M S B A M L   `   `   `  ����I  EHRSoftware3000, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:HRSoftware3000.PagesHRSoftware3000.Pages  5      +    %HRSoftware3000.Pages.employeesAddPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:HRSoftware3000.Pages     5        � Title$  HRSoftware3000��5	      $	��800��6   $	��450��6-   $	��450��6=   $	��800��6J   $	��900��6V   $
��1600��6f    � WindowStyle$ ThreeDBorderWindow=�6v   .��5      � 
�������.+�5   
   �  � Cursor$  ��6    � ColumnDefinitions 5      �� 5      6%   �� 5      6%   �� 5      6%   �� 5      6%   �� 5      6%   �� 5      6%   �� 5      6%    � RowDefinitions 5      �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   .+�5!      �� $��0��6   $��1��6!   $��4��61   $��Center=�6E   $��Center=�6b   .��6~    Füge einen Mitarbeiter hinzu:6�   �� 5#      -   5         ��Name$ border��5#      $��1��6%   $��1��65   $��5��6B   $��4��6S   $	��1pxq�6g   
���   � �� CornerRadius$ 25��6�    J� BitmapEffect 5$      F� 5%       F� Color$ Black��6-   	 F� Softness$		 0.3Q�6;   
 F� 	Direction$	
 -50Q�6J   6\   5'      �� 5)      $��1��6   $��20,0,0,0q�6!   $��1��63   $
��Left=�6C   $��Center=�6^   .��6y   Id6}   �� 5*      $��2��6   $��20,0,0,0q�6!   $��1��63   $
��Left=�6C   $��Center=�6^   .��6y   
NachName6�   �� 5+      $��3��6   $��20,0,0,0q�6!   $��1��63   $
��Left=�6C   $��Center=�6^   .��6y   	Vorname6�   �� 5,      $��4��6   $��20,0,0,0q�6!   $��1��63   $
��Left=�6C   $��Center=�6^   .��6y   	Abteilung6�   �� 5-      $��5��6   $��20,0,0,0q�6!   $��1��63   $
��Left=�6C   $��Center=�6^   .��6y   	Telefon6�   �� 50      -   5         ��Name$ Nachname_Text��50      $��2��6-   $��2��6:   $��200px��6J   $��2��6X   $
��Left=�6l   $��Center=�6�   6�   �� 51      -   5        $ Vorname_Text��51      $��3��6,   $��2��69   $��200px��6I   $��2��6W   $
��Left=�6k   $��Center=�6�   6�   �� 52      -   5        $ Abteilung_Text��52      $��4��6.   $��2��6;   $��200px��6K   $��2��6Y   $
��Left=�6m   $��Center=�6�   6�   �� 53      -   5        $ Telefon_Text��53      $��5��6,   $��2��69   $��200px��6I   $��2��6W   $
��Left=�6k   $��Center=�6�   6�   �� 54      -   5        $ Id_Text��54      $��1��6'   $��2��64   $��200px��6D   $��2��6R   $
��Left=�6f   $��Center=�6�   6�   �� 56      -   5         ��Name$ SaveAddEmployeeBtn��56      $��4��6K   $��5��6[   $��50��6h   $
��Auto��6v   $
��Auto��6�   $��15q�6�   $��14(�6�   $
 Hand��6�   .��6�   	Speichern6�   57      58      59      