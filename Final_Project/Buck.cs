using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Final_Project
{
    [Serializable()]
    public class Buck : Deer
    {
        private int rackpoints;
        private double inside_spread;
        private double mainbeam;

        public Buck(int rp, double spread, double beam)
        {
            rackpoints = rp;
            inside_spread = spread;
            mainbeam = beam;
        }

        public Buck()
        {
        }

        override
        public void write(ref XmlTextWriter writer)
        {
            writer.WriteElementString("Rack Points", Convert.ToString(rackpoints));
            writer.WriteElementString("Inside Spread", Convert.ToString(inside_spread));
            writer.WriteElementString("mainbeam", Convert.ToString(mainbeam));
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
