namespace CeriQ.Svea.Checkout.Types
{
    public class Gui
    {
        public string Layout { get; }
        public string Snippet { get; }
        public Gui(string layout, string snippet)
        {
            Layout = layout;
            Snippet = snippet;
        }
    }
}
