using System.Collections.Generic;

namespace Sunmax0731.UnityBuildPackagePrereleaseSuite
{
    public static class PrereleaseRuleEngine
    {
        private static readonly string[] RequiredFields = new[]
        {
            "packagePath",
            "version",
            "buildTarget",
            "manualEvidence"
        };

        public static IEnumerable<string> EvaluateSample()
        {
            foreach (var field in RequiredFields)
            {
                yield return "OK: required field configured - " + field;
            }
            yield return "INFO: review cards summarize package, evidence, manual test, and release readiness.";
            yield return "ERROR: missing field example is detected before release.";
        }
    }
}
