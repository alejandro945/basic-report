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

        public List<Municipality> filterMunicipality(String type)
        {
            List<Municipality> listFilter = new List<Municipality>();
            foreach(Municipality m in municipioList)
            {
                if(m.type == type)
                {
                    listFilter.Add(m);
                }
            }
            return listFilter;
        }

        public List<String> getDepartment()
        {
            List<String> departments = new List<string>();
            foreach(Municipality m in municipioList)
            {
                if (!(departments.Contains(m.nameD))){
                    departments.Add(m.nameD);
                }
            }
            
            return departments;
        }

        public List<int> countM()
        {
            List<int> list = new List<int>();
            foreach(String m in getDepartment())
            {
                int count = 0;
                foreach (Municipality mc in municipioList)
                {
                    if (m.Equals(mc.nameD))
                    {
                        count++;
                    }
                }
                list.Add(count);
            }
            return list;
        }

    }
}
