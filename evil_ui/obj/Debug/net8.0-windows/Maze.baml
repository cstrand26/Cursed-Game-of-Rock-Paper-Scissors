   M S B A M L   `   `   `  ����B  >evil_ui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:evil_uievil_ui  5   	       evil_ui.Maze   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:evil_ui     5   	     � Title$
  Maze��5   	   $	��489��6   $	��815��6#    � 
ResizeMode$ CanMinimize=�6/   .��5	      � -   5         �Name$ MazeGrid��5	      $	��450��6   $	��800��6*   $
|�True��66   $
��Left=�6q   $	��Top=�6�   .+�5   
   �� -   5        $
��Goal��5      $��Center=�6    $��40��6=   $��Center=�6J   $��40��6e   $��0,-8,0,0q�6�   �� 5   
   -   5         ��Name$ 
basePlayer��5      $��0��6(   $��0��63   $��1,1,0,0q�6=   
����� �6N   �� 5   
   -   5        $ BaseWall��5      $
��Left=�6&   $	��Top=�6A   $��10��6Y   $��10��6e   
���   �$��10,0,0,0q�6}   $y�Hidden=�6�   ${�False��6�   �� 5   
   $)��#Use the Arrow Keys to move the box.��6   $
��Left=�6>   $��28��6Y   $��
281,67,0,0q�6e   $	��Top=�6y   $	��185��6�   $��10(�6�   �� 5   
   $/��)Your objective is to hit the center goal.��6   $
��Left=�6D   $��28��6_   $��
281,82,0,0q�6k   $	��Top=�6   $	��185��6�   $��10(�6�   5      5      