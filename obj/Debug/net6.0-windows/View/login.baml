   M S B A M L   `   `   `  ����E  AMosaicoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MosaicoApp.ViewMosaicoApp.View  5   	   ;"clr-namespace:MosaicoApp.ViewModelMosaicoApp.ViewModel  5   	       MosaicoApp.View.Login   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MosaicoApp.View     5   	   1vm"clr-namespace:MosaicoApp.ViewModel     5   	   c _MaterialDesignThemes.MahApps, Version=2.1.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   apiserverclient   5	   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	    � Title$ Login��5   	   $	��450��6   $	��600��6$    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�6#    � 
ResizeMode$ NoResize=�5   	   
������  � 	Resources 5        backgroundColor �� Color  foregroundColor'  !MaterialDesignThemes.Wpf.PackIcon	   Kind  	iconClose  iconMinimize#  MaterialDesignThemes.Wpf.Card
 �� 
TargetType �� Property �� Value$   MosaicoApp.ViewModel.MosaicoVM  vm��%$  &	       &	 !     &	 B     &	 f     '  �     7  &	 �     �� 5   
   $ #343a40��62   �� 5   
   $ #f8f9fa��62     5   
   $	 Close=�6"   6/     5   
   $	 Minimize=�6"   62   �� 5   
   "
  6   .�5      ��  � ��8   6+   5        5   
   6   5       .��5#        .��5$   
   ]�  � DataContext# [ 6   .+�5&      �� $	��Top=�6    �� Orientation$ 
Horizontal=�5'      $��Right=�5(      $��4q�5)      .+�5*      �� -   5         ��Name$ MinimizeWindowButton��5+      $��45��5,      $��25��5-      #��[ 5.       # MaterialDesignRaisedLightButton#��[ 50       � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��51      $��0 0 5 0q�52      {�5/      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window54      �� 55      -   5        $ CloseWindowButton��56      $��45��57      $��25��58      #��[ 59      #��[ 5;      $4 .Resource name: MaterialDesignRaisedLightButton��5<      $��0 0 5 0q�5=      {�5:      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5?      5@      �� 5A      $��Center=�6   $��Center=�5B      .+�5C      �� $��Center=�6   $��	0 10 0 10q�69    $  MaterialDesignHeadline3TextBlock#��[ 5D      $��Segoe UI)�5E      #��[ 5F      $��Mosaico Login��5G      �� 5H      -   5         ��Name$ UsernameTextBox��5I      $��18(�5J      
�������)  #MaterialDesignThemes.Wpf.HintAssist   
HelperText$ Ex: usuário1��5L         HelperTextFontSize$ 13Q�5M         Hint$ Usuário��5N      $	��190��5O      $��10q�5Q      ��5P      �� *
Username+.��5Q   !   5R      �� 5T      -   5        $ PasswordTextBox��5U      $��18(�5V      
�������$ Ex: password123#��5X      $ 13Q�5Y      $ Senha��5Z      $	��190��5[      $��10q�5]      ��5\      �� *
Password+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��5]   !   5^      �� 5a      $��0 20 0 0q�5b      $	��180��5c      $��Entrar��5d       	 MaterialDesignRaisedButton#��[	 5h      $ Entrar no sistema.��5i      ��5e      �� *loginCommand+��5f      �� *User+{�5g      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window5i      5k      5l      5m      5o      