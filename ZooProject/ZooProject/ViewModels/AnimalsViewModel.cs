using Prism.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using ZooProject.Data;
using ZooProject.Model;
using ZooProject.Service;

namespace ZooProject.View_Models
{
    class AnimalsViewModel : ViewModelBase
    {
        public AnimalsViewModel()
        {

            //dataBaseService.FillCatAnimalChoices();
            // Fill Animal Category to DataBase
            //dataBaseService.FillCatAnimalChoices();
            //  dataBaseService.FillDatabase();
            FillCatAnimalChoices();
            FillAnimalChoices();
        }


        // DataBaseService dataBaseService = new DataBaseService();





        #region Fields
        private List<CategoryOfAnimal> categoryOfAnimalChoices = new List<CategoryOfAnimal>();
        private List<Animals> animalsChoices = new List<Animals>();
        private List<Animals> showAnimals;
        private CategoryOfAnimal _catAnim;
        private Animals _animal;
        private Animals isDeleted;
        private bool deleted;
        private ICommand search;
        #endregion
        #region Properties
        public Animals IsDeleted
        {
            get { return isDeleted; }
            set
            {

                isDeleted = value;
                //SAnimal = null;
                OnPropertyChanged(nameof(IsDeleted));
                FillAnimalChoices();

            }
        }
        public CategoryOfAnimal CatAnim
        {
            get { return _catAnim; }
            set
            {
              
                _catAnim = value;
                //SAnimal = null;
                 OnPropertyChanged(nameof(CatAnim));
                 FillAnimalChoices();
                
            }
        }
        public Animals SAnimal
        {
            get { return _animal; }
            set
            {
                _animal = value;

                OnPropertyChanged(nameof(SAnimal));
                Console.WriteLine();
            }
        }



        public List<CategoryOfAnimal> CategoryOfAnimalChoices
        {

            get { return categoryOfAnimalChoices; }
            set
            {

                if (categoryOfAnimalChoices != value)
                {
                    categoryOfAnimalChoices = value;
                    OnPropertyChanged(nameof(CategoryOfAnimalChoices));
                    FillAnimalChoices();
                   
                    ;
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
                    OnPropertyChanged(nameof(AnimalsChoices));
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
                OnPropertyChanged(nameof(Animals));
            }
        }
        #endregion
        #region Commands
        // testtttttt PROVERI
        public ICommand Search
        {
            get
            {
                return search ?? (search = new DelegateCommand(() =>
                {
                    
                    Animals animal1 = new Animals(true);
                    dBContext.animals.Add(animal1);
                    dBContext.SaveChanges();
                }));
            }
        }
        /* public ICommand Search
        {
            get { return search ?? (search = new Command(p => true, p => FillAnimalChoices())); }

        }*/
        #endregion
        #region FillFromDataBase
        public void FillCatAnimalChoices()
        {
            CategoryOfAnimalChoices = dBContext.categoryOfAnimal
            .Select(catAnim => catAnim).ToList();
        }
        private ZooDataContext dBContext = new ZooDataContext();
        public void FillAnimalChoices()
        {
            deleted = false;
            
            if (CatAnim != null )
            {
                AnimalsChoices = dBContext.animals.Where(anim => anim.AnimalCategoryID == CatAnim.IdOfCategory)
           .Select(anim => anim).ToList();
           /* }else if(CatAnim != null && deleted.Equals("true"))
            {
                AnimalsChoices = dBContext.animals.Where(anim => anim.AnimalCategoryID == CatAnim.IdOfCategory &&  IsDeleted.IsDeleted == false)
          .Select(anim => anim).ToList();*/
            }
            else
            {
                AnimalsChoices = dBContext.animals
            .Select(anim => anim).ToList();
            }


        }
        public void FillAnimalByCat()
        {


            if (CatAnim != null && isDeleted.Equals("false"))
            {
                AnimalsChoices = dBContext.animals.Where(Anim => Anim.AnimalCategoryID == SAnimal.AnimalCategoryID)
           .Select(animcat => animcat).ToList();
            }
            else
            {
                AnimalsChoices = dBContext.animals
            .Select(Anim => Anim).ToList();
            }

        }

        #endregion

    }
}
