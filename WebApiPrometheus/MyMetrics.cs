using Prometheus;

namespace LearnMetricsSample
{
    public class MyMetrics
    {
        public static readonly Counter TotalLetterMetric = Metrics
    .CreateCounter("myapp_letter_total",
            "Total number of letter in file.",
            new CounterConfiguration { LabelNames = new[] { "letter" } });

        public static readonly Histogram LetterOccurrenceMetric = Metrics.CreateHistogram("myapp_letter_occurrence",
            "Number of letter in file", new HistogramConfiguration
            {
                Buckets = Histogram.LinearBuckets(start: 0, width: 10, count: 25),
            });

        public static readonly Summary LetterSummaryMetric = Metrics.CreateSummary("myapp_letter_summary",
            "Summary metric example");

        public static readonly Gauge LetterGuageMetric = Metrics.CreateGauge("myapp_letter_gauge",
            "Guage metric example");
    }
}
