   M S B A M L   `   `   `  ����F  BWpfUrbexApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfUrbexAppWpfUrbexApp  5   	       WpfUrbexApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfUrbexApp     5   	     � Title$  Urban Exploration Blog��5   	   $	��700��6(   $	��900��65    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ CanResizeWithGrip=�5
   	    � Icon$ icon.ico��5   	   ��5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ #2C2C2C��6    � Offset$ 0Q�6+   � 5      $ #444444��6   $	 0.5Q�6+   � 5      $ #5A5A5A��6   $ 1Q�6+   5      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Urban Exploration Blog��6!   $��24(�6?   $
��Bold"�6M   ���#ced4da$��Center=�5   )   $��0,0,0,15q�6F   �� 5    
   -   5        $��lbPosts��5       $��1��6!   
������ $��Center=�5$   
   $	��Top=�5%   
   ��5&      �� 5'      .R�5(      A� 	 A� Columns$	 4��6"   $��Center=�6.   5*      ��5-      �� 5.      .R�5/      �� 
�������$��1q�60   
 �� Padding$
 5q�6D    �� CornerRadius$ 10��6P   $��5q�6b   $��Center=�50       � ToolTip$D >Kliknij dwukrotnie myszką, aby wyświetlić szczegóły posta��51       ^� InitialShowDelay$	 300��52       ^� ShowDuration$
 5000��6;   ._�53      ��  �� Orientation$ Vertical=�6%   $��Center=�6<   .+�54      �� $ 10��6%   $��0q�67   ._�55   "   �� $	��150��6A   $	��150��6M   $��UniformToFill=�6Z   $��5q�6r   ��6(   �� *Image+6r   56      �� 57      $��16(�6?   $
��Bold"�6M   ���#ced4da �� TextAlignment$ Center=�58   5   $
��Wrap=�59       $	��150��64   ��57   (   �� *Title+59   4   5:      5;      5<      ��5?      �� 5@       �� 
TargetType" ��6   .�5A      ��  �� Property � �� �� Value$ Center=�6<   5B      5D      �� 5H   
   $��3��6   $ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5I      �� -   5        $��	btnCreate��5I      $��
Dodaj Post��6&   $	��120��6;   $��40��6G   $��5q�6k   ���#087f5b6v   �� 5J      -   5        $��btnEdit��5J      $��Edytuj��6$   $	��120��65   $��40��6A   ${�False��6c   $��5q�6u   ���#74c0fc6�   �� 5K      -   5        $��	btnDelete��5K      $��Usuń��6&   $	��120��65   $��40��6A   ${�False��6e   $��5q�6w   ���#ced4da6�   �� 5L      -   5        $��btnClose��5L      $��Zamknij��6%   $	��120��67   $��40��6C   $��5q�6f   ���#ff6b6b6q   5M      5O      5P      