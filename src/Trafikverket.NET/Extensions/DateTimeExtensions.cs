using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikverket.NET
{
	/// <summary>
	/// Extensions for System.DateTime class
	/// </summary>
	public static class DateTimeExtensions
	{
		/// <summary>
		/// Format date time as required by train api
		/// </summary>
		/// <param name="dateTime">DateTime to format</param>
		/// <returns>Formatted DateTime as string</returns>
		public static string TrainApiDateTimeFormat(this DateTime dateTime)
		{
			return dateTime.ToString("yyyy-MM-ddTHH:mm:ss.00Z");
		}
	}
}
