using DataBaseServicee.DataContext;

namespace ZooProject.DeleteFromDataBase
{
    public  class DeleteFromDataBaseClass
    {
        protected static readonly DeleteFromDataBaseClass deleteFromDataBaseClass = new DeleteFromDataBaseClass();
        protected ZooDataContext dBContext;


        public static DeleteFromDataBaseClass GetDeleteFromDataBaseClass()
        {
            return deleteFromDataBaseClass;
        }
        protected DeleteFromDataBaseClass()
        {
            dBContext = new ZooDataContext();
        }
    }
}
