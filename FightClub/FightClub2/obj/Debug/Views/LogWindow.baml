   M S B A M L   `   `   `  ����E  AFightClub2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FightClub2.ViewsFightClub2.Views  5   	        FightClub2.Views.LogWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:FightClub2.Views     5   	   -   5          � Title$%  Бойцовский клуб 2��5   	   $	��360��5	   	   $
��1280��5
   	    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ 3q�6'   �� 5       �@��Padding$ 3q�6(   �� 5       � ��$ Center=�64   5      5      .��5      � ��5   
   �� 5       �� ImageSource$&  ../Resources/FightBackground.png��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� -   5         ��Name$ FighterNameTextBlock��5      $��Лог боя��5       ���	#FFDE19A7$��Impact)�5"      $��24(�5#      $��Italic$�5$      �� 5%   
   -   5        	 ��Name$	 
LogTextBox��5%      $��1��5'      $��100 10 100 10q�5(      $��3q�5)      
 �� 
IsReadOnly
 . $��Center=�5+      " �� VerticalScrollBarVisibility$ Hidden=�5,      ���	#FFDE19A7 �� SelectionBrush �	#FFDE19A7���	#FF191919$��Impact)�50      $��20(�51      $��Italic$�52       J� OpacityMask �	#FFDE19A7���	#FFDE19A754      55      56      