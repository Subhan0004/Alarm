using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace MyClock
{
    public static class Melody
    {
        public static void Melody1_play() 
        {
            SoundPlayer player1 = new SoundPlayer("sound1.wav");
            player1.Play();
        }
        public static void Melody1_stop()
        {
            SoundPlayer player1 = new SoundPlayer("sound1.wav");
            player1.Stop();
        }
        public static void Melody2_play()
        {
            SoundPlayer player2 = new SoundPlayer("sound2.wav");
            player2.Play();
        }
        public static void Melody2_stop()
        {
            SoundPlayer player2 = new SoundPlayer("sound2.wav");
            player2.Stop();
        }
    }
}
