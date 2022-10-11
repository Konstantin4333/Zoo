using System.Linq;
using ZooProject.View_Models;
using DataBaseServicee.Model;

namespace ZooProject.DeleteFromDataBase
{
    public  class DeleteFromDataCatAnimal : DeleteFromDataBaseClass
    {
        public  void DelAnimal(CategoryOfAnimal CatAnim)
        {
           
            dBContext.categoryOfAnimal.Where(a => a.IdOfCategory == CatAnim.IdOfCategory).FirstOrDefault().IsDeleted = 1;
           
            dBContext.SaveChanges();
         //  sss.LoadFirstProperties();


        }
    }
}
