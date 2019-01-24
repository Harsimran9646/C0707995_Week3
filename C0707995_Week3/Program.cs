using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0707995_Week3
{
    public class customer
    {
        static void Main(string[] args)
        {
            public int ID { get; set; }
        public string NAME { get; set; }
        public void Promote() {
            var rating = CalculateRating();
            if (rating == 0)
            {
                Console.WriteLine("Promoted to level 1");

            }
            else { Console.WriteLine("Promoted to level 2"); }


        }
        public int CalculateRating()
        {
            return 0;
        }
    
    }
            //var purple = new car();
            //var bowling = new car();
            //Console.WriteLine("how many cars: {0}", vehicle.howManyCars);
            //book mybook = new book();
            //mybook.SetTitle("a seprate peace");
            //Console.WriteLine(mybook.GetTitle());
            //Console.ReadLine();
        }
    }
    class vehicle
    {   public static int howManyCars=0;
        public string color = "blue";
    }
    class car : vehicle
    {
        public string color = "red";
        public car()
        {
            vehicle.howManyCars++;
            Console.WriteLine("my color is " + color);
            Console.ReadLine();
        }


    }
    class bookcollection
    {

    
    }
    class book : bookcollection
    {
        private String Title;
        public void SetTitle(String aTitle) { this.Title = aTitle; }
        public String GetTitle() { return this.Title; }
    }
    
    
}
