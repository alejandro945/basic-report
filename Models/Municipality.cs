using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_report.Models
{
    public class Municipality
    {

    public String IDD { get; set; }
    public String IDM { get; set; }
    public String nameD { get; set; }
    public String nameM { get; set; }
    public String type { get; set; }

    public Municipality(String IDD, String IDM, String nameD, String nameM, String type)
    {
        this.IDD = IDD;
        this.IDM = IDM;
        this.nameD = nameD;
        this.nameM = nameM;
        this.type = type;
    }
}
}