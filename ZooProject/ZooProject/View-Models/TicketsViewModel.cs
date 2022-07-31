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
    class TicketsViewModel : ViewModelBase
    {
        public TicketsViewModel()
        {
            ViewModelBase viewModelBase;
            FillCategoryOfTicketsChoices();
        }

        public ZooDataContext dBContext = new ZooDataContext();
        private List<CategoryOfTickets> categoryOfTicketsChoices = new List<CategoryOfTickets>();
        private List<string> test = new List<string>();
        private int numOfTickets; //NumOfTickets
        private string _sTypeOfTic;
        private CategoryOfTickets _categoryOfTickets;


      
    public int NumOfTickets
{
    get { return numOfTickets; }
    set
    {
        numOfTickets = value;

        OnPropertyChanged("NumOfTickets");
        Console.WriteLine();
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
            categoryOfTicketsChoices = dBContext.categorryOfTickets
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

    }
}
