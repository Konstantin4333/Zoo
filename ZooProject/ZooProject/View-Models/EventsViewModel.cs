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
        private Events _events;
        public Events Events
        {
            get { return _events; }
            set
            {
                _events = value;

                OnPropertyChanged("Events");
               
            }
        }

        public void FillEventsCategoryChoices()
        {
            eventTypeChoices = dBContext.eventType
            .Select(catAnim => catAnim).ToList();
        }
        public void FillEvents()
        {
            if (EventType != null)
            {
                eventss = dBContext.events.Where(a => a.IdOfEvent == EventType.IdTypeOfEvent)
            .Select(w => w).ToList();
            }else
            {
                eventss = dBContext.events
                 .Select(w => w).ToList();
            }
        }
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
        public EventsViewModel()
        {
            ViewModelBase viewModelBase;
            
            FillEventsCategoryChoices();
            FillEvents();
        }

    }
}
