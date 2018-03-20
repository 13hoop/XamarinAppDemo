using System;

using UIKit;

namespace VSAppTest
{
    public partial class MyViewController : UIViewController
    {
        public MyViewController() : base("MyViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            setUpViews();
        }

        void setUpViews() {
            base.View.BackgroundColor = UIColor.Magenta;
        }
    }
}

