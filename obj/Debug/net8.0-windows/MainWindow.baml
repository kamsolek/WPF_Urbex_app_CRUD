   M S B A M L   `   `   `  ����F  BWpfUrbexApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfUrbexAppWpfUrbexApp  5   	       WpfUrbexApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfUrbexApp     5   	     � Title$  Urban Exploration Blog��5   	   $	��600��6(   $	��900��65   ��5	      �� 5
   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ #2C2C2C��6    � Offset$ 0Q�6+   � 5      $ #444444��6   $	 0.5Q�6+   � 5      $ #5A5A5A��6   $ 1Q�6+   5      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Urban Exploration��6!   $��24(�6:   $
��Bold"�6H   
�������$��Center=�5   '   �� 5   
   -   5        $��lvPosts��5       $��1��6   $��10q�6/   
������ ��5      �� 5      .R�5      �� 
�������$��1q�60    �� Padding$ 5q�6D    �� CornerRadius$ 10��6P   $��5q�6b   ._�5       ��  �� Orientation$ 
Horizontal=�6%   .+�5!      �� $��50��6=   $��50��6H   $��5q�6T   ��6$   �� *Image+6T   �� 5"      $��18(�6?   $
��Bold"�6M   
���������6(   �� *Title+6_   5#      5$      5%      5'      �� 5(   
   $��3��6   $ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5)      �� -   5        $��	btnCreate��5)      $��
Dodaj Post��6&   $	��120��6;   $��40��6G   $��5q�6k   
���"�"�6v   �� 5*      -   5        $��btnEdit��5*      $��Edytuj��6$   $	��120��65   $��40��6A   ${�False��6c   $��5q�6u   �� 5+      -   5        $��	btnDelete��5+      $��Usuń��6&   $	��120��65   $��40��6A   ${�False��6e   $��5q�6w   �� 5,      -   5        $��btnClose��5,      $��Zamknij��6%   $	��120��67   $��40��6C   $��5q�6f   5-      5/      50      