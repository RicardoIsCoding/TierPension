   M S B A M L   `   `   `  ����F  BTierPension, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TierPension.ViewTierPension.View  5      7 clr-namespace:TierPension.HelperTierPension.Helper  5      #    TierPension.View.Registrieren   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:TierPension.View     5      3helper clr-namespace:TierPension.Helper     5        N� 
Background
  �����#��Z��5
      #��Z��5       N� Title$ Registrieren��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5       $��* �6   �� 5!      $��30 �6   �� 5"      $��* �6   .+�5%   
   �� $��0��6   $��0��6&   .+�5&      �� $��Bild hochladen��6   ��62   �� *UploadImageCommand+�� 5'      $	��100��6J   $	��100��6W   ��6   �� *ProfileImagePath+ �� Mode$ TwoWay=�6W   5(      �� 5*   
   $��0��6   $��1��6&   $��2��66   $��Registrieren-Seite��6J   �� 5+   
   $��1��6   $��0��6&   $��	Vorname*:��66   �� 5,   
   $��1��6   $��1��6&   ��66   �� *	Vorname+�� 5-   
   $��1��6   $��2��6&   $��
Passwort*:��66   G� 5.   
   -   5        $��1��5.      $��3��6&   '   !TierPension.Helper.PasswordHelper   Attach$
 True��6d      Password 5/      �� *
Passwort+ �� ElementName$ plain��$ TwoWay=��� 50   
   $��2��6   $��0��6&   $��	Nachname*��66   �� 51   
   $��2��6   $��1��6&   ��66   �� *
Nachname+�� 52   
   $��2��6   $��2��6&   $��Passwort wdh*.:��66   G� 53   
   -   5        $��2��53      $��3��6&    G� Password$  ��66   6B   �� 54   
   $��3��6   $��0��6&   $��E-Mail Adresse*:��66   �� 55   
   $��3��6   $��1��6&   ��66   �� *EMail+�� 56   
   $��3��6   $��2��6&   $��Nutzername*:��66   �� 57   
   $��3��6   $��3��6&   ��66   �� *
Username+�� 58   
   $��4��6   $��2��6&   ��66   �� �� 5:   
   $��7��6   $��0��6&   $��50��66   $��50��6A   $��20q�6M   
���  ����6Y   �� *ZurueckCommand+.��5;      �� $��..\Icons\exit.png��6   $��30��6/   $��30��6:   5<      �� 5=   
   -   5        	 ��Name$	 register��5=   �   $��5��6   $��1��6&   $��2��66   $��50 30q�6J   $��registrieren��6Y   
��� � ���6p   �� *RegistrierenCommand+6�   �� 5?   
   $��6��6   $��0��6&   $��4��66   $C��=Vervollständigen sie die Angaben (* sind zwingend notwendig)��6J   $��16(�6�   y�6�   �� *ErrorMessageVisibility+5@      5A      