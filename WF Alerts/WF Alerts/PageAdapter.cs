using System.Collections.Generic;
using Android.Content;
using Android.Support.V4.App;
using Java.Lang;
using Fragment = Android.Support.V4.App.Fragment;

namespace WF_Alerts
{
    internal class PageAdapter : FragmentPagerAdapter
    {
        private readonly List<string> _titles = new List<string>()
        {
            "Alerts", "Invasions"
        };

        private Context _context;

        public PageAdapter(Android.Support.V4.App.FragmentManager fm, Context context) : base(fm)
        {
            _context = context;
        }

        public override int Count { get; } = 2;

        public override Fragment GetItem(int position)
        {
            return PageFragment.NewInstance(position + 1);
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(_titles[position]);
        }
    }
}