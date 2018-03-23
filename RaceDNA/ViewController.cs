using System;

using UIKit;

namespace RaceDNA
{
    public partial class MainViewController : UIViewController
    {
       

        public MainViewController(IntPtr handle) : base(handle)
        {

           
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void AddNewBoatButton_TouchUpInside(UIButton sender)
        {
            UIView view1 = new UIView();
            view1.BackgroundColor = UIColor.Blue;

            //view1.HeightAnchor.ConstraintEqualTo(10);
            //view1.WidthAnchor.ConstraintEqualTo(12);

            UIView view2 = new UIView();
            view1.BackgroundColor = UIColor.Red;

            //view2.HeightAnchor.ConstraintEqualTo(10);
            //view2.WidthAnchor.ConstraintEqualTo(12);


            //YachtDataStackView.AddArrangedSubview(view1);
            //YachtDataStackView.AddArrangedSubview(view2);
           
        }
    }
}