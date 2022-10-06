/*using System.Linq;
using DataBaseServicee.Model;
using ZooProject.View_Models;
using DataBaseServicee.DataContext;
using System.Collections.Generic;

namespace ZooProject.Filters
{
    public  class AnimalsViewModelFilter
    {


        AnimalsViewModel animalsViewModel = new AnimalsViewModel();
        ZooDataContext dBContext = new ZooDataContext();
        public  List<Animals> FillAnimalChoices()
              {
            List<Animals> listOfAnimals = new List<Animals>();

            if (animalsViewModel.CatAnim != null)
            {
                listOfAnimals = dBContext.animals.Where(anim => anim.AnimalCategoryID == animalsViewModel.CatAnim.IdOfCategory)
                .Select(anim => anim).ToList();
                *//* }else if(CatAnim != null && deleted.Equals("true"))
        {
                    AnimalsChoices = dBContext.animals.Where(anim => anim.AnimalCategoryID == CatAnim.IdOfCategory && IsDeleted.IsDeleted == false)
              .Select(anim => anim).ToList(); *//*
            }
            else
            {
                listOfAnimals = dBContext.animals
                .Select(anim => anim).ToList();
            }

            return listOfAnimals;
        }

        public AnimalsViewModelFilter()
        {

        }
    }
}
*/