using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.Hooks
{
    [Binding]
    public sealed class GeneralHook
    {
        [AfterStep]
        public void AfterStep()
        {
            var featureTitle = FeatureContext.Current.FeatureInfo.Title;
            var scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            var scenarioTag = ScenarioContext.Current.ScenarioInfo.Tags;
            var stepInfo = ScenarioContext.Current.StepContext.StepInfo.Text;

            Console.WriteLine($"FeaturTitle: {featureTitle} and ScenarioTitle = {scenarioTitle} with scenarioTag {scenarioTag.FirstOrDefault()}");
            Console.WriteLine($"Step: {stepInfo}");
        }
    }
}
