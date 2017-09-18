using IPadNumericKeyboard.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(EntryControlRenderer))]
namespace IPadNumericKeyboard.iOS.Renderers
{
    public class EntryControlRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                if (e.NewElement != null && e.NewElement.Keyboard == Keyboard.Numeric && Device.Idiom == TargetIdiom.Tablet)
                {
                    //Set keyboard view
                    Control.InputView = GetNumericKeyboard();
                    Control.ReloadInputViews();

                    // To remove keyboard suggestions bar
                    Control.AutocorrectionType = UITextAutocorrectionType.No;
                    Control.InputAssistantItem.LeadingBarButtonGroups = new UIBarButtonItemGroup[0];
                    Control.InputAssistantItem.TrailingBarButtonGroups = new UIBarButtonItemGroup[0];
                }
            }
        }

        private iPadNumericKeyboard GetNumericKeyboard()
        {
            var numericKeyboard = iPadNumericKeyboard.Create();
            numericKeyboard.SetNativeControl(Control);
            numericKeyboard.SetElement(Element);
            return numericKeyboard;
        }
    }
}
