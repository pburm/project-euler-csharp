using ProjectEuler.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = string.Empty;
            var map = GetSolutionMap();

            if (args.Length < 1)
            {
                number = GetProblemNumber();

            }
            else
            {
                number = args[0];
            }
            while (true)
            {
                if (int.TryParse(number, out var problemNumber) && map.ContainsKey(number))
                {
                    ((ISolution)Activator.CreateInstance(map[number])).Solve();
                }
                else
                {
                    Console.WriteLine("Invalid problem number or solution not yet created.");
                }
                number = GetProblemNumber();
                if (number.ToLower() == "q")
                    Environment.Exit(0);
            }

            

        }

        private static string GetProblemNumber()
        {
            Console.WriteLine("Please provide a problem number or press 'q then enter' to exit:");
            return Console.ReadLine();
        }

        static Dictionary<string, Type> GetSolutionMap()
        {
            Dictionary<string, Type> map = new Dictionary<string, Type>();
            Type solutionType = typeof(ISolution);
            IEnumerable<Type> lookupTypes = solutionType.Assembly.GetTypes().Where(
                    t => solutionType.IsAssignableFrom(t) && !t.IsInterface);

            foreach (var type in lookupTypes)
            {
                var solutionNumber = type.Name.Substring(type.Name.Length - 4);
                if (int.TryParse(solutionNumber, out var number))
                {
                    map.Add(number.ToString(), type);
                }
                
            }
            return map;
        }
    }
}
