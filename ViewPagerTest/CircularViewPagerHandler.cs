using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using static Android.Support.V4.View.ViewPager;

namespace ViewPagerTest
{
    public class CircularViewPagerHandler : Java.Lang.Object, IOnPageChangeListener
    {
        private ViewPager mViewPager;
        private int mCurrentPosition;
        private int mScrollState = -1;


        public CircularViewPagerHandler(ViewPager viewPager)
        {
            mViewPager = viewPager;
        }

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {            
        }

        public void OnPageScrollStateChanged(int state)
        {
            if (mScrollState != state)
            {
                handleScrollState(state);
                mScrollState = state;
            }
        }

        //JAVA TO C# CONVERTER WARNING: 'final' parameters are not available in .NET:
        //ORIGINAL LINE: private void handleScrollState(final int state)
        private void handleScrollState(int state)
        {
            if (state == ViewPager.ScrollStateIdle)
            {
                setNextItemIfNeeded();
            }
        }

        private void setNextItemIfNeeded()
        {
            if (ScrollStateSettling)
            {
                handleSetNextItem();
            }
        }

        private bool ScrollStateSettling
        {
            get
            {
                return mScrollState == ViewPager.ScrollStateSettling;
            }
        }

        private void handleSetNextItem()
        {
            int lastPosition = mViewPager.Adapter.Count - 1;
            if (mCurrentPosition == 0)
            {
                mViewPager.SetCurrentItem(lastPosition -1, false);
            }
            else if (mCurrentPosition == lastPosition)
            {
                mViewPager.SetCurrentItem(1, false);
            }
        }

        public void OnPageSelected(int position)
        {
            mCurrentPosition = position;
        }
    }
}