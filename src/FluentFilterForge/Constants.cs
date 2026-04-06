namespace FluentFilterForge;

internal static class Constants
{
    internal const string SuppressMessageS2436Category = "Major Code Smell";
    internal const string SuppressMessageS2436CheckId = "S2436: Types and methods should not have too many generic parameters";
    internal const string SuppressMessageS2436Justification = "This is a builder pattern, and the generic parameters are necessary to maintain type safety and fluency in the API.";
}
