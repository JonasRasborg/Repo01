using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AgentAssignment
{
    public class Specialities : ObservableCollection<string>
    {
        public Specialities()
        {
            Add("Assassination");
            Add("Bombs");
            Add("Martinis");
            Add("Low profile");
            Add("Spy");
        }
    }
}

