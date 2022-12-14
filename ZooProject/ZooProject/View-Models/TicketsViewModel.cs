using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using ZooProject.Data;
using ZooProject.Model;

namespace ZooProject.View_Models
{
    class TicketsViewModel : ViewModelBase
    {
        public TicketsViewModel()
        {
            ViewModelBase viewModelBase;
            FillCategoryOfTicketsChoices();
           
            ticketsList = new List<Tickets>();
        }

        public ZooDataContext dBContext = new ZooDataContext();
        private List<CategoryOfTickets> categoryOfTicketsChoices = new List<CategoryOfTickets>();
        private List<string> test = new List<string>();
        private int numOfTickets; //NumOfTickets
        private string _sTypeOfTic;
        private CategoryOfTickets _categoryOfTickets;
        private List<Tickets> addedTickets;
        private ICommand search;
        private ICommand buy;
        private List<Tickets> ticketsList;
        private double finalPrice;
        public double FinalPrice {
            get { return finalPrice; }
            set { finalPrice = value;
                OnPropertyChanged("FinalPrice");
            }
        }
        public int NumOfTickets
{
    get { return numOfTickets; }
    set
    {
        numOfTickets = value;

        OnPropertyChanged("NumOfTickets");
       
    }
}
        public List<Tickets> AddedTickets
        {
            get { return addedTickets; }
            set { addedTickets = value;
                OnPropertyChanged("AddedTickets");
            }
        }
        public void AddTicket()
        {
            Tickets ticket = new Tickets();
            ticket.CategoryOfTickets = CategoryOfTickets;
            ticket.NumOfTickets = NumOfTickets;
            
            ticketsList.Add(ticket);
            AddedTickets = new List<Tickets>(ticketsList);
            FinalPrice += CategoryOfTickets.price * NumOfTickets;
        }
        private Tickets _ticket;
        public Tickets Ticket
        {
            get { return _ticket; }
            set
            {
                _ticket = value;

                OnPropertyChanged("Ticket");

            }
        }
        public ICommand Search
        {
            get
            {
                return search ?? (search = new DelegateCommand(() =>
                {

                    AddTicket();
                    

                }));
            }
        }

        public ICommand Buy
        {
            get
            {
                return buy ?? (buy = new DelegateCommand(() =>
                {

                    MessageBox.Show("Вие успешно направихте поръчката. ");
                    NumOfTickets = 0;
                    AddedTickets = null;
                    FinalPrice = 0;
                    CategoryOfTicketsChoices = null;

                    PriceOfTickets = 0;


                }));
            }
        }
        public CategoryOfTickets CategoryOfTickets
        {
            get { return _categoryOfTickets; }
            set
            {
                _categoryOfTickets = value;

                OnPropertyChanged("CategoryOfTickets");

            }
        }
        

        public void FillCategoryOfTicketsChoices()
        {
            CategoryOfTicketsChoices = dBContext.categorryOfTickets
            .Select(z => z).ToList();
        }

        public List<CategoryOfTickets> CategoryOfTicketsChoices
        {
            get { return categoryOfTicketsChoices; }
            set
            {

                if (categoryOfTicketsChoices != value)
                {
                    categoryOfTicketsChoices = value;
                    OnPropertyChanged("CategoryOfTicketsChoices");
                }
            }
        }

        

        private int priceOfticket;
        
        
        public int PriceOfTickets
        {
            get { return priceOfticket; }
            set
            {
                priceOfticket = value;

                OnPropertyChanged("CategoryOfTickets.price");
                Console.WriteLine();
            }
        }


        private DelegateCommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new DelegateCommand(() =>
                {
                    PriceOfTickets += priceOfticket;


                    Console.WriteLine(PriceOfTickets);


                }));
            }
        }

        public object MessageBoxButtons { get; private set; }
    }
}
