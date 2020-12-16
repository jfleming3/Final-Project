using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Final_Project
{
   [Serializable()]
    public class Buck : Deer
    {
        public int rackpoints;
        public double inside_spread;
        public double mainbeam;

        public Buck(int rp, double spread, double beam)
        {
            rackpoints = rp;
            inside_spread = spread;
            mainbeam = beam;
        }

        public Buck()
        {
        }


        public void setRack(int rp)
        {
            rackpoints = rp;
        } 

        public int getPoints()
        {
            return rackpoints;
        }

        public double getSpread()
        {
            return inside_spread;
        }

        public void setSpread(double spread)
        {
            inside_spread = spread;
        }

        public double getBeam()
        {
            return mainbeam;
        }

        public void setBeam(double beam)
        {
            mainbeam = beam;
        }



    }
}
