namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// Represents the form to display to the user so they can complete the checkout.
    /// </summary>
    public sealed class Gui
    {
        /// <summary>
        /// Represents the layout, ie "Desktop" or "Mobile" that the Gui is for.
        /// </summary>
        public string Layout { get; }
        /// <summary>
        /// The actual HTML code to inject on the webpage to display the GUI.
        /// </summary>
        public string Snippet { get; }
        public Gui(string layout, string snippet)
        {
            Layout = layout;
            Snippet = snippet;
        }
    }
}
