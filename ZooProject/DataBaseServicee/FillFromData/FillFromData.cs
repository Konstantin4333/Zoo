using DataBaseServicee.Model;
using DataBaseServicee.DataContext;
using System.Collections.Generic;
using System.Linq;


namespace DataBaseServicee.FillFromData
{
    public static class FillFromData
    {

        private static  ZooDataContext dBContext = new ZooDataContext();
        #region AnimalViewModel Fill
        public static List<CategoryOfAnimal> FillCatAnimalChoices()
        {
            /*CategoryOfAnimalChoices = dBContext.categoryOfAnimal
            .Select(catAnim => catAnim).ToList();*/
            List<CategoryOfAnimal> listOfCatAnim = new List<CategoryOfAnimal>();

            if (dBContext.categoryOfAnimal.ToList().Count != 0)
            {
                foreach (CategoryOfAnimal categA in dBContext.categoryOfAnimal.ToList().Select(catAnim => catAnim).Distinct())
                {
                    listOfCatAnim.Add(categA);
                }
            }
            return listOfCatAnim;
        }

        public static List<Animals> FillAnimalChoices(CategoryOfAnimal CatAnim)
        {
            List<Animals> listOfAnimals = new List<Animals>();
            if(dBContext.animals.ToList().Count != 0)
            {
                if (CatAnim != null)
                {


                    foreach (Animals animals in dBContext.animals.ToList().Where(anim => anim.AnimalCategoryID == CatAnim.IdOfCategory).Select(anim => anim).Distinct())
                    {
                        listOfAnimals.Add(animals);
                    }
                }else
                {
                    foreach (Animals animals in dBContext.animals.ToList().Select(anim => anim).Distinct())
                    {
                        listOfAnimals.Add(animals);
                    }
                }
            }
            return listOfAnimals;
        }
        #endregion
        #region Events
        public static List<EventType> FillEventsCategoryChoices()
        {
            
            List<EventType> listOfEventType = new List<EventType>();

            if (dBContext.eventType.ToList().Count != 0)
            {
                foreach (EventType categEv in dBContext.eventType.ToList().Select(typeEv => typeEv).Distinct())
                {
                    listOfEventType.Add(categEv);
                }
            }
            return listOfEventType;
        }

        public static List<Events> FillEvents()
        {

            List<Events> listOfEvent = new List<Events>();

            if (dBContext.events.ToList().Count != 0)
            {
                foreach (Events bb in dBContext.events.ToList().Select(@event => @event).Distinct())
                {
                    listOfEvent.Add(bb);
                }
            }
            return listOfEvent;
        }
        #endregion
        #region Tickets
        public static List<CategoryOfTickets> FillCategoryOfTicketsChoices()
        {

            List<CategoryOfTickets> listOfTickets = new List<CategoryOfTickets>();

            if (dBContext.categorryOfTickets.ToList().Count != 0)
            {
                foreach (CategoryOfTickets bb in dBContext.categorryOfTickets.ToList().Select(ticket => ticket).Distinct())
                {
                    listOfTickets.Add(bb);
                }
            }
            return listOfTickets;
        }
        #endregion
    }
}
