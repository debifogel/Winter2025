﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Buses.Core.classes
{
    //1-א-ה
    //2-ו
    //3-מוצש
    public enum Days
    {
        ראשון,
        שני,
        שלישי,
        רביעי,
        חמישי,
        שישי,
        מוצש,

    }
    public class Schdule
    {
        public int Id { get; set; }
        public Days Day { get; set; }
        public TimeOnly TimeStart { get; set; }
        public TimeOnly TimeEnd { get; set; }
        public int frenquecy { get; set; }
    }
    public class TimeOfBus
    {
        public int Id { get; set; }
        Schdule[] SchduleBus { get; set; }
        public TimeOfBus()
        {
            SchduleBus = new Schdule[7];
        }

    }
}
