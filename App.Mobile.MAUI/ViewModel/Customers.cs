namespace App.Mobile.MAUI.ViewModel
{
    public static class CustomerStaticViewModel
    {
        public static List<Customer> Customers { get; set; }


        static CustomerStaticViewModel()
        {
            Customers = new List<Customer>()
            {
                new Customer()
                {
                    Name = "Google",
                    Status = (int)CustomerStatus.Company
                },
                new Customer()
                {
                    Name = "Amazon",
                    Status = (int)CustomerStatus.Company
                },
                new Customer()
                {
                    Name = "Usman Khair",
                    Status = (int)CustomerStatus.Prospect
                },
                new Customer()
                {
                    Name = "Meta",
                    Status = (int)CustomerStatus.Supplier
                },
            };
        }

    }

    public class Customer
    {
        public string Name { get; set; }

        public int Status { get; set; }
    }

    public enum CustomerStatus
    {
        Company,
        Prospect,
        Supplier
    }

    public static class EnumExtensions
    {
        public static string ConvertToString(this CustomerStatus status,int enumValue)
        {
            return Enum.GetName(typeof(CustomerStatus),enumValue);
        }
    }

}