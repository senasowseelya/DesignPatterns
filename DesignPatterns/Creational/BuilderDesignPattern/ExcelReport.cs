namespace DesignPatterns.Creational.BuilderDesignPattern
{
    internal class ExcelReport : AbstractReportBuilder
    {
        public override void SetReportBody()
        {
            ReportObject.ReportBody = "Excel Report Body";
        }

        public override void SetReportFooter()
        {
            ReportObject.ReportFooter = "Excel Report Footer";

        }

        public override void SetReportHeader()
        {
            ReportObject.ReportHeader = "Excel Report Header";

        }

        public override void SetReportType()
        {
            ReportObject.ReportType = "Excel Report";

        }
    }
}
