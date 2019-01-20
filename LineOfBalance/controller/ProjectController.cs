using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineOfBalance.entities;
using MSProject = Microsoft.Office.Interop.MSProject;

namespace LineOfBalance.controller
{
    class ProjectController
    {
        public int NumberOfUnits { get; set; }
        public double ProjectDeadline { get; set; }
        public string UnitName { get; set; }
        public Project ActualProject { get; private set; }
        public Project CalculatedProject { get; private set; }
        public ThisAddIn ThisAddIn { get; set; }

        public ProjectController(ThisAddIn thisAddIn)
        {
            ThisAddIn = thisAddIn;
        }

        public void CalculateLineOfBalance()
        {
            MSProject.Project project = ThisAddIn.Application.ActiveProject;
        }
    }
}
