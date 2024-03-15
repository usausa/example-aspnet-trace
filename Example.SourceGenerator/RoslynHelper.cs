namespace Example;

using Microsoft.CodeAnalysis;

internal static class RoslynHelper
{
    public static string GetNameSpace(ISymbol classSymbol) =>
        classSymbol.ContainingNamespace.IsGlobalNamespace
            ? string.Empty
            : classSymbol.ContainingNamespace.ToDisplayString();

    public static bool IsAsyncType(INamedTypeSymbol symbol) =>
        symbol.GetAttributes().Any(attr => attr.AttributeClass?.Name == "AsyncMethodBuilderAttribute");

    public static string ToAccessibilityText(Accessibility accessibility) => accessibility switch
    {
        Accessibility.Public => "public",
        Accessibility.Protected => "protected",
        Accessibility.Private => "private",
        Accessibility.Internal => "internal",
        Accessibility.ProtectedOrInternal => "protected internal",
        Accessibility.ProtectedAndInternal => "private protected",
        _ => throw new NotSupportedException()
    };
}
