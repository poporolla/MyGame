using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MyGame
{
	public class MyGameMap : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string property = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
		}
		private Grid fieldGrid;
		public Grid FieldGrid
		{
			get
			{
				return fieldGrid;
			}
			set
			{
				fieldGrid = value;
				OnPropertyChanged("FieldGrid");
			}
		}




		ScaleTransform scaleTransform = new ScaleTransform(1, 1);
		public ScaleTransform ScaleTransform
		{
			get
			{
				return scaleTransform;
			}
			set
			{
				scaleTransform = value;
				OnPropertyChanged("ScaleTransform");
			}
		}

		public ObservableCollection<MapSector> MapSectors { get; set; }

		public MyGameMap(Grid fieldGrid)
		{
			this.fieldGrid = fieldGrid;
			fieldGrid.ColumnDefinitions.

			MapSectors = new ObservableCollection<MapSector>()
			{
				new MyMapSector( -1, 1),
				new MyMapSector( 0, 1),
				new MyMapSector(1,1),
				new MyMapSector(-1,0),
				new MyMapSector(0,0),
				new MyMapSector(1,0),
				new MyMapSector(-1,-1),
				new MyMapSector(0,-1),
				new MyMapSector(1,-1)
			};
		}

		private void BuildRectangles()
		{
			foreach(MapSector mapSector in MapSectors)
			{
				
			}
		}

		private RelayCommand scaleCommand;
		public RelayCommand ScaleCommand
		{
			get
			{
				return scaleCommand ??
					(scaleCommand = new RelayCommand(obj =>
					{
						Point point = Mouse.GetPosition(FieldGrid);
						MouseWheelEventArgs eventArgs = obj as MouseWheelEventArgs;
						if (ScaleTransform.ScaleX < 4 && eventArgs.Delta > 0)
						{
							ScaleTransform.ScaleX += 0.05;
							ScaleTransform.ScaleY += 0.05;
						}
						else if (ScaleTransform.ScaleX > 0.1 && eventArgs.Delta < 0)
						{
							ScaleTransform.ScaleX -= 0.05;
							ScaleTransform.ScaleY -= 0.05;
						}
						ScaleTransform.CenterX = point.X;
						ScaleTransform.CenterY = point.Y;
						fieldGrid.RenderTransform = ScaleTransform;
					}));
			}
		}


	}
}
