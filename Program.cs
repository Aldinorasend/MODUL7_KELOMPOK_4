﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL7_KELOMPOK_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302223071 dataMahasiswa = new DataMahasiswa_1302223071();
            dataMahasiswa.ReadJSON();
            Console.ReadLine();
            TeamMembers team = new TeamMembers();
            team.ReadJSON();
            Console.ReadLine();

        }
    }
}
