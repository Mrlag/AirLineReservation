   M S B A M L   `   `   `  ����S  OWpfAppAirLineReservation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WpfAppAirLineReservationWpfAppAirLineReservation  5   	   /    )WpfAppAirLineReservation.選擇航班_WPF   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:WpfAppAirLineReservation     5   	     � Title$  選擇航班_WPF��5   	   $��668.5��6   $	��900��6)    � 	Resources 5	         _ListBoxItemStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding J� SnapsToDevicePixels �� Triggers	 P� Property
 P� Value �� 
TargetName��%q  &	        �� 5
   
   " ��6*   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $��_Border��6!   $ 2q�5   !    . ._�5      �� 5       5      P� 5      	 �@��
IsSelected
 . . �5   "   �� $ _Border��6)    � ��
 ���� 6T   �� 5   "    � ��
 ���� 6?   5      5      5      5      5      .��5!      �  � ColumnDefinitions 5"   
   �� 5#      $
��100* �6   �� 5$      $
��465* �6   �� 5%      $
��100* �6   �� 5&      $
��127* �6    � RowDefinitions 5(   
   �� 5)      $��1* �6   �� 5*      $��1* �6   �� 5+      $��1* �6   �� 5,      $��1* �6   .+�5/   
   �� $��0��6   $��1��6%   $��3��62   $��3��6F   .+�51      9� -   5        $��
GoExpander��51      $��去程��6*   $	��385��66    9� 
IsExpanded . .��53      �� -   5         ��Name$ DeparturelistBox��53   M   $��Visible=�6   #���   6h   $
��0,10q�6�   ��54      �� 55      .R�56      ��  �� Orientation$ Vertical=�6)   57      59      5;      5<      9� 5=   
   $
��test��6   .��5>      �� $	��sda��6   6$   5?      �� 5A   
   -   5        $��listBox2��5A   �   $��Disabled=�6   $��Disabled=�6J   $��10q�6~   $��1��6�   $��0��6�   $��1��6�   #���   6�   ��5B      �� 5C       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5D      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5E      $ White��6#   $ 1Q�61   5F      .@�5H      �� -   5        $��listBox2Item��5H      60   ��5I      �� 5K      .R�5L      �� $ 
Horizontal=�6"   $��Disabled=�6;   6q   5M      5O      �� 5P   
   -   5        {�. $��ScrollBar.LineLeftCommand��5P   "   $��20(�6z   $��<��6�   ��6F   ��  �� ElementName$ listBox2Item��6�   �� 5Q   
   $��20(�6   $��>��6    $��2��6/   $ ��ScrollBar.LineRightCommand��6?   ��6d   �� $ listBox2Item���� 5R   
   $	��478��6   $	��143��6$   $��3��60   $��3��6@   .��5T      9� -   5         9�Name$ OrderDetailExpander��5T      $��摘要��64   $	��478��6@   $	��143��6M   .��5U      � ���	#FFE5E5E5.+�5V      �� -   5         ��Name$ ExpanderStack��5V   !   5W      5X      5[      �� 5\   
   -   5        $��NextStepButton��5\   #   {�.  $��	下一步��69   $��3��6G   $
��Left=�6W   $��	28,33,0,0q�6r   $��3��6�   $	��Top=�6�   $��85��6�   $��43��6�   6�   5_      5a      