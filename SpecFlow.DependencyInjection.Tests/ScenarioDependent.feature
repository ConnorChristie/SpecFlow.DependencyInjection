Feature: ScenarioDependent
    Issue #29: Add to ServiceCollection depending of Feature or Scenario
    https://github.com/solidtoken/SpecFlow.DependencyInjection/issues/29

# Can we change the registered services based upon Scenario metadata?
# ie `if (Scenario.title == 'action') then services.Replace<IBar, IFoo>()`
# More thoughts/criteria:
# - feature/scenario/steps should be ambivalent
# - servicecollection is 'static/readonly' ie how would you change that outside `CreateServices`
# - look at timing of `CreateServices` (apppears to be for every Feature)
#   - when is it called (can we intervene before BuildServiceProvider?)
#   - is parallelism an issue?

Scenario: Add dependency specific for Scenario
    Then verify that specific dependency is correctly injected
