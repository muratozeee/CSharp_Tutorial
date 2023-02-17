using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsulationMethodExam
{
    internal class RealEstate
    {
        private String district;
        private String color;
        private String roomNum;
        private int floornum;
        private double area;

        public String District
        {
            get { return district; }
            set { district = value.ToLower(); }  


        }
        public String Color
        {
            get { return color; }
            set { color = value.ToUpper(); }


        }
        public String RoomNum
        {
            get { return roomNum; }
            set { roomNum =value; }
        }
        public double Area
        {
            get { return area; }
            set { area = Math.Abs(value); }


        }
        public int FloorNum
        {
            get { return floornum; }
            set { floornum = Math.Abs(value); }
        }
    }
}
   
    
