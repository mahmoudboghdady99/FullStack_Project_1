using FirstApp2.Models;

namespace FirstApp2.BL
{
    public class ClsEmployee
    {
        public List<EmployeeModel> GetData()
        {
            var LstEmployees = new List<EmployeeModel>();
            EmployeeModel model = new EmployeeModel();
            model.Id = 1;
            model.Name = "Iron Man";
            model.Title = "Innovation";
            model.Description = "Description";
            model.ImageName = "1.jpg";
            LstEmployees.Add(model);

            model = new EmployeeModel();
            model.Id = 2;
            model.Name = "BatMan";
            model.Title = "Developer";
            model.Description = "Description";
            model.ImageName = "2.jpg";
            LstEmployees.Add(model);

            model = new EmployeeModel();
            model.Id = 3;
            model.Name = "Joie Doe";
            model.Title = "Actross";
            model.Description = "Description";
            model.ImageName = "3.jpg";
            LstEmployees.Add(model);

            return LstEmployees;
        }

        public EmployeeModel Find(int id)
        {
            return new EmployeeModel();
        }
    }
}
