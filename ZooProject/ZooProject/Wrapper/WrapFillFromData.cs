using DataBaseServicee.DataContext;
using DataBaseServicee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using ZooProject.View_Models;

namespace ZooProject.Wrapper
{
    public static class WrapFillFromData
    {
        private static ZooDataContext dBContext = new ZooDataContext();
        public static List<Events> ChoiceEvent = new List<Events>();
       // static  EventsViewModel events = new EventsViewModel();
        public static List<Events> FillEvents(DateTime? DDate, EventType EventType)
        {
            if (EventType == null && DDate != null)
            {

                return  dBContext.events.Where(a => a.Date == DDate)
            .Select(a => a).ToList();

            }
            else if (EventType != null && DDate == null)
            {
                return dBContext.events.Where(a => a.Id == EventType.Id)
            .Select(a => a).ToList();
            }
            else if (DDate != null && EventType != null)
            {
                return dBContext.events.Where(a => a.Id == EventType.Id && a.Date == DDate)
            .Select(a => a).ToList();
            }
            else
            {
                return dBContext.events
                 .Select(a => a).ToList();
            }
           
        }
    }
}
