using Prism.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using ZooProject.Data;
using ZooProject.Interface;
using ZooProject.Model;
using ZooProject.Service;

namespace ZooProject.View_Models
{
    class AnimalsViewModel : ViewModelBase
    {
       
        public AnimalsViewModel()
        {
            var dataBaseService = new DataBaseService();
            // dataBaseService.FillDatabase();
            dataBaseService.FillCatAnimalChoices();
        }
        #region Fields
       
        private ICommand search;
        #endregion
        #region Properties
        public CategoryOfAnimal CatAnim
        {

            get { return _catAnim; }
            set
            {
                var dataBaseService = new DataBaseService();
                _catAnim = value;
                SAnimal = null;
                //   OnPropertyChanged("CatAnim");
                dataBaseService.FillAnimalChoices();
                AnimalsChoices = null;
            }
        }
        public Animals SAnimal
        {
            get { return _animal; }
            set
            {
                _animal = value;

                OnPropertyChanged("SAnimal");
                Console.WriteLine();
            }
        }



        public List<CategoryOfAnimal> CategoryOfAnimalChoices
        {

            get { return categoryOfAnimalChoices; }
            set
            {
                var dataBaseService = new DataBaseService();
                if (categoryOfAnimalChoices != value)
                {
                    categoryOfAnimalChoices = value;
                    OnPropertyChanged("CategoryOfAnimalChoices");


                    dataBaseService.FillAnimalChoices();
                }
            }
        }
        public List<Animals> AnimalsChoices
        {
            get { return animalsChoices; }
            set
            {

                if (animalsChoices != value)
                {
                    animalsChoices = value;
                    OnPropertyChanged("AnimalsChoices");
                }
            }
        }
        //private DelegateCommand search;



        public List<Animals> Animals
        {
            get { return showAnimals; }
            set
            {
                showAnimals = value;
                OnPropertyChanged("Animals");
            }
        }
        #endregion
        #region Commands

        public ICommand Search
        {
            get
            {
                return search ?? (search = new DelegateCommand(() =>
                {
                    var dataBaseService = new DataBaseService();
                    dataBaseService.FillAnimalChoices();
                }));
            }
        }
        /* public ICommand Search
        {
            get { return search ?? (search = new Command(p => true, p => FillAnimalChoices())); }

        }*/
        #endregion
        #region FillFromDataBase
        //public void FillCatAnimalChoices()
        //{
        //    CategoryOfAnimalChoices = dBContext.categoryOfAnimal
        //    .Select(catAnim => catAnim).ToList();
        //}
        //public void FillAnimalChoices()
        //{

        //    if (CatAnim != null)
        //    {
        //        AnimalsChoices = dBContext.animals.Where(anim => anim.AnimalCategoryID == CatAnim.IdOfCategory)
        //   .Select(anim => anim).ToList();
        //    }
        //    else
        //    {
        //        animalsChoices = dBContext.animals
        //    .Select(anim => anim).ToList();
        //    }


        //}
        //public void FillAnimalByCat()
        //{


        //    if (CatAnim != null)
        //    {
        //        animalsChoices = dBContext.animals.Where(Anim => Anim.AnimalCategoryID == SAnimal.AnimalCategoryID)
        //   .Select(animcat => animcat).ToList();
        //    }
        //    else
        //    {
        //        animalsChoices = dBContext.animals
        //    .Select(Anim => Anim).ToList();
        //    }

        //}
        #endregion
    }
}
