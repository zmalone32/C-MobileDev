   M S B A M L   `   `   `  ����L  HPlant_Inheritance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Plant_InheritancePlant_Inheritance  5   	   "    Plant_Inheritance.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Plant_Inheritance     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   
������.��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��4* �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��300 �6   �� 5      $
��449* �6   .+�5   
   �� $��Name: ��6   $��1��5      $��30(�5      $��Center=�5      $��Right=�5      �� 5   
   $��Environment: ��6   $��2��5      $��30(�5      $��Center=�5       $��Right=�5!      �� 5"   
   $��Type: ��6   $��3��5#      $��30(�5$      $��Center=�5%      $��Right=�5&      �� 5'   
   -   5         ��Name$ TbName��5'      $��1��5(      $��1��5)      $��3q�5*      �� 5+   
   -   5         ��Name$ CbEnvironment��5+      $��3q�5,      $��30(�5-      $��1��5.      $��2��5/      $��Center=�50      �� 51   
   -   5        $ CbType��51      $��3q�52      $��30(�53      $��1��54      $��3��55      $��Center=�56      �� 57   
   -   5         ��Name$ BtnAddPlant��57      $��	Add Plant��58      $��4��59      $��1��5:      $��3q�5;      
�������5=      �� 5>   
   -   5        $ BtnShowDetails��5>      $��Show Details��5?      $��4��5@      $��2��5A      $��3q�5B      
�������5D      �� 5E   
   $��1��6   $��2��5F      $��3��5G      $��
All Plants��5H      $��25(�5I      $��5q�5J      .��5K      �� -   5         ��Name$ LstBoxPlants��5K      $��25(�5L      $��5q�5M      5N      �� 5O   
   -   5         ��Name$ ImgPlant��5O      $��1��5P      $��5��5Q      $��/Images/plant.jpeg��5R      �� 5S   
   -   5        $ ImgEnvironment��5S      $��2��5T      $��5��5U      $��/Images/plant.jpeg��5V      5W      5X      