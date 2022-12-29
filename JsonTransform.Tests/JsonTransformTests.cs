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

        [TestMethod]
        public void When_JsonHas_4_Undefined_Target_Then_4_Target_Is_Created()
        {
            var content = File.ReadAllText(".\\Content\\Json_Has_4_Undefined_Target.json");
            var resultExpected = File.ReadAllText(".\\Content\\Json_Has_4_Undefined_Target.result.json");

            TargetProcessor targetProcessor = new TargetProcessor(content);
            targetProcessor.ProcessUndefined();
            string result = targetProcessor.Export();

            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void When_JsonHas_Undefined_And_Company_Target_Then_Is_Ok()
        {
            var content = File.ReadAllText(".\\Content\\Json_Has_Undefined_And_Company.json");
            var resultExpected = File.ReadAllText(".\\Content\\Json_Has_Undefined_And_Company.result.json");

            TargetProcessor targetProcessor = new TargetProcessor(content);
            targetProcessor.ProcessUndefined();
            string result = targetProcessor.Export();

            Assert.AreEqual(resultExpected, result);
        }
    }
}