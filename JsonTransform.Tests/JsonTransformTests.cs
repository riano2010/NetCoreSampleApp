using JsonTransform;

namespace JsonTransform.Tests
{
    [TestClass]
    public class JsonTransformTests
    {
        [TestMethod]
        public void When_JsonHasNoUndefined_Then_Json_Is_Same()
        {
            var content = File.ReadAllText(".\\Content\\Json_Has_No_Undefined_Target.json");

            TargetProcessor targetProcessor = new TargetProcessor(content);
            targetProcessor.ProcessUndefined();
            string result = targetProcessor.Export();

            Assert.AreEqual(content, result);
        }
    }
}