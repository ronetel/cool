   M S B A M L   `   `   `  ����@  <пр4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:пр4пр4  5          пр4.rtPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:пр4     5        N� Title$  rtPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   � $��1��6   $��3��6    5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� -   5         ��Name$ 	name_test��5      $��1��6)   $��0��66   �� 5       -   5        $ 	deck_test��5       $��1��6)   $��1��66   �� 5!      -   5        $ first_an��5!      $��1��6(   $��2��65   �� 5"      -   5        $ 	second_an��5"      $��1��6)   $��3��66   �� 5#      -   5        $ third_an��5#      $��1��6(   $��4��65   �� 5$      -   5         ��Name$ right_an��5$      $��1��6)   $��5��66   5%      �� 5&   
   -   5        $#��Добавить вопрос��5&      $��2��6+   $��0��68   6H   �� 5'   
   -   5        $#��Изменить вопрос��5'      $��2��6+   $��1��68   6H   �� 5(   
   -	   5        $!��Удалить вопрос��5(      $��2��6*   $��2��67   6G   &   System.Windows.Controls.DataGrid  5)   
   -
   5          Name$ grid_emp��5)      $��0��6%   $��3��62      
IsReadOnly .    AutoGenerateColumns .     Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Название��6D   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *	Name_test+6D     5,      $	 Описание��6C   
 6%   �� *	Desc_test+6C     5-      $!	 Первый вариант��6E   
 6%   �� *FirstAnswer+6E     5.      $!	 Второй вариант��6F   
 6%   �� *SecondAnswer+6F     5/      $!	 Третий вариант��6E   
 6%   �� *ThirdAnswer+6E     50      $%	 Правильный ответ��6?   
 6%   �� *RA_ID+6?   52      53      54      