   M S B A M L   `   `   `  ����H  DProfitManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProfitManagerProfitManager  5   	       ProfitManager.InputBox   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProfitManager     5   	     � Title$  Input��5   	   $	��200��6   $	��250��6$    � 
ResizeMode$ NoResize=�60   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��0��6   .+�5      �� -   5        $��	Lb_Amount��5      $��30(�6%   .��63   	Amount:6<   �� 5      -   5        $��InputTextBox��5      $
��10,0q�6*   $��5q�68   $��2q�6D   
���   � � 
InputScope$ CurrencyAmount��6l    +� FocusedElement 6�   ��  �� RelativeSource �� *Self+6�   5      ]� 5   
   $��1��6   ��.  .+�5      �� -   5        $��OkButton��5      $��OK��6%   $
��Left=�62   $
��20,0q�6H   $��25,10q�6W    �� 	IsDefault . 6w   �� 5      -   5        $��CancelButton��5      $��Cancel��6)   $��Right=�6:   $
��20,0q�6Q   $��25,10q�6`   6o   5      5      5      