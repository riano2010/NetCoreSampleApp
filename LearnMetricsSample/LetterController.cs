using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnMetricsSample
{
    [Route("api/[controller]")]
    [ApiController]
    public class LetterController : ControllerBase
    {
        [HttpPost]
        public async void Calculate(string url = "https://www.lipsum.com/")
        {
            var chars = await GetPage(url);

            Dictionary<char, int> lettersCount = new Dictionary<char, int>();

            foreach (char c in chars)
            {
                if (lettersCount.ContainsKey(c))
                {
                    lettersCount[c]++;
                }
                else
                {
                    lettersCount.Add(c, 1);
                }
            }

            foreach (char c in lettersCount.Keys)
            {
                var label = GetLabel(c);

                MyMetrics.TotalLetterMetric.WithLabels(label).Inc(lettersCount[c]);
                MyMetrics.LetterOccurrenceMetric.Observe(c, lettersCount[c]);
                MyMetrics.LetterSummaryMetric.Observe(c);


                if (label == "upper")
                {
                    MyMetrics.LetterGuageMetric.Dec(lettersCount[c]);
                }
                else
                {
                    MyMetrics.LetterGuageMetric.Inc(lettersCount[c]);
                }
            }
        }

        private static string GetLabel(char c)
        {
            var label = "other";
            if (97 <= c && c <= 122)
            {
                label = "lower";
            }
            else if (c >= 065 && c <= 090)
            {
                label = "upper";
            }

            return label;
        }

        private static async Task<byte[]> GetPage(string url)
        {
            using HttpClient httpClient = new();

            var httpResponseMessage = await httpClient.GetAsync(url);
            byte[] str = await httpResponseMessage.Content.ReadAsByteArrayAsync();

            return str;
        }
    }

}
