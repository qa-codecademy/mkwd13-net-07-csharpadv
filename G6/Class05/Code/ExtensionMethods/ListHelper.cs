namespace ExtensionMethods
{
    public static class ListHelper
    {
        public static string GetInfo<T>(this List<T> items)
        {
            return $"This list has {items.Count} members {items.FirstOrDefault()?.GetType().Name}";
        }
    }
}
