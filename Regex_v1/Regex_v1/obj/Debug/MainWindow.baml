   M S B A M L   `   `   `  ����C  ?Regex_v1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Regex_v1Regex_v1  5   	       Regex_v1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Regex_v1     5   	     � Title$!  Regular expressions creator��5   	   $	��620��6-   $	��525��6:    � 
ResizeMode$ CanMinimize=�6F    � WindowStartupLocation$ CenterScreen=�6_    � 	Resources 5	         CiemnaZielen �� Color  SzaraZielen  JasnaZielen  ExpanderContentLbl �� 
TargetType �� Property �� Value  ExpanderContentRb  BtnStyle  ExpanderBtnStyle��%�  &	        &	 #     &	 F     &	 i     &	 �     &	 I    &	     �� 5
   
   $ 	#FF0A2E08��6/   �� 5   
   $ 	#FFEAF1DD��6.   �� 5   
   $ 	#FF7EC949��6.   �� 5   
   " ��6+   .�5      ��  � ��$ 15(�6)   �� 5       � ��$ Normal"�6+   5      �� 5   
   " 	�6*   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ Normal"�6+   5      �� 5   
   " ��6!   .�5      ��  � �� �	#FFEAF1DD6+   �� 5       � ��$ 13(�6)   �� 5       � �� �	#FF7EC9496,   �� 5       � ��$ DemiBold"�6+   5      �� 5   
   " ��6)   .�5      ��  � ��$ 13(�6)   �� 5       � �� �	#FF89CD396,   �� 5       � ��$ DemiBold"�6+   5       5!      .��5"      � ���	#FFFFFEF6.+�5#   
   �� $
��Left=�6   $	��116��6/   $��	0,473,0,0q�6<   
���   �$	��Top=�6^   $	��517��6v   #��[  6�   �� 5%   
   $
��Left=�6   $	��105��6/   
���   �$	��Top=�6K   $	��517��6c   #���   6o   �� 5&   
   $=��7Create regular expressions and use them in your project��6   $��Center=�6R   $��0,15,0,0q�6o   $	��Top=�6�   $��18(�6�   ���	#FF7EC9496�   �� 5'   
   -   5         ��Name$ 	BtnCreate��5'      $��Create��6&   $��Center=�67   $��27��6T   $��0,0,0,20q�6`   $��Bottom=�6r   $	��108��6�   #���  6�   {�.  	 J� RenderTransformOrigin$	 1.574,1.815&�6�   �� 5(   
   
���   �$��1q�6%   $��Center=�69   $��40��6V   $��0,0,0,15q�6b   $��Bottom=�6t   $
��Auto��6�   $y�	Collapsed=�6�   ._�5)      �� -   5        
 ��Name$
 lblWynik��5)      $�� ��6'   $��Center=�62   $��Center=�6O   $��0,0,0,0q�6j   $��17(�6{   5*      �� 5+   
   $
��Help��6   $��Center=�6    $��0,68,0,0q�6=   $	��Top=�6O   $��76��6g   #���  6r   �� 5,   
   $
��Left=�6   $	��349��62   $��
10,110,0,0q�6?   $	��Top=�6S   $	��497��6k   .��5-      �� $
��Auto��6   $
��Auto��6'    �� CanVerticallyScroll .  .+�5.      � $��Stretch=�6    K� ZIndex$ 0��65   .+�50      9� -   5         9�Name$
 Exp1��50      $��16(�6_   $��Create pattern��6m   $��0,1,10,0q�6�   $	��Top=�6�   $��Stretch=�6�   .��51      � #���  6    � RowDefinitions 52      �� 53   "   �� 54   "   �� 55   "   .+�57      �� $��Label��6$   $
��Left=�64   $	��Top=�6O   $��0��6g   a� 58      $
��Left=�6+   $��31��6F   $	��Top=�6R   $��1��6j   $	��100��6w   59      �� 5:      $
��Left=�6&   $��23��6A    �� TextWrapping$
 Wrap=�6M   $��TextBox��6a   $��2��6p   $	��Top=�6}   $	��120��6�   �� 5;      $��Case sensitive��6'    d� 	IsChecked$
 TrueY�6@   $
