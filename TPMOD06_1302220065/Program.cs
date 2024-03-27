// See https://aka.ms/new-console-template for more information
namespace TPMOD06_1302220065;
class Program {
    public static void Main(String[] args)
    {
        SayaTubeUser s = new SayaTubeUser("Username");
        SayaTubeVideo v = new SayaTubeVideo("judul_video1");
        v.increasePlayCount(100000);
        s.addVideo(v);

        for (int i = 1; i <= 10; i++)
        {
            v = new SayaTubeVideo("judul_video "+i);
            v.increasePlayCount(1000 * i);
            s.addVideo(v);
        }
        s.PrintAllVideoCount();

        Console.WriteLine("Total video playcount allvideo :" + s.getVideoPlaycount());
    }
}