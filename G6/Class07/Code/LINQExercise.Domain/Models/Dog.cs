using LINQExercise.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExercise.Domain.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public BreedEnum Breed { get; set; }

        public Dog(string name,  string color, int age, BreedEnum breed)
        {
            Name = name;
            Age = age;
            Color = color;
            Breed = breed;
        }   
    }
}
