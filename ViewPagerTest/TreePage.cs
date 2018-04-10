using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ViewPagerTest
{

    // TreePage: contains image resource ID and caption for a tree:
    public class TreePage
    {
        // Image ID for this tree image:
        public int imageId;

        // Caption text for this image:
        public string caption;

        // Returns the ID of the image:
        public int ImageID { get { return imageId; } }

        // Returns the caption text for the image:
        public string Caption { get { return caption; } }
    }   
}