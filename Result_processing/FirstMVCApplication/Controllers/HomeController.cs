using System.Web.Mvc;
using FirstMVCApplication.DataServices;

namespace FirstMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var sqlInsert = @"Insert into Student
               (FirstName
               , LastName
               , DateOfBirth
               , RollNo
               , AddressId
               , DepartmentId
               )
           VALUES
               ('Faysal'
               , 'Mahmood'
               , '1988-08-05'
               , '00112233'
               , 1
               , 1
               )";

            var da = new DatabaseService();
            
            var count = da.ExecuteNonQuery(sqlInsert);
            var sqlUpdate = @"Update Student set 
                RollNo = 123456 
            where 
                FirstName = 'Faysal' and 
                LastName = 'Mahmood' and 
                DateOfBirth = '1988-08-05'";

            count = da.ExecuteNonQuery(sqlUpdate);
            var sqlSelect = @"Select * from Student 
            where 
                FirstName = 'Faysal' and 
                LastName = 'Mahmood' and 
                DateOfBirth = '1988-08-05'";
            var dt = da.GetDataSet(sqlSelect).Tables[0];
            var sqlDelete = @"Delete from Student 
                    where 
                        FirstName = 'Faysal' and 
                        LastName = 'Mahmood' and 
                        DateOfBirth = '1988-08-05'";

            count = da.ExecuteNonQuery(sqlDelete);
            return View();
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }        
    }
}