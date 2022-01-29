using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_report.Models
{
    public  class MainModel
    {
        public List<Municipality> municipioList { get; set; }

        public MainModel()
        {
            municipioList = new List<Municipality>();
        }

        public void addMunicipio(String[] stringM)
        {
            for (int i = 0; i < stringM.Length; i++)
            {
                String[] line = stringM[i].Split(",");
                Municipality m = new Municipality(line[0], line[1], line[2], line[3], line[4]);
                municipioList.Add(m);
            }
        }
    }
}
