using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.BuilderDesignPattern
{
    internal abstract class AbstractReportBuilder
    {
        protected Report ReportObject { get; set; }
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportBody();
        public abstract void SetReportFooter();

        public void CreateReport()
        {
            ReportObject = new Report();
        }

        public Report GetReport()
        {
            return ReportObject;
        }

    }
}
