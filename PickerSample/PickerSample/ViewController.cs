using System;

using UIKit;
using CountryPickerBind;
using System.Diagnostics;

namespace PickerSample
{

    public class MyCountryPickerDelegate: CountryPickerDelegate{

        public override void DidSelectCountryWithName(CountryPicker picker, string name, string code)
        {
            Debug.WriteLine(name,code);
        }
    }

    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            picker.Delegate = new MyCountryPickerDelegate();       
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
