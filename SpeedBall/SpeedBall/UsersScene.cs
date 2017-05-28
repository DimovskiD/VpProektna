using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedBall
{
    [Serializable]
    class UsersScene
    {
        public List<User> lista { get; set; }
        public UsersScene()
        {
            lista = new List<User>();
        }
        public void AddUser(User user)
        {
            lista.Add(user);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (lista.Count != 0)
            {
                if (lista.Count >= 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        sb.Append(string.Format("{0}", lista[i]));
                        sb.Append("\n");

                    }
                }
                else
                {
                    for (int i = 0; i < lista.Count
                        ; i++)
                    {
                        sb.Append(string.Format("{0}", lista[i]));
                        sb.Append("\n");

                    }
                }
            }
            return sb.ToString();
        }
        public void Sort()
        {
            lista.Sort(delegate (User s1, User s2) { return -1 * s1.Score.CompareTo(s2.Score); });
        }
        public string Checking(int score)
        {
            if (lista.Count != 0)
            {
                Sort();
                foreach (User u in lista)
                {
                    if (score > u.Score)
                        return u.Name;

                }
            }
            return null;
        }
        public int maxScore()
        {
            if (lista.Count != 0)
            {
                int max = lista[0].Score;
                for (int i = 1; i < lista.Count; i++)
                {
                    if (max < lista[i].Score)
                    {
                        max = lista[i].Score;
                    }
                }
                return max;
            }
            return 0;
        }
     
       
    }
}
