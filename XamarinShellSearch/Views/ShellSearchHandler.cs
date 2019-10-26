using Xamarin.Forms;

namespace XamarinShellSearch.Views
{
    class ShellSearchHandler : SearchHandler
    {
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
        }

        protected override void OnQueryConfirmed()
        {
            base.OnQueryConfirmed();
        }

        protected override void OnUnfocus()
        {
            base.OnUnfocus();
        }

        protected override void OnFocused()
        {
            base.OnFocused();
        }

        protected override void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
        }

        protected override void OnClearPlaceholderClicked()
        {
            base.OnClearPlaceholderClicked();
        }
    }
}
