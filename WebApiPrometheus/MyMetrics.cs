using Prometheus;

namespace WebApiPrometheus
{
    public class MyMetrics
    {
        public static readonly Counter GetForecatsMetric = Metrics
    .CreateCounter("myapp_get_forecast_total", "Number of call get forecast.");
    }
}
