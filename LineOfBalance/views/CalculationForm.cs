using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LineOfBalance.controller;

namespace LineOfBalance.views
{
    public partial class CalculationForm : Form
    {

        private ProjectController Controller;

        public CalculationForm()
        {
            InitializeComponent();
        }

        public CalculationForm(ThisAddIn thisAddIn) : this()
        {
            Controller = new ProjectController(thisAddIn);
        }

        private void CalculationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbRepetitiveUnits.Text);
            double deadline = double.Parse(tbProjectDuration.Text);
            string unitName = tbName.Text;

            Controller.NumberOfUnits = number;
            Controller.ProjectDeadline = deadline;
            Controller.UnitName = unitName;

            Controller.CalculateLineOfBalance();
        }
    }
}
