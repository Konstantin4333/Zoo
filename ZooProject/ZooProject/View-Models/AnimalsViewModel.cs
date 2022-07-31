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

namespace ZooProject.View_Models
{
    class AnimalsViewModel : ViewModelBase
    {
        public AnimalsViewModel()
        {
            FillCatAnimalChoices();
            FillAnimalChoices();
            FillDatabase();
        }
        public ZooDataContext dBContext = new ZooDataContext();
        private List<CategoryOfAnimal> categoryOfAnimalChoices = new List<CategoryOfAnimal>();
        private List<Animals> animalsChoices = new List<Animals>();
        private List<Animals> showAnimals;

        private CategoryOfAnimal _catAnim;
        private Animals _animal;
        public CategoryOfAnimal CatAnim
        {
            get { return _catAnim; }
            set
            {
                _catAnim = value;
                SAnimal = null;
                OnPropertyChanged("CatAnim");
                //FillAnimalChoices();
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

        public void FillCatAnimalChoices()
        {
            categoryOfAnimalChoices = dBContext.categoryOfAnimal
            .Select(catAnim => catAnim).ToList();
        }
         public void FillAnimalChoices()
        {
           
            if (CatAnim != null)
            {
                AnimalsChoices = dBContext.animals.Where(anim => anim.AnimalCategoryID == CatAnim.IdOfCategory)
           .Select(anim => anim).ToList();
            }
           else
            {
                animalsChoices = dBContext.animals
            .Select(anim => anim).ToList();
            }
            

        }
        public void FillAnimalByCat()
        {
          /*  animalsChoices = dBContext.animals
            .Select(Anim => Anim).ToList();*/

            if (CatAnim != null)
            {
                animalsChoices = dBContext.animals.Where(Anim => Anim.AnimalCategoryID== SAnimal.AnimalCategoryID)
           .Select(animcat => animcat).ToList();
            }else
            {
                animalsChoices = dBContext.animals
            .Select(Anim => Anim).ToList();
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
                    OnPropertyChanged("CategoryOfAnimalChoices");
                    FillAnimalChoices();
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
        private DelegateCommand search;
       

        public ICommand Search
        {
            get
            {
                return search ?? (search = new DelegateCommand(() =>
                {

                   
                    FillAnimalChoices();
                  


                }));
            }
        }

       public List<Animals> Animals
        {
            get { return showAnimals; }
            set
            {
                showAnimals = value;
                OnPropertyChanged("Animals");
            }
        }

        public void FillDatabase()
        {
            if (dBContext.animals.ToList().Count == 0)
            {
                Animals animal1 = new Animals("Слон", "Най-едрото животно"
                    , File.ReadAllBytes("D:/MICROINVEST/Zoos/ZooProject/ZooProject/Pictures/Слон.jfif"), 1);
                Animals animal2 = new Animals("Дива котка", "Диво животно"
                    , File.ReadAllBytes("D:/MICROINVEST/Zoos/ZooProject/ZooProject/Pictures/divakotka.jpg"), 1);
                Animals animal3 = new Animals("Орел", "Най-големи хищник в небето"
                    , File.ReadAllBytes("D:/MICROINVEST/Zoos/ZooProject/ZooProject/Pictures/orel.jpg"), 3);
                Animals animal4 = new Animals("Усойница", "Oтровна змия"
                    , File.ReadAllBytes("D:/MICROINVEST/Zoos/ZooProject/ZooProject/Pictures/usoinica.jpg"), 3);

                dBContext.animals.Add(animal1);
                dBContext.animals.Add(animal2);
                dBContext.animals.Add(animal3);
                dBContext.animals.Add(animal4);
                dBContext.SaveChanges();
            }
        }



    }
}
