using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TPMOD06_1302220065
{
    internal class SayaTubeVideo 
    {
        private int id;
        private String title;
        private int PlayCount;
        public SayaTubeVideo(string judul)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = judul;
        }

        public int getPlayCount() {  return this.PlayCount; }

        public void increasePlayCount(int input) {
            try
            {
                checked
                {
                    this.PlayCount += input;
                }
            }catch (OverflowException ex)
            {
                Console.WriteLine("Play count is too high to increment \n");
            }
        }
        public void PrintVideoDetail() {
            Console.WriteLine("id : " + this.id);
            Console.WriteLine("title : " + this.title);
            Console.WriteLine("PlayCount : " + this.PlayCount);
        }
    }
}
