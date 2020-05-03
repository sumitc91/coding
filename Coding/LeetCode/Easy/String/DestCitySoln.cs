using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class DestCitySoln
    {
        public void execute()
        {
            IList<IList<string>> paths = new List<IList<string>>();
            var path = new List<string>();
            path.Add("B");
            path.Add("C");
            paths.Add(path);

            path = new List<string>();
            path.Add("D");
            path.Add("B");
            paths.Add(path);

            path = new List<string>();
            path.Add("C");
            path.Add("A");
            paths.Add(path);

            var res = DestCity(paths);
        }

        public string DestCity(IList<IList<string>> paths)
        {
            var dict = new Dictionary<string, string>();
            for (int i = 0; i < paths.Count; i++)
            {
                dict.Add(paths[i][0], paths[i][1]);
            }

            string finalDest=null;
            string destination = paths[0][1];
            while(destination != null)
            {
                if (dict.ContainsKey(destination))
                {
                    destination = dict[destination];
                }
                else
                {
                    finalDest = destination;
                    destination = null;
                }
            }

            return finalDest;
        }
    }
}
