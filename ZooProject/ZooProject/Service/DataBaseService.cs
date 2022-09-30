
using System;

using System.IO;
using System.Linq;
using ZooProject.Data;
using ZooProject.Model;
using ZooProject.View_Models;

namespace ZooProject.Service
{
    internal  class DataBaseService
    {
        public DataBaseService()
        {
            /*FillCatAnimalChoices();
            FillAnimalByCat();
            FillAnimalChoices();*/
            

        }


        AnimalsViewModel animalsViewModel = new AnimalsViewModel();
      //  DataBaseServicee.Animals animals = new DataBaseServicee.Animals();
      /*  public  void FillDatabase()
        {
              
            if (dBContext.animals.ToList().Count != 0)
            {
           
            //   E:\Konstantin\Zoo\ZooProject\ZooProject\Pictures\Слон.jfif
                 Animals animal1 = new Animals("Слон", "Най-едрото животно"
                        , File.ReadAllBytes("E:\\Konstantin\\Zoo\\Zoo\\ZooProject\\ZooProject\\Pictures\\Слон.jfif"), 4);
                Animals animal2 = new Animals("Дива котка", "Диво животно"
                    , File.ReadAllBytes("E:\\Konstantin\\Zoo\\Zoo\\ZooProject\\ZooProject\\Pictures\\divakotka.jpg"), 4);
                Animals animal3 = new Animals("Орел", "Най-големи хищник в небето"
                    , File.ReadAllBytes("E:\\Konstantin\\Zoo\\Zoo\\ZooProject\\ZooProject\\Pictures\\orel.jpg"), 6);
                Animals animal4 = new Animals("Усойница", "Oтровна змия"
                    , File.ReadAllBytes(@"E:/Konstantin/Zoo/Zoo/ZooProject/ZooProject/Pictures/usoinica.jpg"), 5);

                //E:\\Konstantin\\Zoo\\Zoo\\ZooProject\\ZooProject\\Pictures\\usoinica.jpg
                 dBContext.animals.Add(animal1);
                dBContext.animals.Add(animal2);
                dBContext.animals.Add(animal3);
                dBContext.animals.Add(animal4);
                dBContext.SaveChanges();
            }
            // FillCatAnimalChoices();

        }*/
        enum test11{
            test1,
            test2,
            test3,
        }

        // --------------------- DBCONTEXT ne raboti
        


    }
}
