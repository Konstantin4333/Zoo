using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using ZooProject.Data;
using ZooProject.Model;

namespace ZooProject.View_Models
{
    class EventsViewModel : ViewModelBase
    {

       

        public ZooDataContext dBContext = new ZooDataContext();
        private List<EventType> eventTypeChoices = new List<EventType>();
        private List<Events> eventss = new List<Events>();
        
        private EventType _eventType;
        private DateTime? _date = null;
        private Events _events;
        public EventType EventType
        {
            get { return _eventType; }
            set
            {
                _eventType = value;
                EventsChoices = null;
                OnPropertyChanged("EventType");
                
            }
        }
       
        public Events Events
        {
            get { return _events; }
            set
            {
                _events = value;

                OnPropertyChanged("Events");
               
            }
        }

        public DateTime? DDate
        {
            get { return _date; }
            set
            {
                _date = value;
                EventType = null;
                EventsChoices = null;
                OnPropertyChanged("DDate");
                
            }
        }
        public void FillEventsCategoryChoices()
        {
            eventTypeChoices = dBContext.eventType
            .Select(catAnim => catAnim).ToList();
        }
        public void FillEvents()
        {
            if (EventType == null && DDate != null)
            {
              
                EventsChoices = dBContext.events.Where(a => a.Date == DDate)
            .Select(a => a).ToList();
               
            }
            else if (EventType != null && DDate == null)
            {
                EventsChoices = dBContext.events.Where(a => a.IdTypeOfEvent == EventType.IdTypeOfEvent)
            .Select(a => a).ToList();
            }
            else if (DDate != null && EventType != null)
            {
                EventsChoices = dBContext.events.Where(a => a.IdTypeOfEvent == EventType.IdTypeOfEvent && a.Date == DDate)
            .Select(a => a).ToList();
            }
            else
            {
                EventsChoices = dBContext.events
                 .Select(a => a).ToList();
            }
        }
        /*public void FillEvents()
        {
            if (EventType != null)
            {
                EventsChoices = dBContext.events.Where(a => a.IdTypeOfEvent == EventType.IdTypeOfEvent)
            .Select(w => w).ToList();
            }else
            {
                EventsChoices = dBContext.events
                 .Select(w => w).ToList();
            }
        }
*/
        public List<EventType> EventChoices
        {
            get { return eventTypeChoices; }
            set
            {

                if (eventTypeChoices != value)
                {
                    eventTypeChoices = value;
                    OnPropertyChanged("EventChoices");
                }
            }
        }
        public List<Events> EventsChoices
        {
            get { return eventss; }
            set
            {

                if (eventss != value)
                {
                    eventss = value;
                  
                    OnPropertyChanged("EventsChoices");
                }
            }
        }


        private DelegateCommand search;


        public ICommand Search
        {
            get
            {
                return search ?? (search = new DelegateCommand(() =>
                {

                   
                    FillEvents();



                }));
            }
        }

        private DelegateCommand clearAll;


        public ICommand ClearAll
        {
            get
            {
                return clearAll ?? (clearAll = new DelegateCommand(() =>
                {


                    EventType = null;
                    EventsChoices = null;
                    DDate = null;



                }));
            }
        }
        public EventsViewModel()
        {
            ViewModelBase viewModelBase;
            
            FillEventsCategoryChoices();
         //  FillEvents();
        }

    }
}
