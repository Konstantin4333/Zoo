using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            AddedTickets = new ObservableCollection<CategoryOfTickets>();
            FillCategoryOfTicketsChoices();

            ticketsList = new List<CategoryOfTickets>();
            
        }

        public ZooDataContext dBContext = new ZooDataContext();
        private List<CategoryOfTickets> categoryOfTicketsChoices = new List<CategoryOfTickets>();
        private List<string> test = new List<string>();
        private int numOfTickets; //NumOfTickets
        private int midPrice; //NumOfTickets
        private CategoryOfTickets _categoryOfTickets;
        private ObservableCollection<CategoryOfTickets> addedTickets;
        private ICommand search;
        private ICommand buy;
        private List<CategoryOfTickets> ticketsList;
        private double finalPrice;


        // PRICE,  View ne e dovurshen


       /* private CategoryOfTickets price;

        public CategoryOfTickets Price
        {
            get { return price; }
            set { price = value;
                
                OnPropertyChanged(nameof(Price));
            }
        }*/
        public double FinalPrice
        {
            get { return finalPrice; }
            set
            {
                finalPrice = value;
                OnPropertyChanged(nameof(FinalPrice));
            }
        }
        public int NumOfTickets
        {
            get { return numOfTickets; }
            set
            {
                numOfTickets = value;

                OnPropertyChanged(nameof(NumOfTickets));

            }
        }
        public ObservableCollection<CategoryOfTickets> AddedTickets
        {
            get { return addedTickets; }
            set
            {
                addedTickets = value;
                OnPropertyChanged(nameof(AddedTickets));
            }
        }

        public double MidPrice
        {
            get { return midPrice; }
            set
            {
                numOfTickets = (int)value;

                OnPropertyChanged(nameof(MidPrice));

            }
        }


        public void AddTicket()
        {
            // Tickets ticket = new Tickets();
            // observalcollection
            CategoryOfTickets = CategoryOfTickets;
            NumOfTickets = NumOfTickets;

            ticketsList.Add(CategoryOfTickets);
            AddedTickets.Add(ticketsList.FirstOrDefault())/* = new List<CategoryOfTickets>(ticketsList)*/;
            FinalPrice += CategoryOfTickets.price * CategoryOfTickets.NumOfTickets;
            // MidPrice = CategoryOfTickets.price * CategoryOfTickets.NumOfTickets;
        }
        private CategoryOfTickets _ticket;
        public CategoryOfTickets Ticket
        {
            get { return _ticket; }
            set
            {
                _ticket = value;

                OnPropertyChanged(nameof(Ticket));

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
                
                OnPropertyChanged(nameof(CategoryOfTickets));

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
                    OnPropertyChanged(nameof(CategoryOfTicketsChoices));
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


    }
}