��Left=�6Q   $	��Top=�6l   $��	200,0,0,0q�6�   $��2��6�   5=      5>      5@      � 5A      $��Stretch=�6   $ 1��65   $��0,20,0,0q�6F   .+�5B      9� -   5        $
 Exp2��5B      $��16(�6-   $*��$Look for specific characters (words)��6n   $��0,1,10,0q�6�   $	��Top=�6�   $��Stretch=�6�   .��5C      � #���  6    $	��198��6K    5D      �� 5E   "   $��40 �60   �� 5F   "   $��40 �60   �� 5G   "   $	��100 �60   .+�5I      �� $6��0Enter a character or a word you are looking for:��6$   $
��Left=�6_   $	��Top=�6z   #���  6�   $��30��6�   $	��348��6�   $��0��6�   �� 5J      -   5         ��Name$ ex2_textbox��5J   &   $
��Left=�6;   $��23��6V   $ NoWrap=�6b   $	��Top=�6x   $	��184��6�   $��1��6�   $��26,2,0,0q�6�   $��2��6�   $��Normal"�6�   6�   �� 5K      -   5        $ 
ex2_btnAdd��5K   %   $	��Add��69   $
��Left=�6G   $	��Top=�6b   $��75��6z   $��1��6�   #���  6�   $	 1.187,0.667&�6�   $��	250,4,0,0q�6�   $��2��6�   #���  6  ��5L   "   �� 5M   &     ExpanderBtnBrush# �  66   5O      �� 5P      -   5         ��Name$ 	ex2_lista��5P   &   $��Normal"�69   $
��Left=�6M   $��90��6h   $	��Top=�6t   $	��184��6�   $��2��6�   $��	26,10,0,0q�6�   $	 0.58,-0.255&�6�   �� 5Q      -   5        $ ex2_btnDelete��5Q   %   $��Delete��6<   $
��Left=�6M   $	��Top=�6h   $��2��6�   $��75��6�   #���  6�   $��
250,58,0,0q�6�   ��5R   "   �� 5S   &   # �  66   5U      5V      5W      5Y      � 5Z      $��Stretch=�6   $ 2��65   $��0,20,0,0q�6F   .+�5[      9� -	   5        $
 Exp3��5[      $��16(�6-   $%��Look for not allowed characters��6n   $��0,1,10,0q�6�   $	��Top=�6�   $��Stretch=�6�   .��5\      � #���  6    $	��198��6K    5]      �� 5^   "   $��40 �60   �� 5_   "   $��40 �60   �� 5`   "   $	��100 �60   .+�5b      �� $9��3Enter a character or a word that should not appear:��6$   $
��Left=�6b   $	��Top=�6}   #���  6�   $��30��6�   $	��348��6�   $��0��6�   �� 5c      -
   5        $ ex3_textbox��5c   &   $
��Left=�6;   $��23��6V   $ NoWrap=�6b   $	��Top=�6x   $	��184��6�   $��1��6�   $��26,2,0,0q�6�   $��2��6�   $��Normal"�6�   6�   �� 5d      -   5        $ 
ex3_btnAdd��5d   %   $	��Add��69   $
��Left=�6G   $	��Top=�6b   $��75��6z   $��1��6�   #���  6�   $	 1.187,0.667&�6�   $��	250,4,0,0q�6�   $��2��6�   #���  6  ��5e   "   �� 5f   &   # �  66   5h      �� 5i      -   5        $ 	ex3_lista��5i   &   $��Normal"�6:   $
��Left=�6N   $��90��6i   $	��Top=�6u   $	��184��6�   $��2��6�   $��	26,10,0,0q�6�   $	 0.58,-0.255&�6�   �� 5j      -   5        $ ex3_btnDelete��5j   %   $��Delete��6<   $
��Left=�6M   $	��Top=�6h   $��2��6�   $��75��6�   #���  6�   $��
250,58,0,0q�6�   ��5k   "   �� 5l   &   # �  66   5n      5o      5p      5r      � 5s      $��Stretch=�6   $ 3��65   $��0,20,0,0q�6F   .+�5t      9� -   5        $
 Exp4��5t      $��16(�6-   $��Match a date��6m   $��0,1,10,0q�6�   $	��Top=�6�   $��Stretch=�6�   .��5u      � #���  6     5v      �� 5w   "   $	��29* �60   �� 5x   "   $��36 �60   �� 5y   "   $	��35* �60   �� 5z   "   $��60 �60   .+�5|      �� $��Choose the format:��6$   $��0��6A   #���  6N   	� 5}      -   5         	�Name$ ex4_rbDD��5}   *   $��
dd-mm-yyyy��6<   $
��Left=�6Q   $��22,3,0,0q�6l   $��1��6~   $	��Top=�6�   #���  6�   $��18��6�   $	��104��6�   $
 TrueY�6�    	� 	GroupName$ rbDateFormat��6  	� 5~      -   5        $ 
ex4_rbYYYY��5~   *   $��
yyyy-mm-dd��6>   $
��Left=�6S   $��	191,3,0,0q�6n   $��1��6�   $	��Top=�6�   #���  6�   $��20��6�   $	��109��6�   $ rbDateFormat��6�   �� 5      $��Select matching option:��6$   #���  6F   $��2��6s   $��0,6,0,0q�6�   	� 5�      -   5        $ ex4_rbTylkoData��5�   *   $*��$expression consists solely of a date��6C   #���  6r   $
��Left=�6�   $��22,5,0,0q�6�   $��3��6�   $	��Top=�6�   $
 TrueY�6�   $ rbDateOption��6  	� 5�      -   5        $ ex4_rbDataPlus��5�   *   $ ��expression contains a date��6B   #���  6g   $
��Left=�6�   $��	22,28,0,0q�6�   $��3��6�   $	��Top=�6�   $ rbDateOption��6�   5�      5�      5�      � 5�      $��Stretch=�6   $ 3��65   $��0,20,0,0q�6F   .+�5�      9� -   5        $
 Exp5��5�      $��16(�6-   $��Match an email��6m   $��0,1,10,0q�6�   $	��Top=�6�   $��Stretch=�6�   .��5�      � #���  6    .+�5�      �� $>��8Creates regular expression pattern to match email adress��6$   #���  6g   $��0,0,0,15q�6�   $
��Left=�6�   $	��Top=�6�   5�      5�      5�      5�      5�      �� 5�   
   -   5        $��TxtCreateResult��5�      $�� ��6+   $	��470��64   $��Center=�6C   $��0,0,0,70q�6`   $��Bottom=�6r   $��15(�6�   $��SemiBold"�6�   #���  6�   |�.  � Cursor$ IBeam��6�   $��WrapWithOverflow=�6�    �� IsHyphenationEnabled . 6  �� 5�   
   -   5        $��ImgCopy��5�      $��Right=�6@   $��	0,0,20,20q�6\   $��Bottom=�6o   $��27��6�   $��27��6�   |�. $1��+pack://siteoforigin:,,,/Resources/copy1.bmp��6�    � ToolTip$
 Copy��6�   6�   �� 5�   
   -   5        $��ImgRamka��5�      $y�	Collapsed=�6$   $��Right=�6;   $��	0,0,18,18q�6W   $��Bottom=�6j   $��31��6�   $��31��6�   $��3��6�   #���  6�   5�      5�      