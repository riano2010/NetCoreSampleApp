using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace JsonTransform
{
    public class TargetProcessor
    {
        public string Json { get; private set; }

        private JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = true,            
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
        };

        private JsonNode? _jsonNode = null;

        public TargetProcessor(string json)
        {
            Json = json;
        }        

        private IEnumerable<JsonNode> ProccessUndefinedTarget(JsonNode node)
        {
            List<JsonNode> results = new List<JsonNode>();

            JsonArray products = node["products"]!.AsArray();
            if (products == null || !products.Any())
            {
                results.Add(node);
                return results;
            }

            foreach (JsonNode product in products)
            {
                JsonObject target = new JsonObject()
                {
                    ["targetType"] = new JsonObject()
                    {
                        ["codeName"] = "TARGET_UNDEFINED_CLIENT",
                        ["name"] = "Неопределенный клиент"
                    },
                    ["products"] = new JsonArray()
                    {
                        
                    }
                };

                if (product != null)
                {
                    var productNoParent = JsonNode.Parse(product.ToJsonString());
                    target["products"]?.AsArray().Add(productNoParent);

                    results.Add(target);
                }
            }

            return results;
        }

        public void ProcessUndefined()
        {
            try
            {
                _jsonNode = JsonNode.Parse(Json);
            }
            catch (JsonException ex)
            {
                throw new ArgumentException(ex.Message);
            }

            var targets = _jsonNode!["request"]!["payload"]!["targets"]!.AsArray();
            var undefinedTargets = targets.Where(_ => _!["targetType"]!["codeName"]!.GetValue<string>() == "TARGET_UNDEFINED_CLIENT").ToArray();

            if (undefinedTargets == null || !undefinedTargets.Any())
            {
                return;
            }

            var resultTargets = new List<JsonNode>();

            foreach (var undefinedTarget in undefinedTargets)
            {
                resultTargets.AddRange(ProccessUndefinedTarget(undefinedTarget));
                targets.Remove(undefinedTarget);
            }

            resultTargets.ForEach(_ => targets.Add(_));
        }

        public string Export()
        {
            if (_jsonNode == null)
                return string.Empty;

            return _jsonNode.ToJsonString(_options);
        }
    }
}
