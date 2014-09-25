namespace Peons.Rules
{
    public class Enforcer : IEnforcer
    {
        public IRule<T> GetBrokenRule<T>(IRule<T>[] rules, T target)
        {
            if (rules == null)
                throw new ArgNullException(() => rules);

            foreach (var rule in rules)
            {
                if (!rule.AppliesTo(target))
                {
                    return rule;
                }
            }
            return null;
        }

        public IRule<T> GetBrokenRule<T>(IRuleList<T> ruleList, T target)
        {
            if (ruleList == null)
                throw new ArgNullException(() => ruleList);

            return this.GetBrokenRule(ruleList.Rules, target);
        }
    }
}
