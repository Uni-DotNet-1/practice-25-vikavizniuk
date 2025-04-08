using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_8
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    public class LinqTasks
    {
        public IEnumerable<int> GetEvenNumbers(List<int> numbers)
        {
            return ;
        }

        public int GetSum(List<int> numbers)
        {
            return ;
        }

        public IEnumerable<string> GetLongStrings(List<string> strings)
        {
            return ;
        }


        public Person FindPersonByName(List<Person> people, string name)
        {
            return ;
        }

        public IEnumerable<int> SortDescending(List<int> numbers)
        {
            return ;
        }

        public IEnumerable<IGrouping<int, Person>> GroupByAge(List<Person> people)
        {
            return ;
        }

        public bool AnyNumberGreaterThanTen(List<int> numbers)
        {
            return ;
        }

        public IEnumerable<string?> SelectNames(List<Person> people)
        {
            return ;
        }

        public bool AllPositive(List<int> numbers)
        {
            return ;
        }

        public IEnumerable<int> ConcatenateLists(List<int> list1, List<int> list2)
        {
            return ;
        }


    }

}
