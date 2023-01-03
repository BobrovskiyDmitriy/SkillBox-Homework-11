using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_part_1
{
    interface IPerson
    {
        string Last_name { get; set; }
        string First_name { get; set; }
        string Middle_name { get; set; }
        string Phone_numb { get; set; }
        string Passport { get; set; }

    }
}
