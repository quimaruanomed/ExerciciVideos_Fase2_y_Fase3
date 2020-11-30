using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;

namespace Exercici3VideosFases_3.Clases
{
    public class Video
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public List<string> Tags { get; set; }

        public Video() //Constructor clase Video 
        {

        }
        public Video(string x, string y)
        {

        }
              
        public static List<Video> vList = new List<Video>
        {
            new Video { Url= "https://www.youtube.com/watch?v=5__I6HAYG1I", Title="Pearl harbor sound track"},
            new Video { Url= "https://www.youtube.com/watch?v=-yOZEiHLuVU&list=RD2-OXumCN9XM&index=2", Title="Gladiator - Now We Are Free Super Theme Song"},
            new Video { Url= "https://www.youtube.com/watch?v=XwtbKaHvIMk&list=RD2-OXumCN9XM&index=3", Title="" },new Video { Url= "https://www.youtube.com/watch?v=SnL1e4-NfaA&list=RD2-OXumCN9XM&index=9", Title= "Sarah Mclachlan - In The Arms Of The Angel" },
            new Video { Url= "https://www.youtube.com/watch?v=V4L_NrsW3WU&list=RD2-OXumCN9XM&index=11", Title= "John Barry - The Old Woman"} };

    }
    

}

