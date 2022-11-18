﻿using FirstHundredFoods.Models;
using System.Diagnostics;

namespace FirstHundredFoods.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FirstHundredFoodsContext context)
        {
            if (context.Foods.Any())
            {
                return;   // DB has been seeded
            }

            var foods = new Food[]
            {
                new Food{Name="Asparagus", FoodType=FoodType.Vegetable },
                new Food{Name="Aubergine", FoodType=FoodType.Vegetable },
                new Food{Name ="Beetroot", FoodType=FoodType.Vegetable },
                new Food{Name="Bell pepper", FoodType=FoodType.Vegetable},
                new Food{Name="Broccoli", FoodType=FoodType.Vegetable},
                new Food{Name="Egg", ContainsAllergen=true, FoodType=FoodType.Meat}
            };

            context.Foods.AddRange(foods);
            context.SaveChanges();

            //var courses = new Course[]
            //{
            //    new Course{CourseID=1050,Title="Chemistry",Credits=3},
            //    new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            //    new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            //    new Course{CourseID=1045,Title="Calculus",Credits=4},
            //    new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            //    new Course{CourseID=2021,Title="Composition",Credits=3},
            //    new Course{CourseID=2042,Title="Literature",Credits=4}
            //};

            //context.Courses.AddRange(courses);
            //context.SaveChanges();

            //var enrollments = new Enrollment[]
            //{
            //    new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            //    new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            //    new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            //    new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            //    new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            //    new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            //    new Enrollment{StudentID=3,CourseID=1050},
            //    new Enrollment{StudentID=4,CourseID=1050},
            //    new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            //    new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            //    new Enrollment{StudentID=6,CourseID=1045},
            //    new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            //};

            //context.Enrollments.AddRange(enrollments);
            //context.SaveChanges();
        }
    }
}