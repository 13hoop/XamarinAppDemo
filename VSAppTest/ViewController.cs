using System;

using UIKit;

namespace VSAppTest
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            setUpViews();
        }

        void setUpViews()
        {
            base.View.BackgroundColor = UIColor.Magenta;



        }

        UIButton Button {
            get;
        }
    }
}
