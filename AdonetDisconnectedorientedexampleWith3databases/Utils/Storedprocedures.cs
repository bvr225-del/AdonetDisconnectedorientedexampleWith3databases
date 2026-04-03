namespace AdonetDisconnectedorientedexampleWith3databases.Utils
{
    public class Storedprocedures
    {
        #region Department stored procedures
        public static string AddDepartment = "Usp_AddDepartmentWithoutReturn";
        public static string UpdateDepartment = "Usp_UpdateDepartment";
        public static string DeleteDepartment = "Usp_DeleteDepartment";
        public static string GetDepartment = "Usp_GetDepartment";
        public static string GetDepartmentByDeptId = "Usp_GetDepartmentById";
        #endregion

    }
}
