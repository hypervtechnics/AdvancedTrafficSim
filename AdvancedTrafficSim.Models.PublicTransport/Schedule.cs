using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTrafficSim.Models.PublicTransport
{
    public class Schedule
    {
        private long iD;
        private List<ScheduleItem> items;
        private List<DateTime> exceptions;

        public Schedule(long iD, List<ScheduleItem> items, List<DateTime> exceptions)
        {
            ID = iD;
            Items = items;
            Exceptions = exceptions;
        }

        public long ID { get => iD; set => iD = value; }
        public List<ScheduleItem> Items { get => items; set => items = value; }
        public List<DateTime> Exceptions { get => exceptions; set => exceptions = value; }
    }
}
