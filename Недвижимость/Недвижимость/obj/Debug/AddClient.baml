   M S B A M L   `   `   `  ����S  OНедвижимость, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:НедвижимостьНедвижимость  5   	   (    "Недвижимость.AddClient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Недвижимость     5   	     � Title$)  #Добавление клиента��5   	   $	��450��6$   $	��400��61    � WindowStartupLocation$ CenterScreen=�6=    � 
ResizeMode$ NoResize=�6b   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��Фамилия��6   $��30��6/   $��14(�6;   $��30,0,0,0q�6I   �� 5   
   $��1��6   $��Имя��6   $��30��6+   $��14(�67   $��30,0,0,0q�6E   �� 5   
   $��2��6   $��Отчество��6   $��30��60   $��14(�6<   $��30,0,0,0q�6J   �� 5   
   $��3��6   $!��Номер телефона��6   $��30��66   $��14(�6B   $��30,0,0,0q�6P   �� 5   
   $��4��6   $��
Почта��6   $��30��6-   $��14(�69   $��30,0,0,0q�6G   �� 5   
   -   5         ��Name$ fname��5      $��0��6!   $��30��6.   $	��200��6:   $��14(�6F   $��Right=�6T   $��0,0,30,0q�6p   �� 5   
   -   5        $
 name��5      $��1��6    $��30��6-   $	��200��69   $��14(�6E   $��Right=�6S   $��0,0,30,0q�6o   �� 5   
   -   5        $ oname��5      $��2��6!   $��30��6.   $	��200��6:   $��14(�6F   $��Right=�6T   $��0,0,30,0q�6p   �� 5   
   -   5        $ phone��5      $��3��6!   $��30��6.   $	��200��6:   $��14(�6F   $��Right=�6T   $��0,0,30,0q�6p   �� 5   
   -   5        $ email��5      $��4��6!   $��30��6.   $	��200��6:   $��14(�6F   $��Right=�6T   $��0,0,30,0q�6p   � 5   
   $��5��6    � ColumnDefinitions 5       �� 5!      �� 5"      .+�5%      �� -   5        $��0��5%      $��Отмена��6%   $��30��66   $	��150��6B   
������ 6g   �� 5&      -   5        $��1��5&      $��Сохранить��6%   $��30��69   $	��150��6E   
������ 6j   5*      5+      5,      