// Author: Sebastian Biebl
// Webseite: www.software-biebl.at
// Copyright 2017
using System;

namespace At.Swb.SimpleTimeLogger.Domain
{
	public class WorkingTime
	{
		public TimeSpan Start { get; set; }

		//public TimeSpan InitStart { get; set; }

		public TimeSpan End { get; set; }

		//public TimeSpan InitEnd { get; private set; }

		public string Description { get; set; }

		public bool WholeDay { get; private set; }

		public WorkingTime(bool wholeDay, String description)
		{
			WholeDay = wholeDay;
			Description = description;
			//initStart = LocalTime.now();
			//initEnd = LocalTime.now();
		}

		public WorkingTime(TimeSpan start, TimeSpan end, String description)
		{
			if (start == null)
			{
				throw new ArgumentNullException("'start' darf nicht null sein!");
			}
			Start = start;
			//initStart = LocalTime.now();
			End = end;
			/*if(end != null) {
            initEnd = LocalTime.now();
        	}*/
			Description = description;
		}
	}
}

