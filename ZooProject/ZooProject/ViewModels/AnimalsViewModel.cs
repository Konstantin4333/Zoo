using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using DataBaseServicee.DataContext;
using DataBaseServicee.Model;
using DataBaseServicee.FillFromData;


namespace ZooProject.View_Models
{
    class AnimalsViewModel : ViewModelBase
    {

        #region Fields
        private List<CategoryOfAnimal> categoryOfAnimalChoices = new List<CategoryOfAnimal>();
        private List<Animals> animalsChoices = new List<Animals>();
        private List<Animals> showAnimals;
        private CategoryOfAnimal _catAnim;
        private Animals _animal;
        private Animals isDeleted;
        private bool deleted;
        private ICommand delete;
        private ICommand save;
        // AnimalsViewModelFilter animalsViewModelFilter = new AnimalsViewModelFilter();
        #endregion
        #region Properties & Lists
        public Animals IsDeleted
        {
            get { return isDeleted; }
            set
            {

                isDeleted = value;
                //SAnimal = null;
                OnPropertyChanged(nameof(IsDeleted));
                FillFromData.FillAnimalChoices(CatAnim);

            }
        }
        public CategoryOfAnimal CatAnim
        {
            get { return _catAnim; }
            set
            {

                _catAnim = value;

                OnPropertyChanged(nameof(CatAnim));
                AnimalsChoices = FillFromData.FillAnimalChoices(CatAnim);
                SAnimal = AnimalsChoices.First();


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
                    FillFromData.FillAnimalChoices(CatAnim);

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
        /*public ICommand Delete
        {
            get
            {
                return delete ?? (delete = new DelegateCommand(() =>
                {
                    ZooDataContext dBContext = new ZooDataContext();
                     CategoryOfAnimal test = CategoryOfAnimalChoices.;
                    test.IsDeleted = true;
                    int a = 1;
                    dBContext.categoryOfAnimal.Add(test);
                    dBContext.SaveChanges();
                }));
            }
        }*/

        public ICommand Save
        {
            get
            {
                return save ?? (save = new DelegateCommand(() =>
                {

                    Animals animal1 = new Animals(true);
                    /* dBContext.animals.Add(animal1);
                     dBContext.SaveChanges();*/
                }));
            }
        }

        #endregion
        #region FillFromDataBase
        /* public void FillCatAnimalChoices()
         {
             CategoryOfAnimalChoices = dBContext.categoryOfAnimal
             .Select(catAnim => catAnim).ToList();
         }*/
        /*private ZooDataContext dBContext = new ZooDataContext();
        public void FillAnimalChoices()
        {
            deleted = false;
            
            if (CatAnim != null )
            {
                AnimalsChoices = dBContext.animals.Where(anim => anim.AnimalCategoryID == CatAnim.IdOfCategory)
           .Select(anim => anim).ToList();
           *//* }else if(CatAnim != null && deleted.Equals("true"))
            {
                AnimalsChoices = dBContext.animals.Where(anim => anim.AnimalCategoryID == CatAnim.IdOfCategory &&  IsDeleted.IsDeleted == false)
          .Select(anim => anim).ToList();*//*
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

        }*/

        #endregion
        public AnimalsViewModel()
        {

            CategoryOfAnimalChoices = new List<CategoryOfAnimal>(FillFromData.FillCatAnimalChoices());
            AnimalsChoices = new List<Animals>(FillFromData.FillAnimalChoices(CatAnim));
            CatAnim = CategoryOfAnimalChoices[0];
            SAnimal = AnimalsChoices.First();

        }
    }
}
