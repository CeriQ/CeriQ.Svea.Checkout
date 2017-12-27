namespace CeriQ.Svea.Checkout.Types
{
    public class PresetValue
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
