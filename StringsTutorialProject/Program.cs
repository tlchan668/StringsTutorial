using System;

namespace StringsTutorialProject {
    class Program {
        static void Main(string[] args) {

            var st1 = new StringsTutorial();//have an instance of our class
            //added another method...says want object plus what we created 
            var fullname=st1.Fullname();//call our method
            
            Console.WriteLine($"Full name is {fullname}");
            Console.WriteLine($"Full name2 is {st1.Fullname2()}");//dont have to store in var
            //create another variable and pass through params
            var denise = new StringsTutorial("Denise", "Bartick");
            Console.WriteLine($"Denise {denise.Fullname()}");
            Console.WriteLine($"Denise {denise.Fullname2()}");
            }
        }
    }
