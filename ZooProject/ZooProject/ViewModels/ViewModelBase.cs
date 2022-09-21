using System;
using System.Collections.Generic;
using System.ComponentModel;
using ZooProject.Data;
using ZooProject.Model;
using ZooProject.Service;

namespace ZooProject.View_Models
{
   public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        DataBaseService dataBaseService = new DataBaseService();
        private protected ZooDataContext dBContext = new ZooDataContext();

        private protected List<CategoryOfAnimal> categoryOfAnimalChoices = new List<CategoryOfAnimal>();
        private protected List<Animals> animalsChoices = new List<Animals>();
        private protected List<Animals> showAnimals;
        private protected CategoryOfAnimal _catAnim;
        private protected Animals _animal;

    }
}
