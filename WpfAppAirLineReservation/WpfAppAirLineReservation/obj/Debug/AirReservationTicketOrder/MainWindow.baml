   M S B A M L   `   `   `  ����S  OWpfAppAirLineReservation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WpfAppAirLineReservationWpfAppAirLineReservation  5   	   )    #WpfAppAirLineReservation.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:WpfAppAirLineReservation     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��	Combobox1��5
      $
��Left=�6%   $	��Top=�6@   $	��120��6X   $��
359,59,0,0q�6d   �� 5   
   -   5         ��Name$ 	Combobox2��5      $
��Left=�6&   $��
359,99,0,0q�6A   $	��Top=�6U   $	��120��6m   �� 5   
   
������ $��出發地
��6)   $��263,59,469,327q�6A   �� 5   
   $��	目的地��6   $��264,97,469,288q�6   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��DepartureDatePicker��5      $
��Left=�60   $	��Top=�6K   $��359,152,0,0q�6c   �� 5   
   $��	出發日��6   $
��Left=�6   $	��Top=�69   $��268,151,0,0q�6Q   �� 5   
   $��	回程日��6   $
��Left=�6   $	��Top=�69   $��268,195,0,0q�6Q     5   
   -   5        $��ArrivalDatePicker��5      $
��Left=�6.   $	��Top=�6I   $��359,195,0,0q�6a   �� 5   
    �� SelectedText$  ��6   $
��Left=�6"   $��33��6=    �� TextWrapping$
 Wrap=�6I   $	��Top=�6]   $��71��6u   $��359,243,0,0q�6�   �� 5   
   $��優惠代碼��6   $
��Left=�6   $	��Top=�6:   $��268,251,0,0q�6R   �� 5   
   -   5        $��搜尋航班��5      $
��Left=�6    $	��Top=�6;   $��75��6S   $��268,313,0,0q�6^   6s   �� 5   
   $��旅客��6   $
��Left=�6   $	��Top=�68   $��512,193,0,0q�6P   �� 5   
   -   5        $ AdultComboBox��5      $
��Left=�6*   $	��Top=�6E   $��84��6]   $��512,255,0,0q�6h   �� 5   
   -   5        $ KidComboBox��5      $
��Left=�6(   $	��Top=�6C   $��84��6[   $��628,255,0,0q�6f   �� 5   
   $��GroupBox��6   $
��Left=�6%   $��97��6@   $	��Top=�6L   $	��192��6d   $��
533,46,0,0q�6p   .��5      � $
��Left=�6   $��67��6.   $	��Top=�6:   $	��100��6R   $��45,4,0,0q�6^   .+�5      	� -   5         	�Name$ OneWay��5      $��單程��6.   $
��Left=�6;   $	��Top=�6V   $��0,19,0,0q�6n   	� 5      -	   5        $ TwoWay��5      $��來回��6.   $
��Left=�6;   $	��Top=�6V   $��0,37,0,0q�6n   5      5      �� 5   
   $��小孩��6   $
��Left=�6   $	��Top=�68   $��533,218,0,0q�6P   �� 5   
   $��大人��6   $
��Left=�6   $	��Top=�68   $��651,218,0,0q�6P   5!      5"      