   M S B A M L   `   `   `  ����G  CCADIfox_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CADIfox_MVVM.ViewCADIfox_MVVM.View  5   	   (    "CADIfox_MVVM.View.LearnToolkitView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CADIfox_MVVM.View     5   	     � Title$  LearnToolkitView��5   	   $	��450��6"   $	��800��6/    � ShowInTaskbar$ False��6;   y�6R   �� *
Visibility+ � 	Resources 5	       �� 
TargetType �� Property �� Value��%S   '��       �� 5
   
   " ��6   .�5      ��  � ��$	 100��6&   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��36 �6   �� 5      $��36 �6   �� 5      $��36 �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��直线��6    � ToolTip$ 画一条直线��6"   ��62   �� *
DrawLine+�� 5      $��图层��6   $ 新建一个图层��6"   ��63   �� *CreateLayer+�� 5      $��线型��6   $ 新建一个线型��6"   ��63   �� *CreateLineType+�� 5      $	��块��6   $ 新建一个块��6!   ��61   �� *CreateBlock+�� 5      $	��圆��6   $ 	新建圆��6!   ��6/   �� *CreateCircle+�� 5      $��删除图元��6   $' !请选择你需要删除的图元��6$   ��6:   �� *DeleteEntity+�� 5      $��圆弧��6   $ 创建一个圆弧��6"   ��63   �� *	CreateArc+�� 5      $��	多段线��6   $ 创建一条多段线��6#   ��65   �� *CreatePolyLine+5      �� 5   
   $��1��6   $ 
Horizontal=�6"   .+�5       �� $��	正方体��6   $ 创建正方体��6#   ��63   �� *
CreateCube+�� 5!      $��	五角星��6   $ 创建五角星��6#   ��63   �� *
CreateStar+�� 5"      $��	五角体��6   $ 创建五角体��6#   ��63   �� *CreateStarSoild+�� 5#      $��自动缩放��6   $ 自动缩放��6$   ��63   �� *
AutoZoom+�� 5$      $��样条曲线��6   $ 创建样条曲线��6$   ��65   �� *CreateNurbs+�� 5%      $��圆锥��6   $ 创建一个圆锥��6"   ��63   �� *
CreateCone+�� 5&      $��获取内轮廓��6   $ 获取内轮廓��6%   ��65   �� *GetTraceBoundary+��5'      �� 	 �� RelativeSource	 �� 
 �� Mode$
 FindAncestor=� �� AncestorType" ��� 5(      $��沿直线创建��6   $ 选择一条直线��6%   ��66   �� *
CreatAlong+��5)      �� 	 �� $
 FindAncestor=�" �5*      �� 5+   
   $��2��6   $ 
Horizontal=�6"   .+�5,      �� $��获取外轮廓��6   $ 获取外轮廓��6%   ��65   �� *GetOutBoundary+��5-      �� 	 �� $
 FindAncestor=�" ��� 5.      $��数字显示��6   $ 输入一堆数字��6$   ��65   �� *CreateDigital+��5/      �� 	 �� $
 FindAncestor=�" �50      51      52      