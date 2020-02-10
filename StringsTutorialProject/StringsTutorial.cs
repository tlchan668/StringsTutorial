using System;
using System.Collections.Generic;
using System.Text;

namespace StringsTutorialProject {
    class StringsTutorial {
        public string Firstname;//="Leia";//initalize it these are properties of the class
        public string Lastname;//="Chan";//exists as long as our class s1 exists-these are hard coded

        //special method with no return type and has name of a class is a CONSTRUCTOR
        //aways used to give your class data 
        public StringsTutorial() {
            //can't pass anything into this but can give instance data
            //inialize data
            Firstname = "Leia";
            Lastname = "Chan";
            //you are allowed to have more than one constructor
            //if valuable if had another constructor that took in parameters
            }

        //another way passing params
        public StringsTutorial (string firstname, string lastname) {
            //initialize data and stick in correct property
           
            Firstname = firstname;
            Lastname = lastname;
            }

        public string Fullname() {
            //var Firstname = "Traci";
            //var Lastname = "Chan";

            //var name = Firstname + " " + Lastname;
            //another way to do it is
            //var name = $"{Firstname} {Lastname}";
            var name = ($"{Lastname}, {Firstname}");//want to comment out the local variables
            return name;
            }
        public string Fullname2() {
            //var Firstname = "Traci";
            //var Lastname = "Chan";

            var name = $"{Firstname} {Lastname}";
            return name;
        }


        }
    }
