   M S B A M L   `   `   `  ����D  @WpfLearn2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfLearn2.Chapter4WpfLearn2.Chapter4  5   	   $    WpfLearn2.Chapter4.TestWindow2   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfLearn2.Chapter4     5   	   $   WpfLearn2.Chapter4.TestWindow2    MyTitle � Title# Z  5   	   $	��500��66   $	��800��6C    � 	Resources 5
       �� 
TargetType �� Property �� Value   MyButton��%Z  '��       &	  �     �� 5   
   " ��6(   .�5      ��  � ��$	 200��6&   �� 5       � ��$ 50��6'   �� 5       � ��$ 5q�6'   5      �� 5   
   " ��6!   .�5      ��  � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       � ��$ 5q�6'   �� 5       � ��
 �����6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��50px �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5"   
   �� $��0��6   .+�5%      !  WpfLearn2.Chapter4.myButton  $
��Show��6      UserWindowType!   WpfLearn2.Chapter4.myWindow"  6,   $��5q�6^   5&      �� 5)   
   $��1��6   .+�5+      �� $��1��6   �� 5-      $��2��6   #��[  6!   �� 5/      $��3��6   $��5q�6!   ��6,   Z� 50      �� 53   
   $��2��6   55      �� 58   
   $��3��6   .+�59      ��    	MyContent#��Z 6   $��32(�6D   5:      5;      5<      