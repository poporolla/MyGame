using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyGame
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			this.DataContext = new ApplicationViewModel(playField);
		}
		//private ScaleTransform scaleTransform = new ScaleTransform(1, 1);
		//private void playField_MouseWheel(object sender, MouseWheelEventArgs e)
		//{
		//	Grid grid = sender as Grid;
		//	if (scaleTransform.ScaleX < 4 && e.Delta > 0)
		//	{
		//		scaleTransform.ScaleX += 0.05;
		//		scaleTransform.ScaleY += 0.05;
		//	}
		//	else if(scaleTransform.ScaleX > 0.1 && e.Delta < 0)
		//	{
		//		scaleTransform.ScaleX -= 0.05;
		//		scaleTransform.ScaleY -= 0.05;
		//	}
		//	Point point = Mouse.GetPosition(grid);
		//	scaleTransform.CenterX = point.X;
		//	scaleTransform.CenterY = point.Y;

		//	grid.RenderTransform = scaleTransform;
		//}
	}
}
