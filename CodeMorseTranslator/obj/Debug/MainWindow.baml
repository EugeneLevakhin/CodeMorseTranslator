   M S B A M L   `   `   `  ����N  JCodeMorseTranslator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CodeMorseTranslatorCodeMorseTranslator  5   	   $    CodeMorseTranslator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CodeMorseTranslator     5   	   -   5          � Title$  CodeMorseTranslator��5   	   $	��350��6%   $	��525��62    � Icon$t nC:/Users/eugen/Documents/Visual Studio 2015/Projects/CodeMorseTranslator/CodeMorseTranslator/bin/Debug/ico.ico��6W   $	��173��5	   	   $	��206��6    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$	 New��5      6P     5   
   -   5        $
 Open��5      6R     5   
   -   5        $
 Save��5      6~     5   
   -   5        $ SaveAs��5      6�     5   
   -   5        $ Close��5      6T     5   
   $	 Cut��6   6)     5   
   $
 Copy��6   6*     5   
   $ Paste��6   6+   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   �� 5      $
��auto �6   6,   �� 5      6   �� 5      $
��auto �6   6,   .+�5   
   o� $��0��6   .@�5      m� $
��File��6   .@�5      m�  m� Command$	 New��6   6+   m� 5       $
 Open��6   6,   m� 5!      $
 Save��6   6,   m� 5"      $ SaveAs��6   6.   m� 5#      $ Close��6   6-   5$      m� 5%      $
��Edit��6   .@�5&      m� $	 Cut��6   6+   m� 5'      $
 Copy��6   6,   m� 5(      $ Paste��6   6-   5)      5*      �� 5+   
   $��1��6   $��28��6"    �� Orientation$ 
Horizontal=�6.   .+�5,      �� -   5        $��5,5,0,0q�5,      $��23��6D   $	��Top=�6P   .��6h   	Translate6s   �� 5-      -   5        $��lstDirectionOfTranslate��5-      $��5,5,0,0q�66   $	��125��6G    � ToolTip$ Direction of translate��6S   .@�5.      ��  �� 
IsSelected . .��61   English - Morse6B   �� 5/      .��6   Morse - English60   �� 50      .��6   Russian - Morse60   �� 51      .��6   Morse - Russian60   52      �� 53      -	   5        $��btnPlay��53      $��5,5,0,0q�6$   {�.  $��Play selected Morse��6`   54      �� 55   
   -
   5        $��	txtSource��55      $��2��6#   $��5q�60   $��14(�6;   	 �� TextWrapping$
	 Wrap=�6I   $
��Auto=�6�   
 �� AcceptsReturn
 . 6�   �� 56   
    �� ShowsPreview . $��3��6+   $��Stretch=�68   $��3��6V   
�������$��5,0,5,0q�6s   6�   �� 57   
   -   5        $��	txtTarget��57      $��4��6#   $��5q�60   $��14(�6;   $
	 Wrap=�6I   $
��Auto=�6]   6�   �� 58   
   -   5        $��	statusBar��58      $��5��6%   $��22��62   .@�59      �� -   5        $��statusBlock��59      6-   5:      5;      5<      