   M S B A M L   `   `   `  ����  WpfUrbexApp)    #WpfUrbexApp.Views.PostDetailsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Szczegóły Posta��5   	   $	��800��6!   $	��700��6.   $��Segoe UI)�5   	   $��14(�6    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$% pack://application:,,,/icon.ico��5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	   ��5
      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ #2C2C2C��6    � Offset$ 0Q�6+   � 5      $ #444444��6   $	 0.5Q�6+   � 5      $ #5A5A5A��6   $ 1Q�6+   5      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5!   
   �� -   5        $��txtTitle��5!   !   $��0��6   $��22(�61   $
��Bold"�6?   
�������$��0,0,0,15q�5"   '   $
��Wrap=�69   $��Center=�5#      (� 5&   
   $��1��6   	 (� Stretch$	 Uniform=�6   $��0,0,0,15q�61   .��5'      �� -   5        $��
imgPreview��5'      5(      �� 5+   
   -   5        $��txtDescription��5+   !   $��2��6   
�������$
��Wrap=�5,   '   $��	0,10,0,15q�6;   �� 5/   
   $��3��6   
 �� Orientation$
 
Horizontal=�6"   $
��Left=�6;   $��0,0,0,15q�6V   .+�50      �� $��Odwiedzono: ��6   
�������$
��Bold"�6?   �� 51      -   5        $��txtDate��51      
�������$��5,0,15,0q�6:   �� 52      $��Lokalizacja: ��6   
�������$
��Bold"�6@   �� 53      -   5        $��txtLocation��53      
�������$��5,0,0,0q�6>   54      �� 57   
   $��4��6   $��Right=�6"   $��0,10,0,0q�6>   .+�58      �� -   5        $��Zamknij��58      $	��120��6'   $��40��63   ���#ff6b6b$��0q�59   *   5:      5;      5<      