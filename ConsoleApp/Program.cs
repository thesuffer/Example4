using DataAccessLayer;
using DataAccessLayer.Models;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();
            TempBoss tempBoss = userRepository.FetchEmployeeDetails("Alexandr");
            Console.WriteLine(tempBoss.FirstName + tempBoss.LastName);
        }
    }
}