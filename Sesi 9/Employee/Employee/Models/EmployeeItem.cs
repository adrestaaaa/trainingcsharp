using Org.BouncyCastle.Bcpg;

namespace Employee.Models
{
    public class EmployeeItem
    {
        private Models.EmployeeContext context;
        public int id { get; set; }
        public string nama { get; set; }
        public string jenis_kelamin { get; set; }
        public string alamat { get; set; }
    }
}
