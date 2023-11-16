using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.BuilderDesignPattern
{
    internal class PdfReport : AbstractReportBuilder
    {
        public override void SetReportBody()
        {
            ReportObject.ReportBody = "Pdf Report Body";
        }

        public override void SetReportFooter()
        {
            ReportObject.ReportFooter = "Pdf Report Footer";
        }

        public override void SetReportHeader()
        {
            ReportObject.ReportHeader = "Pdf Report Header";
        }

        public override void SetReportType()
        {
            ReportObject.ReportType = "Pdf Report Type";
        }
    }
}
