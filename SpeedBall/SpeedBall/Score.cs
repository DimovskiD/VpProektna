using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedBall
{
    [Serializable()]
    public class Score
    {
        public int score { get; set; }
        public String ID { get; set; }

        public Score()
        {
            score = 0;
            ID = "";
        }

        public Score(int s, String id)
        {
            ID = id;
            score = s;
        }

      
    }
}
