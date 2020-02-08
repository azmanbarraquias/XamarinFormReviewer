using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.G_DataAccess.Models
{
	public class Earthquake
	{
		public string Eqid { get; set; }
		public float Magnitude { get; set; }
		public float Lng { get; set; }
		public string Src { get; set; }
		public string Datetime { get; set; }

		public string Alpha { get; set; }

		private float depth;

		public float GetDepth()
		{
			return depth;
		}

		public void SetDepth(float value)
		{
			depth = value;
		}

		public float Lat { get; set; }

		public string Data
		{
			get { return string.Format("{0}, {1}, {2}, {3}, {4}", Lat, Lng, Magnitude, GetDepth(), Alpha); }
		}

		public override string ToString()
		{
			return string.Format("Date: {0}, Magnitude: {1}", Datetime.Substring(0, 10), Magnitude);
		}
	}

	public class Rootobject
	{
		public Earthquake[] Earthquakes { get; set; }
	}
}
