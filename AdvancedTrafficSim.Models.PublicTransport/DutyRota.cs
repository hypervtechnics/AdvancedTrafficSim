using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTrafficSim.Models.PublicTransport
{
    public class DutyRota
    {
        private List<ScheduleItem> jobs;
        private long iD;

        public DutyRota(List<ScheduleItem> jobs, long iD)
        {
            Jobs = jobs;
            ID = iD;
        }

        public List<ScheduleItem> Jobs { get => jobs; set => jobs = value; }
        public long ID { get => iD; set => iD = value; }
    }
}
