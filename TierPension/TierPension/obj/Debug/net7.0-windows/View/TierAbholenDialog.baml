   M S B A M L   `   `   `  ����F  BTierPension, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TierPension.ViewTierPension.View  5   	   (    "TierPension.View.TierAbholenDialog   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TierPension.View     5   	     � Title$  Tier-Abholen��5   	   .��5	      � $��20q�6    � ColumnDefinitions 5
   
   �� 5      $��* �6   $	��180��6)    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6"   $��Tier-Abholen��63   $��Center=�6G      H1#��[  6d   �� 5   
   $��1��6   $��0��6"   $2��,Wähle eines deiner pensionierten Tiere aus!��63   $��Center=�6f   �� 5   
   -   5         ��Name$ TierComboBox��5       $��2��5      $��0��6    $
��10 0q�60   ��5      �� *TiereDesKunden+ �� SelectedItem 5      �� *SelectedTier+��5"      �� 5#      .R�5$      �� ��6    �� *Name+5%      5'      �� 5*   
   $��3��6   $��0��6"   $��Ausgewähltes Tier:��62   $��Center=�6L   �� 5+   
   $��4��6   $��0��6"   $��Center=�6U   $��24(�6r   ��62   �� *SelectedTier.Name+6r   �� 5/   
   $��5��6   $��0��6"   
���  ����63   �� *ErrorMessage+6Q   �� 51   
   $��6��6   $��0��6"   .+�52      ��   RechnungButtonStyle#��[ 6   ��6B   �� *RechnungCommand+�� 53      $��Rechnung anzeigen��6   $��Center=�61   54      � 57   
   $��11��6   $��0��6    58      �� 59      $��* �6#   �� 5:      $��* �6#    5<      �� 5=      $
��Auto �6    .+�5@      �� $��0��6   .+�5A      ��   AbbrechenButtonStyle#��[ 6   
���������6^   �� *AbbrechenCommand+�� 5B      $��	Abbrechen��6   $��Center=�6-   5C      �� 5D      $��1��6   .+�5E      �� -   5         ��Name$ abholenButton��5E   �     CheckButtonStyle#��[ 6   
��������6[   �� *AbholenOderLoeschenCommand+6�   �� 5F      -   5         ��Name$ 
buttonText��5F      $��abholen��60   $��Center=�6?   5G      5I      5J      5K      