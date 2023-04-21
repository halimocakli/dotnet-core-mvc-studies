using System.Collections.Generic;

namespace PassingData.Models.ViewModel
{
    public class CustomerAndProductVM
    {
        public List<Customer> customers { get; set; }
        public Product product { get; set; }
        public string date { get; set; }
    }
}
