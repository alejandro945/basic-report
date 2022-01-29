using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicReport.Model
{
    public class Municipality
    {

        private int IDD;
        private int IDM;
        private String nameD;
        private String nameM;
        private String type;

        public Municipality(int IDD, int IDM, String nameD, String nameM, String type)
        {
            this.IDD = IDD;
            this.IDM = IDM;
            this.nameD = nameD;
            this.nameM = nameM;
            this.type = type;
        }

        public int getIDD()
        {
            return IDD;
        }

        public int getIDM()
        {
            return IDM;
        }

        public String getNameD()
        {
            return nameD;
        }

        public String getNameM()
        {
            return nameM;
        }

        public String getType()
        {
            return type;
        }
    }
}