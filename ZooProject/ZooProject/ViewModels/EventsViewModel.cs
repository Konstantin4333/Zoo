using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using DataBaseServicee.DataContext;

using DataBaseServicee.Model;

namespace ZooProject.View_Models
{
    class EventsViewModel : ViewModelBase
    {


        #region Fields
        public ZooDataContext dBContext = new ZooDataContext();
        private List<EventType> eventTypeChoices = new List<EventType>();
        private List<Events> eventss = new List<Events>();
        private EventType _eventType;
        private DateTime? _date = null;
        private Events _events;
        #endregion
        #region Properies & Lists
        public EventType EventType
        {
            get { return _eventType; }
            set
            {
                _eventType = value;

                FillEvents();
                OnPropertyChanged(nameof(EventType));

            }
        }

        public Events Events
        {
            get { return _events; }
            set
            {
                _events = value;

                OnPropertyChanged(nameof(Events));

            }
        }

        public DateTime? DDate
        {
            get { return _date; }
            set
            {
                _date = value;

                FillEvents();
                OnPropertyChanged(nameof(DDate));

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
                    OnPropertyChanged(nameof(EventChoices));

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

                    OnPropertyChanged(nameof(EventsChoices));
                }
            }
        }

        #endregion
        //OPRAVI GO
        #region FILL FROM DATA 
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
                EventsChoices = dBContext.events.Where(a => a.Id == EventType.Id)
            .Select(a => a).ToList();
            }
            else if (DDate != null && EventType != null)
            {
                EventsChoices = dBContext.events.Where(a => a.Id == EventType.Id && a.Date == DDate)
            .Select(a => a).ToList();
            }
            else
            {
                EventsChoices = dBContext.events
                 .Select(a => a).ToList();
            }
        }
        #endregion
        #region Commands
        private DelegateCommand clearAll;


        public ICommand ClearAll
        {
            get
            {
                return clearAll ?? (clearAll = new DelegateCommand(() =>
                {


                    EventType = null;
                    DDate = null;
                    EventsChoices = null;


                }));
            }
        }




        private DelegateCommand save;
        public ICommand Save
        {
            get
            {
                return save ?? (save = new DelegateCommand(() =>
                {
                    List<Events> events = new List<Events>();

                    events.Add(Events);


                    /* events.Add(EventType);
                     events.Add(DDate);*/


                }));
            }
        }
        #endregion
        public EventsViewModel()
        {
            FillEventsCategoryChoices();
        }

    }
}
