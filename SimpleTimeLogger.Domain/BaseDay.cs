using System;
using System.Collections;
using System.Collections.Generic;

namespace At.Swb.SimpleTimeLogger.Domain
{
	public abstract class BaseDay
	{
		public DateTime Date { get; protected set; }

		public IList<WorkingTime> Times { get; private set; }

		public string Note { get; set; }

		public BaseDay(DateTime date)
		{
			if (date == null)
			{
				throw new ArgumentNullException("'date' darf nicht null sein!");
			}
			Date = date;
			Times = new List<WorkingTime>();
		}

		public abstract String getDescription();

		public void AddWorkingTime(WorkingTime time)
		{
			if (time == null)
			{
				throw new ArgumentNullException("'time' darf nicht null sein!");
			}
			Times.Add(time);
		}

		public bool IsWeekend()
		{
			DayOfWeek weekday = Date.DayOfWeek;
			return (weekday == DayOfWeek.Saturday || weekday == DayOfWeek.Sunday);
		}
	}
}

