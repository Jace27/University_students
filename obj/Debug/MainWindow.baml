   M S B A M L   `   `   `  ����M  IUniversityStudents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:UniversityStudentsUniversityStudents  5   	   &     UniversityStudents.Authorization   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:UniversityStudents     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Авторизация��5	   	   $��324.932��6   $��428.475��6.    � Icon$ icon.ico��6>   ���	#FF5662DC � 
ResizeMode$ NoResize=�6e   .��5
      � $��0,0,4,0q�6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $��Введите логин��6   $��0��6(   $
��Left=�68   $��	10,10,0,0q�6S   $��0��6f   $	��Top=�6s   $��24(�6�   �� 5   
   -   5         ��Name$ Login��5   !    �� 	MaxLength$ 20��6   $��0��60   $
��Left=�6@   $��36��6[   $��10,0,0,0q�6g   $��1��6y    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��24(�6�   	 �� 	UndoLimit$	 32��6�   $	��398��6  �� 5   
   $!��Введите пароль��6   $��0��6)   $
��Left=�69   $��10,0,0,0q�6T   $��2��6f   $	��Top=�6s   $��24(�6�   G� 5   
   -   5        
 G�Name$
 Password��5   %    G� 	MaxLength$ 20��6   $��0��67   $
��Left=�6G   $��10,0,0,0q�6b   $��3��6t   $	��Top=�6�   $��24(�6�   $	��398��6�   �� 5   
   -   5        $��
Войти��5      $��0��6!   $��Center=�61   $
��10,0q�6N   $��4��6\   $	��Top=�6i   $��24(�6�   ���	#FFFDB968$	��398��6�   5      5      