   M S B A M L   `   `   `  ����D  @Praktika1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Praktika1	Praktika1  5          Praktika1.Balenci   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Praktika1     5        N� Title$  Товары��5	       N� 
Background �	#FFFDD0AA N� 
FontFamily$ Century Gothic)�6.   .��5
      �  � RowDefinitions 5   
   �� 5      $
��0.8* �6   �� 5      $
��0.2* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��DataGridTest��5   <   $��0��6      AutoGenerateColumns .  ���	#FFFDD0AA   CanUserAddRows . $��0q�6�   ��6}   �� *Test+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6U   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� 
 �� Path$

 Name�6U     5      $ Тип материала��6%   $	 200 6Z   	 6<   �� $

 Type�6Z     5      $ Цена��6%   $	 200 6R   	 63   �� $
 Price�6R     5      $ Кол-во��6%   $	 200 6T   	 65   �� $
 Colvo�6T   5      � 5   
   $��1��6   $y�Visible=�6    5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      $
��0.3* �6#   �� 5       $
��0.4* �6#   �� 5!      $
��0.4* �6#   .+�5#      �� $%��Введите название��6   $��Center=�60   $��0��6K   $��0��6X   $��10,0,0,0q�6h   �� 5$      -   5        $��name1��5$      $��0��6#   $��1��60   �� 5%      $.��(Введите тип материала��6   $��Center=�65   $��1��6P   $��0��6]   $��10,0,0,0q�6m   �� 5&      -   5        $��tipe1��5&      $��1��6#   $��1��60   �� 5'      $��Введите цену��6   $��Center=�6,   $��2��6G   $��0��6T   $��10,0,0,0q�6d   �� 5(      -   5        $��cost1��5(      $��2��6#   $��1��60   �� 5)      $ ��Введите кол-во��6   $��Center=�6.   $��3��6I   $��0��6V   $��10,0,0,0q�6f   �� 5*      -   5        $��kolvo1��5*      $��3��6$   $��1��61   5+      �� 5,   
   -   5        $"��Добавить товар ��5,      $��1��6+   $��Right=�68   $	��200��6e   $��50��6q   $��Bottom=�6}   �� 5-   
   $��\image\LOGO.png��6   $��58��6)   $��1��66   $��Right=�6C   $	��Top=�6_   $��58��6w   5.      50      