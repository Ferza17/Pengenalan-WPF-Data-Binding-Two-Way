   M S B A M L   `   `   `  ����L  HAplikasiLoginPer4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AplikasiLoginPer4AplikasiLoginPer4  5   	   "    AplikasiLoginPer4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:AplikasiLoginPer4     5   	     � Title$  
MainWindow��5   	   $��495.036��6   $��483.735��6-   .��5	      �� ���	#FF90DFAA$��0,0,0,-8q�6(   .+�5
   
   �� -   5         ��Name$ header��5
      $��LOGIN��6    $��55��60   $
��Bold"�6<   $��36(�6N   $��Center=�6\   $��Center=�6~   
�������6�   �� 5   
   $	��398��6   
�������$
��10,0q�61   .+�5      �� -   5         ��Name$ 
loginImage��5      $	��116��6(    �� Left$	 177��65   
 �� Top$ 10��6G   $	��116��6W   $��Asset/Images/user.png��6c   �� 5      -   5         ��Name$ txtUsername��5      $��28��6+   $	 105��67    �� TextWrapping$
 Wrap=�6I   $	 166��6�   $	��256��6�   
������� �� SelectionBrush �	#FF90DFAA��6]   �� *
Username+ �� Mode$ TwoWay=�6�   �� 5      -   5        $ txtPassword��5      $��28��6+   $	 105��68   $
 Wrap=�6J   $	 243��6�   $	��256��6�    �	#FF90DFAA��6^   �� *
Password+$ TwoWay=�6�   �� 5      -   5        	 ��Name$	 btnLogin��5      $��Login��6'   $	 105��67   $	 300��6I   $	��256��6Z   ���	#FF90DFAA
�������$��34��6�   $��16(�6�   $
��Bold"�6�   $��Segoe UI Semibold)�6�   
 J� OpacityMask
 �	#FF060000��6f   Z� 6
  �� 5      -   5        $ userNameLabel��5      $��username��6+   $��12(�6>   $	 107��6L   $	 140��6^   ���	#FFBEC6D3$
��Bold"�6�   �� 5      -   5        $ passwordLabel��5      $��Password��6+   $��12(�6>   $	 107��6L   $	 217��6^    J� RenderTransformOrigin$ 	1.213,0.5&�6o   $
��Bold"�6�   ���	#FFBEC6D76�   �� 5      -   5        $ lblUsernameStatus��5      $��8(�6b   $	 107��6o   $	 199��6�   ���	#FFE64C34$
��Bold"�6�   ��6/   ��  �� Path$ CheckUsername�$ TwoWay=�6�   �� 5      -	   5        $ lblPasswordStatus��5      $��8(�6c   $	 107��6p   $	 276��6�   ���	#FFE64C34$
��Bold"�6�   ��6/   �� $ CheckPassword�$ TwoWay=�6�   5      5      5      