   M S B A M L   `   `   `  ����F  BTierPension, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TierPension.ViewTierPension.View  5   	   =#clr-namespace:TierPension.ViewModelTierPension.ViewModel  5   	   -    'TierPension.View.NeuesTierAnlegenDialog   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TierPension.View     5   	   2VM#clr-namespace:TierPension.ViewModel     5   	     � Title$  Neues Tier anlegen��5	   	   $
��Auto��5
   	   $
��Auto��6   .��5      � $��20q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   $	��180��6)   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��10 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $
��Auto �6   .+�5    
   �� $��0��6   $��0��6"   $��2��62   $��Tier-Informationen��6F   $��Center=�6`      H1#��[  6}   �� 5!   
   $��1��6   $��0��6"   $��Name*��62   �� 5"   
   $��1��6   $��1��6"   $	��200��6H   ��62   �� *Name+6H   �� 5#   
   $��2��6   $��0��6"   $��Tierart*��62   �� 5$   
   $��2��6   $��1��6"   ��62   �� *	Tierart+ �� SelectedItem 6R   �� *SelectedTierart+�� 5%   
   $��3��6   $��0��6"   $��Futter*��62   �� 5&   
   $��3��6   $��1��6"   ��62   �� *Futter+ 6Q   �� *SelectedFutter+�� 5)   
   $��9��6   $��0��6"   $��2��62   
���  ����6F   �� *ErrorMessage+6d   � 5,   
   $��10��6   $��0��6   $��2��6-    5-      �� 5.      $��* �6#   �� 5/      $��* �6#    51      �� 52      $
��Auto �6    .+�55      �� $��0��6   .+�56      ��   AbbrechenButtonStyle#��[ 6   
���������6^   �� *AbbrechenCommand+�� 57      $��	Abbrechen��6   $��Center=�6-   58      �� 59      $��1��6   .+�5:      ��   SaveButtonStyle#��[ 6   
��������6Z   �� *SpeichernCommand+�� 5;      $��Tier anlegen��6   $��Center=�60   5<      5>      5?      5A      