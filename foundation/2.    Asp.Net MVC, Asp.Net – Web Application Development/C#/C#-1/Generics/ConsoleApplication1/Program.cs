using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating objects
            Car car1 = new Car();
            car1.Make = "Renult";
            car1.Model = "Kwid";
            Car car2 = new Car();
            car2.Make = "Nissan";
            car2.Model = "go+";

            Book book1 = new Book();
            book1.Title = "the rain";
            book1.Author = "john k";
            book1.ISBN = "0-00000-000";


            //Car c1 = new Car() { Make = "sample1", Model = "indigo" };
            //Car c2 = new Car() { Make = "sample2", Model = "indica" };

            //List<Car> cc = new List<Car>() { new Car() { Make = "sample1", Model = "indigo" },
            //                                 new Car() { Make = "sample2", Model = "indica" } 
            //                               };


            // arrylist are dynamically sized and support other
            // cool feature like sorting , removing items etc..
            System.Collections.ArrayList myArrayList = new System.Collections.ArrayList();

            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);
            myArrayList.Remove(book1);

            foreach (object o in myArrayList)
            {
                Console.WriteLine(((Car)o).Make);

            }


            //Hashtable allow you to save a key along with
            //the value, and also support cool features.

            System.Collections.Hashtable myHashTable = new System.Collections.Hashtable();
            myHashTable.Add(car1.Make, car1);
            myHashTable.Add(car2.Make, car2);
            myHashTable.Add(book1.Author, book1);

            //easy access to n element using its key
            Console.WriteLine(((Car)myHashTable["Renult"]).Model);
            //  Console.WriteLine(((Car)myHashTable["john k"]).Model);


            List<Car> mylist = new List<Car>();
            mylist.Add(car1);
            mylist.Add(car2);
            //  mylist.Add(book1);
            foreach (Car car in mylist)
            {
                //no casting
                Console.WriteLine(car.Model);
            }



            Dictionary<string, Car> dictnry = new Dictionary<string, Car>();
            dictnry.Add(car1.Make, car1);
            dictnry.Add(car2.Make, car2);

            //no casting
            Console.WriteLine(dictnry["Renult"].Model);

            Console.ReadLine();


        }


    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}








