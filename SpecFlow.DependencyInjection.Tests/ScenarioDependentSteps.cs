using BoDi;
using TechTalk.SpecFlow;
using Xunit;

namespace SolidToken.SpecFlow.DependencyInjection.Tests
{
    [Binding]
    public class ScenarioDependentSteps
    {
        private readonly ITestService testService;

        //[BeforeScenario]
        //public void InitializeSpecificTestService()
        //{
        //    // here we would need to inject SpecificTestService into the ServiceCollection
        //    // 1) how do we get to the servicecollection
        //    var oc = ScenarioContext.Current.GetBindingInstance(typeof(BoDi.IObjectContainer));

        //}

        public ScenarioDependentSteps(ITestService testService)
        {
            this.testService = testService;
        }

        [Then(@"verify that specific dependency is correctly injected")]
        public void ThenVerifyThatSpecificDependencyIsCorrectlyInjected()
        {
            Assert.False(testService.Verify());
        }
    }

    public class SpecificTestService : ITestService
    {
        public bool Verify()
        {
            return false;
        }
    }

    [Binding]
    public class BeforeScenarioTest
    {
        private readonly IObjectContainer objectContainer;

        public BeforeScenarioTest(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeBeforeScenarioTest()
        {

        }
    }
}
