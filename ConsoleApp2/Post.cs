using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryLaba10
{
    public class Post: IInit
    {
        private double numViews;
        private double numComments;
        private double numReactions;
        static int count;
        static Random rand = new Random();
        public double NumViews
        {
            get { return numViews; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error!");
                    numViews = 0;
                }
                else numViews = value;
            }
        }
        public double NumComments
        {
            get { return numComments; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error!");
                    numComments = 0;
                }
                else numComments = value;
            }
        }
        public double NumReactions
        {
            get { return numReactions; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error!");
                    numReactions = 0;
                }
                else numReactions = value;
            }
        }
        public Post()
        {
            NumViews = 0;
            NumComments = 0;
            NumReactions = 0;
            count++;
        }
        public Post(double numViews, double numComments, double numReactions)
        {
            NumViews = numViews;
            NumComments = numComments;
            NumReactions = numReactions;

            count++;
        }
        public void Show()
        {
            Console.WriteLine($"{NumViews} просмотров. {NumComments} комментариев. {NumReactions} реакций.");
        }
        public override string ToString()
        {
            return $"{NumViews} просмотров. {NumComments} комментариев. {NumReactions} реакций.";
        }
        public void Print()
        {
            Console.WriteLine($"{NumViews} просмотров. {NumComments} комментариев. {NumReactions} реакций.");
        }
        public void Init()
        {
            Console.WriteLine("Количество просмотров на посте:");
            try
            {
                NumViews = double.Parse(Console.ReadLine());
            }
            catch { NumViews = 0; }
            Console.WriteLine("Количество реакций на посте:");
            try
            {
                NumReactions = double.Parse(Console.ReadLine());
            }
            catch { NumReactions = 0; }
            Console.WriteLine("Количество комментариев на посте:");
            try
            {
                NumComments = double.Parse(Console.ReadLine());
            }
            catch { NumComments = 0; }
        }
        public void RandomInit()
        {
            NumComments = rand.Next(0, 1000);
            NumReactions = rand.Next(0, 1000);
            NumViews = rand.Next(0, 1000);
        }
        public static int GetCount => count;

        public override bool Equals(object obj)
        {

            Post otherPost = (Post)obj;

            return NumViews.Equals(otherPost.NumViews) &&
                   NumComments.Equals(otherPost.NumComments) &&
                   NumReactions.Equals(otherPost.NumReactions);
        }
    }
}
