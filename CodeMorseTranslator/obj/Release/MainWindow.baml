   M S B A M L   `   `   `  ���� N  JCodeMorseTranslator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CodeMorseTranslatorCodeMorseTranslator  $    CodeMorseTranslator.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:CodeMorseTranslator     -     � Title$  CodeMorseTranslator��$	��350��$	��525�� � Icon$t nC:/Users/eugen/Documents/Visual Studio 2015/Projects/CodeMorseTranslator/CodeMorseTranslator/bin/Debug/ico.ico��$	��173��$	��206�� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$	 New��  -   $
 Open��  -   $
 Save��  -   $ SaveAs��  -   $ Close��  $	 Cut��  $
 Copy��  $ Paste��.���  � RowDefinitions �� $
��auto ��� $
��auto ��� �� $
��auto ��� �� $
��auto �.+�o� $��0��.@�m� $
��File��.@�m�  m� Command$	 New��m� $
 Open��m� $
 Save��m� $ SaveAs��m� $ Close��m� $
��Edit��.@�m� $	 Cut��m� $
 Copy��m� $ Paste���� $��1��$��28�� �� Orientation$ 
Horizontal=�.+��� -   $��5,5,0,0q�$��23��$	��Top=�.��	Translate�� -   $��lstDirectionOfTranslate��$��5,5,0,0q�$	��125�� � ToolTip$ Direction of translate��.@���  �� 
IsSelected . .��English - Morse�� .��Morse - English�� .��Russian - Morse�� .��Morse - Russian�� -	   $��5,5,0,0q�.��
Sounding�� -
   $��	txtSource��$��2��$��5q�$��14(�	 �� TextWrapping$
	 Wrap=�$
��Auto=�
 �� AcceptsReturn
 . ��  �� ShowsPreview . $��3��$��Stretch=�$��3��
�������$��5,0,5,0q��� -   $��	txtTarget��$��4��$��5q�$��14(�$
	 Wrap=�$
��Auto=��� -   $��	statusBar��$��5��$��22��.@��� -   $��statusBlock��