using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private string favoriteColor;
        private int age;
        private bool isWorking;

        public string DisplayPersonInfo
        {
            get
            {
                string name =this.id + ": " + this.firstName+ " " + this.lastName + "'s favorate color is " + this.favoriteColor;
               
                return name;
            }
        }
        public string ChangeFavoriteColor
        {
            get
            {
                this.favoriteColor = "white";
                return this.favoriteColor;
            }
            set
            {
                this.favoriteColor = "white";
            }
            
        }
        public int GetAgeInTenYears
        {
            get
            {
                int newAge = this.age + 10;
                
                return newAge;
            }
        }
        public string ToString
        {
            get
            {
                string formated = "ID: " + this.id + " \n Name: " +  this.firstName + " " + this.lastName + " \n Age: " + this.age + " \n Favorite Color: " + this.favoriteColor + "\n Working Status: "+ this.isWorking;
                
                return formated;

            }
        }

        public Person(int id, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColor = favoriteColor;
            this.age = age;
            this.isWorking = isWorking;
        }

    }
}
