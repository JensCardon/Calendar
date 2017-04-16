using System;

using UIKit;

namespace Calendar.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController() : base("ViewController", null)
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

		partial void Test_TouchUpInside(UIButton sender){
			
	}
}

