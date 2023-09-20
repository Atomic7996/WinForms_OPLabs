using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary_OPLabs
{
    public struct Pilot
    {
        public string? fio;
        public int workExperience;

        public Pilot() { }

        public Pilot(string fio, int workExperience)
        {
            this.fio = fio;
            this.workExperience = workExperience;
        }
    }
}