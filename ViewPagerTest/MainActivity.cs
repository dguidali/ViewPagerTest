using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;

namespace ViewPagerTest
{
    [Activity(Label = "ViewPagerTest", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            TreeCatalog treeCatalog = new TreeCatalog();
            viewPager.Adapter = new TreePagerAdapter(this, treeCatalog);
            viewPager.SetCurrentItem(1, false);
        }
    }
}

