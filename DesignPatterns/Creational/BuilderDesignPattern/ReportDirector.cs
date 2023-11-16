namespace DesignPatterns.Creational.BuilderDesignPattern
{
    internal class ReportDirector
    {
        public AbstractReportBuilder _report { get; }
        private static Report Report { get; set; }
        public ReportDirector(AbstractReportBuilder report)
        {
            _report = report;
        }

        public Report BuildReport()
        {
            _report.CreateReport();
            _report.SetReportType();
            _report.SetReportHeader();
            _report.SetReportBody();
            _report.SetReportFooter();
            Report = _report.GetReport();
            return Report;
        }


    }
}
