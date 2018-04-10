using System;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace ViewPagerTest
{
    public class TreePagerAdapter : PagerAdapter
    {
        Context context;
        TreeCatalog treeCatalog;

        public TreePagerAdapter(Context context, TreeCatalog treeCatalog)
        {
            this.context = context;
            this.treeCatalog = treeCatalog;
        }

        public override int Count
        {
            get { return treeCatalog.NumTrees; }
        }

        public override bool IsViewFromObject(View view, Java.Lang.Object obj)
        {
            return view == obj;
        }

        public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        {
            var imageView = new ImageView(context);
            imageView.SetImageResource(treeCatalog[position].imageId);
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(imageView);
            viewPager.AddOnPageChangeListener(new CircularViewPagerHandler(viewPager));
            return imageView;
        }


        public override void DestroyItem(ViewGroup container, int position, Java.Lang.Object view)
        {
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.RemoveView(view as View);
        }
        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(treeCatalog[position].caption);
        }
    }
}