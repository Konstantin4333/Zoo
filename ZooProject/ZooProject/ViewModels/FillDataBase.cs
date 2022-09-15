/*using System.Collections.Generic;
using System.IO;
using System.Linq;
using ZooProject.Data;
using ZooProject.Model;

namespace ZooProject.View_Models
{
    internal class FillDataBase : AnimalsViewModel
    {
        public FillDataBase()
        {
         
            *//*FillDatabase();
            FillCatAnimalChoices();
            FillAnimalChoices();*//*

        }
    
        public  void FillDatabase()
        {
            if (dBContext.animals.ToList().Count == 0)
            {
                //   E:\Konstantin\Zoo\ZooProject\ZooProject\Pictures\Слон.jfif
                Animals animal1 = new Animals("Слон", "Най-едрото животно"
                        , File.ReadAllBytes(@"/ZooProject/Pictures/Слон.jfif"), 1);
                Animals animal2 = new Animals("Дива котка", "Диво животно"
                    , File.ReadAllBytes(@"/ZooProject/Pictures/divakotka.jpg"), 1);
                Animals animal3 = new Animals("Орел", "Най-големи хищник в небето"
                    , File.ReadAllBytes(@"/ZooProject/Pictures/orel.jpg"), 3);
                Animals animal4 = new Animals("Усойница", "Oтровна змия"
                    , File.ReadAllBytes(@"/ZooProject/Pictures/usoinica.jpg"), 2);

                dBContext.animals.Add(animal1);
                dBContext.animals.Add(animal2);
                dBContext.animals.Add(animal3);
                dBContext.animals.Add(animal4);
                dBContext.SaveChanges();
            }
            FillCatAnimalChoices();
            FillAnimalChoices();
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


            if (CatAnim != null)
            {
                animalsChoices = dBContext.animals.Where(Anim => Anim.AnimalCategoryID == SAnimal.AnimalCategoryID)
           .Select(animcat => animcat).ToList();
            }
            else
            {
                animalsChoices = dBContext.animals
            .Select(Anim => Anim).ToList();
            }

        }



    }
}
*/