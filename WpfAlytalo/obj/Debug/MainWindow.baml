   M S B A M L   `   `   `  ����E  AWpfAlytalo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfAlytalo
WpfAlytalo  5   	       WpfAlytalo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfAlytalo     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ lblSmartHouse��5
      $"��Welcome to your Smart House ��6'   $
��Left=�6N   $��	10,10,0,0q�6i   $	��Top=�6|   $	��772��6�   $��85��6�   ���	#FFE2E2E2$��Center=�6�   $��Center=�6�   $��24(�6	  $
��Bold"�6  ���	#FF959595$��1q�6A  �� 5   
   -   5        $ lblHouseTemperature��5      $��House Temperature��6-   $
��Left=�6I   $	��Top=�6d   $��180,115,0,0q�6|   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5        $ lblSetNewTemperature��5      $��Set New Temperature��6.   $
��Left=�6L   $	��Top=�6g   $��425,115,0,0q�6   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txtHouseTemperature��5      $
��Left=�6/   $��50��6J   $��180,162,0,0q�6V    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��194��6�   $��Center=�6�   $��Center=�6�   {�.  $��24(�6�   $
��Bold"�6	  �� 5   
   -   5        $ txtSetNewTemperature��5      $
��Left=�60   $��50��6K   $��425,162,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��100��6�   $��Center=�6�   $��Center=�6�   $��20(�6�   �� 5   
   -   5         ��Name$ btnSetNewTemperature��5      $	��SET��6/   $
��Left=�6=   $	��Top=�6X   $	��108��6p   $��530,162,0,0q�6|   $��50��6�   $��20(�6�   �� 5   
   -   5        $ 	lblLights��5      $��Lights��6#   $
��Left=�64   $	��Top=�6O   $��
18,232,0,0q�6g   $��20(�6{   $
��Bold"�6�   �� 5   
   -   5        $ lblLivingRoomLights��5      $��Living room lights��6-   $
��Left=�6J   $	��Top=�6e   $��
18,356,0,0q�6}   $��16(�6�   �� 5   
   -	   5        $ lblKitchenLights��5      $��Kitchen lights��6*   $
��Left=�6C   $	��Top=�6^   $��
18,274,0,0q�6v   $��16(�6�   �� 5   
   -
   5         ��Name$ sliderKitchenLights��5      $
��Left=�6.   $	��Top=�6I   $	��200��6a   $��
18,315,0,0q�6m    � Maximum$	 100Q�6�   6�   �� 5   
   -   5        $ txtKitchenLightsValue��5      $
��Left=�61   $��41��6L   $��223,304,0,0q�6X   $
 Wrap=�6m   $	��Top=�6�   $��50��6�   {�.  $��Center=�6�   $��Center=�6�   $��20(�6�   $
��Bold"�6
  �� 5   
   -   5        $ sliderLivingRoomLights��5      $
��Left=�61   $	��Top=�6L   $	��200��6d   $��
18,397,0,0q�6p   $	 100Q�6�   6�   �� 5   
   -   5        $ txtLivingRoomLightsValue��5      $
��Left=�64   $��41��6O   $��223,386,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $��50��6�   {�.  $��Center=�6�   $��Center=�6�   $��20(�6�   $
��Bold"�6  �� 5   
   -   5        $ lblSauna��5      $��Sauna��6"   $
��Left=�62   $	��Top=�6M   $��468,299,0,0q�6e   �� 5   
   -   5        $ lblSetSaunaTemperature��5      $��Set Sauna Temperature��60   $
��Left=�6P   $	��Top=�6k   $��587,299,0,0q�6�   �� 5   
   -   5        $ txtSaunaTemperature��5      $
��Left=�6/   $��50��6J   $��471,325,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��111��6�   $��Center=�6�   $��Center=�6�   {�.  6�   �� 5   
   -   5        $ txtSetSaunaTemperature��5      $
��Left=�62   $��27��6M   $��587,325,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��132��6�   $��Center=�6�   $��Center=�6�   �� 5    
   -   5        $ btnSetSaunaTemperature��5       $	��SET��61   $
��Left=�6?   $	��Top=�6Z   $��77��6r   $��587,355,0,0q�6}   6�   �� 5!   
   -   5        $ btnSetSaunaOff��5!      $	��OFF��6)   $
��Left=�67   $	��Top=�6R   $��50��6j   $��669,355,0,0q�6u   6�   5$      5%      