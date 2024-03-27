using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title != null && title.Length < 200);
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
                    if (input >= 25000000 || input < 0)
                    {
                        Console.WriteLine("input playcount tidak boleh melebihi nilai maximum atau kurang dari 0;");
                    }
                    else {
                        this.PlayCount += input;
                    }
                    
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
