   M S B A M L   `   `   `  ����D  @WpfLearn2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfLearn2.Chapter4WpfLearn2.Chapter4  5   	   $    WpfLearn2.Chapter4.TestWindow3   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfLearn2.Chapter4     5   	     � Title$  TestWindow3��5   	   $	��450��6   $	��800��6*    � 	Resources 5	         InventoryData � XPath��%�  &	        � 5
   
   $ Inventory/Books��60   .��5      ��<Supermarket xmlns="">
                    <Fruits>
                        <Fruit Name="Peach" />
                        <Fruit Name="Banana" />
                        <Fruit Name="Orange" />
                    </Fruits>
                    <Drinks>
                        <Drink Name="Coca Cola" />
                        <Drink Name="PEPSI Cola" />
                    </Drinks>
                </Supermarket>        5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5#   
   �� $��0��6   .+�5$      �� -   5         ��Name$ tb��5$      
�������6$   �� 5%      -   5        $��50��5%      $	��100��6    6-   5&      �� 51   
   $��1��6   .+�52      �� #��[  6   53      54      55      