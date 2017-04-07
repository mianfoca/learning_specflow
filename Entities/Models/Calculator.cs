using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Calculator
    {
        public List<int> numbers { set; private get; }

        public void AddNumber(int number)
        {
            if (numbers == null) numbers = new List<int>();
            numbers.Add(number);
        }

        public int Sum()
        {
            return numbers.Sum();
        }
    }
}
