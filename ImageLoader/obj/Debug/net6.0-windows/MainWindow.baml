   M S B A M L   `   `   `  ����F  BImageLoader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ImageLoaderImageLoader  5   	       ImageLoader.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ImageLoader     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      �� 5      �� 5      �� 5      �� 5      $��2* �6   .+�5   
   �� -   5         ��Name$ Image1��5      $��10q�6    �� 5   
   -   5         ��Name$ UrlStr1��5      $��	10,5,10,5q�6#   $��1��66   $��20(�6C   ���#808080$��Url...��6f   6�   �� 5   
   -   5         ��Name$ StartLoadImg1��5      $��	10,5,10,5q�6(   $��2��6;   $��Start��6H   6X   �� 5   
   -   5        $ StopLoadImg1��5      $��	10,5,10,5q�6'   $��3��6:   $
��Stop��6G   6V   �� 5   
   -   5        $ Image2��5      $��10q�6    $��1��6,   �� 5   
   -   5        $ UrlStr2��5      $��	10,5,10,5q�6#   $��1��66   $��1��6C   $��20(�6S   ���#808080$��Url...��6v   6�   �� 5    
   -   5        $ StartLoadImg2��5       $��	10,5,10,5q�6(   $��2��6;   $��1��6H   $��Start��6X   6h   �� 5!   
   -   5        $ StopLoadImg2��5!      $��	10,5,10,5q�6'   $��3��6:   $��1��6G   $
��Stop��6W   6f   �� 5#   
   -	   5        $ Image3��5#      $��10q�6    $��2��6,   �� 5$   
   -
   5        $ UrlStr3��5$      $��	10,5,10,5q�6#   $��1��66   $��2��6C   $��20(�6S   ���#808080$��Url...��6v   6�   �� 5%   
   -   5        $ StartLoadImg3��5%      $��	10,5,10,5q�6(   $��2��6;   $��2��6H   $��Start��6X   6h   �� 5&   
   -   5        $ StopLoadImg3��5&      $��	10,5,10,5q�6'   $��3��6:   $��2��6G   $
��Stop��6W   6f   � 5*   
   -   5         �Name$ TotalProgressBar��5*      $��5��60   $��1��6=   $��Center=�6M   $��20��6h   $��10q�6t   �� 5+   
   -   5        $ LoadAllButton��5+      $��Load all��6(   $��4��6;   $��1��6H   $��	10,5,10,5q�6X   6k   5,      5-      