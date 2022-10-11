using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using DataBaseServicee.DataContext;
using DataBaseServicee.Model;
using DataBaseServicee.FillFromData;
using ZooProject.DeleteFromDataBase;
using ZooProject.View_Models;
using System.Runtime.Intrinsics.X86;

namespace ZooProject.View_Models
{
   public class AnimalsViewModel : ViewModelBase
    {

        #region Fields
        private List<CategoryOfAnimal> categoryOfAnimalChoices = new List<CategoryOfAnimal>();
        private List<CategoryOfAnimal> categoryOfDeletedAnimalChoices = new List<CategoryOfAnimal>();
        private List<Animals> animalsChoices = new List<Animals>();
        private List<Animals> showAnimals;
        private CategoryOfAnimal _catAnim;
        private CategoryOfAnimal catDelAnim;
        private Animals _animal;
        private Animals isDeleted;
        private User isAdmin;
        private User userr;
        private bool deleted;
        private ICommand delete;
        private ICommand save;




        



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
        public User IsAdmin
        {
            get { return isAdmin; }
            set
            {

                isAdmin = value;
                //SAnimal = null;
                OnPropertyChanged(nameof(IsAdmin));
                

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
        public CategoryOfAnimal CatDelAnim
        {
            get { return catDelAnim; }
            set
            {

                catDelAnim = value;

                OnPropertyChanged(nameof(CatDelAnim));
                
               


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
        public List<CategoryOfAnimal> CategoryOfDeletedAnimalChoices
        {

            get { return categoryOfDeletedAnimalChoices; }
            set
            {

                if (categoryOfDeletedAnimalChoices != value)
                {
                    categoryOfDeletedAnimalChoices = value;
                    OnPropertyChanged(nameof(CategoryOfDeletedAnimalChoices));
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
        public ICommand Delete
        {
            get
            {
                return delete ?? (delete = new DelegateCommand(() =>
                {
                    DeleteFromDataCatAnimal deleteFromDataBaseClass = new DeleteFromDataCatAnimal();
                    deleteFromDataBaseClass.DelAnimal(CatAnim);
                   
                    CatAnim = null;
                    SAnimal = null;
                    
                    if (CategoryOfAnimalChoices== null)
                    {
                        AnimalsChoices = null;
                    }
                   
                }));
            }
        }

        
        

       /* public ICommand Save
        {
            get
            {
                return save ?? (save = new DelegateCommand(() =>
                {
                    ZooDataContext dBContext = new ZooDataContext();
                    CategoryOfAnimal animal1 = new CategoryOfAnimal(CatAnim.IdOfCategory, 1);



                    dBContext.categoryOfAnimal.Add(animal1);


                    dBContext.SaveChanges();

                    *//* dBContext.animals.Add(animal1);
                     dBContext.SaveChanges();*//*
                }));
            }
        }*/
        #region Method
        /*public void DelAnimal( )
        {
            ZooDataContext dBContext = new ZooDataContext();
            dBContext.categoryOfAnimal.Where(a => a.IdOfCategory == CatAnim.IdOfCategory).FirstOrDefault().IsDeleted = 1;
            dBContext.SaveChanges();
             LoadFirstProperties();


        }*/
        public void LoadFirstProperties()
        {
            CategoryOfAnimalChoices = new List<CategoryOfAnimal>(FillFromData.FillCatAnimalChoices(CatAnim, IsDeleted));
            CategoryOfDeletedAnimalChoices = new List<CategoryOfAnimal>(FillFromData.FillCatDelAnimalChoices(CatDelAnim, IsDeleted));
            AnimalsChoices = new List<Animals>(FillFromData.FillAnimalChoices(CatAnim));
            CatAnim = CategoryOfAnimalChoices[0];
            SAnimal = AnimalsChoices.First();
        }
        #endregion
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
            LoadFirstProperties();

        }
    }
}
