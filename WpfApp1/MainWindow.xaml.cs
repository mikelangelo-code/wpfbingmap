﻿using System.Windows; 
using System.Windows.Input; 

namespace WpfApp1 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() { 
      InitializeComponent();
    }
 
   

   

  

    private void map_MouseMove(object sender, MouseEventArgs e) {
      pin.Location = map.ViewportPointToLocation(e.GetPosition(map));
    }

  
  
  }
}
