using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113Zadatak
{
    class Sort
    {
        public int InputedNumber { get; set; }
        public List<int> numberList = new List<int>();
        public List<int> originalList = new List<int>();

        public void AddToLIst(string number)
        {
            numberList.Add(int.Parse(number));
            originalList = numberList.ToList();
        }

        public void OriginalList()
        {
            numberList = originalList.ToList();
        }

        public void SortedList()
        {
            numberList.Sort();
        }
    }
}
