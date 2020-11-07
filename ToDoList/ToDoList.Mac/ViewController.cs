﻿using System;

using AppKit;
using Foundation;

namespace ToDoList
{
    public partial class ViewController : NSViewController
    {
        private int numberOfTimesClicked = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Set the initial value for the label
            ClickedLabel.StringValue = "Button has not been clicked yet.";
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void ClickedButton(NSObject sender)
        {
            ClickedLabel.StringValue = string.Format("The button has been clicked {0} time{1}."
                , ++numberOfTimesClicked, (numberOfTimesClicked < 2) ? "" : "s");
        }
    }
}
