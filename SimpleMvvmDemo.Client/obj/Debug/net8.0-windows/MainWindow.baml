   M S B A M L   `   `   `  ����P  LSimpleMvvmDemo.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SimpleMvvmDemo.ClientSimpleMvvmDemo.Client  5      &     SimpleMvvmDemo.Client.MainWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:SimpleMvvmDemo.Client     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��525��5	      $	��280��5
       � WindowStartupLocation$ CenterScreen=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ btnSave��5      $
��Save��5      ��5      �� *SaveCommand+5      � 5   
   $��1��6    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� -   5         ��Name$	 tb1��5      $��0��5      $��4q�5       
����ح�$��24(�5"      ��5#      �� *Input1+�� 5$      -   5        $	 tb2��5%      $��1��5&      $��4q�5'      
����ح�$��24(�5)      ��5*      �� *Input2+�� 5+      -   5        $	 tb3��5,      $��2��5-      $��4q�5.      
����ح�$��24(�50      ��51      �� *Result+�� 52      -   5        $ btnAdd��53      $��3��54      $	��120��55      $��80��56      $��4q�57      $	��Add��59      ��58      �� *
AddCommand+59      5:      5;      5<      