   M S B A M L   `   `   `  ����F  BTierPension, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TierPension.ViewTierPension.View  5      7 clr-namespace:TierPension.HelperTierPension.Helper  5          TierPension.View.Anmelden   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:TierPension.View     5      3helper clr-namespace:TierPension.Helper     5        N� Title$  Anmelden��5
       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6&   $��2��66   $��Willkommen zurück!��6J   $��48(�6d   �� 5   
   $��2��6   $��1��6&   $��Benutzername��66   �� 5   
   $��3��6   $��1��6&   $��10, 0q�6P   ��66   �� *
Username+6P   �� 5!   
   $��2��6   $��2��6&   $��Passwort��66   G� 5"   
   -   5        $��3��5"      $��2��6&   '   !TierPension.Helper.PasswordHelper   Attach$
 True��6d   �� 5$   
   $��5��6   $��0��6&   $��20 30q�66   $��zurück��6E   
���  ����6V   �� *ZurueckCommand+6y   �� 5%   
   -   5         ��Name$ register��5%   �   $��5��6   $��1��6&   $��2��66   $��50 30q�6J   $��anmelden��6Y   
��� � ���6l   �� *AnmeldenCommand+6�   5'      5(      