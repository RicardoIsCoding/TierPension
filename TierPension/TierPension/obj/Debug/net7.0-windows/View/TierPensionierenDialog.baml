   M S B A M L   `   `   `  ����F  BTierPension, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TierPension.ViewTierPension.View  5   	   -    'TierPension.View.TierPensionierenDialog   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TierPension.View     5   	     � Title$  Tier-Pensionieren��5   	   .��5
      � $��20q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   $	��180��6)   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��10 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6"   $��2��62   $��Tier-Pensionieren��6F   $��Center=�6_      H1#��[  6|   �� 5!   
   $��1��6   $��0��6"   $��2��62   $$��Wähle eines deiner Tiere aus!��6F   $��Center=�6k   �� 5"   
   $��2��6   $��0��6    $��2��60   $
��10 0q�6D    �� DisplayMemberPath$
 Name��5#   X   ��6   �� *TiereDesKunden+ �� SelectedItem 62   �� *SelectedTier+6X   �� 5&   
   $��5��6   $��0��6"   $��2��62   $��Pensionierungszeit��6F   $��Center=�6`   �� 5'   
   $��6��6   $��0��6"   $��Abgabedatum*��62   (  "System.Windows.Controls.DatePicker  5(   
   $��6��6   $��1��6"      SelectedDate 62   �� *AbgabeDatum+�� 5)   
   $��7��6   $��0��6"   $��Abholdatum*��62     5*   
   $��7��6   $��1��6"    62   �� *
AbholDatum+�� 5+   
   $��8��6   $��0��6"   $ ��*... zwingend erforderlich��62   $��10(�6T   �� 5.   
   $��9��6   $��0��6"   $��2��62   
���  ����6F   �� *ErrorMessage+6d   � 51   
   $��10��6   $��0��6   $��2��6-    52      �� 53      $��* �6#   �� 54      $��* �6#    56      �� 57      $
��Auto �6    .+�5:      �� $��0��6   .+�5;      ��   AbbrechenButtonStyle#��[ 6   
���������6^   �� *AbbrechenCommand+�� 5<      $��	Abbrechen��6   $��Center=�6-   5=      �� 5>      $��1��6   .+�5?      ��   CheckButtonStyle#��[ 6   
��������6[   �� *SpeichernCommand+�� 5@      $��pensionieren��6   $��Center=�60   5A      5C      5D      5E      