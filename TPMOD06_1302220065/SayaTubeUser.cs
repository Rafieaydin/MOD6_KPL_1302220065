using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD06_1302220065
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideo;
        public String username;
        public SayaTubeUser(string username)
        {
            Random random = new Random();
            this.id = random.Next(10000,99999);
            this.username = username;
            this.uploadedVideo = new List<SayaTubeVideo>();
        }

        public void addVideo(SayaTubeVideo video)
        {
            this.uploadedVideo.Add(video);
        }

        public int getVideoPlaycount()
        {
            int total = 0;
            foreach (var x in uploadedVideo)
            {
                total += x.getPlayCount();
            }
            return total;
        }

        public void PrintAllVideoCount() {
            Console.WriteLine("User : " + this.username);
            int i = 0;
            foreach (var x in uploadedVideo)
            {
                i++;
                Console.WriteLine("Video ke : " + i);
                x.PrintVideoDetail();
                Console.WriteLine();
            }
        }
    }
}
