using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            mcsEntity db = new mcsEntity();
            db.Database.Log =
                (s => System.Diagnostics.Debug.WriteLine(s));

            //List<TrackEvaluationComment> com = new List<TrackEvaluationComment>

            //List<TrackEvaluation> evalution = db.TrackEvaluation.Include(inc => inc.);

            //yavnaya zagruzka
            
        }
    }
}
