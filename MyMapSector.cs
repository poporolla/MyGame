using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
	public class MyMapSector : MapSector
	{
		public MyMapSector(int posX, int posY)
			: base(posX, posY)
		{
			FillType = 0;
		}
	}
}
