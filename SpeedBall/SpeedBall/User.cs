using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedBall
{
    [Serializable]
    class User
    {
  
        public string Name { get; set; }
        public int Score { get; set; }
        public User(string Name)
        {
            this.Name = Name;
        
        }
        public void SetScore(int score)
        {
            Score = score;
        }
        public override string ToString()
        {
            return String.Format("{0}-{1}", Name, Score);
        }
    }
}
