using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
	public abstract class MapSector : INotifyPropertyChanged
	{
		public static int minPosX = 0;
		public int MinPosX
		{
			get
			{
				return minPosX;
			}
			set
			{
				if (value < minPosX)
				{
					minPosX = value;
					OnPropertyChanged("MinPosX");
				}
			}
		}
		public static int maxPosX = 0;
		public int MaxPosX
		{
			get
			{
				return maxPosX;
			}
			set
			{
				if (value > maxPosX)
				{
					maxPosX = value;
					OnPropertyChanged("MaxPosX");
				}
			}
		}

		public static int minPosY = 0;
		public int MinPosY
		{
			get
			{
				return minPosY;
			}
			set
			{
				if (value < minPosY)
				{
					minPosY = value;
					OnPropertyChanged("MinPosY");
				}
			}
		}
		public static int maxPosY = 0;
		public int MaxPosY
		{
			get
			{
				return maxPosY;
			}
			set
			{
				if (value > maxPosY)
				{
					maxPosY = value;
					OnPropertyChanged("MaxPosY");
				}
			}
		}

		int posX;
		public int PosX
		{
			get
			{
				return posX;
			}
			set
			{
				posX = value;
				MinPosX = value;
				MaxPosX = value;
				OnPropertyChanged("PosX");
			}
		}

		int posY;
		public int PosY
		{
			get
			{
				return posY;
			}
			set
			{
				posY = value;
				MinPosY = value;
				MaxPosY = value;
				OnPropertyChanged("PosY");
			}
		}

		int fillType;
		public int FillType
		{
			get
			{
				return fillType;
			}
			set
			{
				fillType = value;
				OnPropertyChanged("FillType");
			}
		}

		public MapSector(int posX, int posY)
		{
			PosX = posX;
			PosY = posY;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName]string property = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
		}
	}
}
