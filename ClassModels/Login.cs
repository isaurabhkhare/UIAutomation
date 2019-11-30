using System;
using System.Collections.Generic;
using System.Text;

namespace PremierUIAutomation
{

    public interface IPremier<T>
    {
        List<T> PositiveTests { get; set; }
        List<T> NegativeTests { get; set; }
    }

    public partial class LoginTestCollection : IPremier<LoginTestData>
    {
        public List<LoginTestData> PositiveTests { get; set; }
        public List<LoginTestData> NegativeTests { get; set; }
    }

    public partial class LoginTestData
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

}
