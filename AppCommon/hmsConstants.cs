namespace hms
{
    public class hmsConstants
    {
        //public const string ConnectionString = "Server=localhost;Port=5432;Database=hmsDB;User Name=postgres;Password=postgres;";
        public const string ConnectionString = "Server=13.76.172.132;Integrated Security=false;Database=hmsDB;User Id=SA;Password=VoidMain@124;";
        #region Session Constants
        public const string loginUserAutoId = "loginUserAutoId";
        public const string userName = "userName";
        public const string hmsTenatAuotId = "hmsTenatAuotId";

        #endregion

        #region CRUD mode

        public const string createMode = "createMode";
        public const string editMode = "editMode";
        public const string viewMode = "viewMode";
        public const string deleteMode = "deleteMode";

        #endregion

    }
}