using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Author: Alexey Kharchenko");

            RecipeBook book = new RecipeBook();

            Console.WriteLine("Menu");
            Console.WriteLine("1 - Exit");
            Console.WriteLine("2 - Add Recipe");
            Console.WriteLine("3 - Edit Recipe");
            Console.WriteLine("4 - Delete Recipe");
            Console.WriteLine("5 - Search");

            int choice = 0;
            string input = "";
            string output = "";
            IEnumerable<Recipe> query = null;

            try
            {
                input = Console.ReadLine();
                choice = Convert.ToInt32(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            switch (choice)
            {
                case 1:
                    return;
                case 2:
                    book.AddRecipe();
                    break;
                case 3:
                    book.EditRecipe();
                    break;
                case 4:
                    book.DeleteRecipe();
                    break;
                case 5:
                    Console.WriteLine("Enter filter");
                    try
                    {
                        input = Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    var res =  book.Search(input);
                    book.DisplayRecipies(res.ToArray());
                    break;
            }
        }

    }
    
}
