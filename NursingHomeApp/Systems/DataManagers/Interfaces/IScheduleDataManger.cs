﻿using NursingHomeApp.Systems.DataMangers.Interfaces;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomeApp.Systems.DataManagers.Interfaces
{
    public interface IScheduleDataManger : IDefaultDataManager<Schedule, ScheduleView>
    {
        List<Schedule> SelectIdPatient(int Id);
        List<Schedule> SelectIdEmployee(int Id);
    }
}