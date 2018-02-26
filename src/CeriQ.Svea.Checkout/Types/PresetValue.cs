namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// Unknown
    /// </summary>
    public sealed class PresetValue
    {
        public string TypeName { get; }
        public string Value { get; }
        public bool IsReadOnly { get; }

        public PresetValue(string typeName, string value, bool isReadOnly)
        {
            TypeName = typeName;
            Value = value;
            IsReadOnly = isReadOnly;
        }
    }
}
