using Android.OS;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;

namespace WF_Alerts
{
    internal class PageFragment : Fragment
    {
        public static string ArgPage = "ARG_PAGE";
        private int _page;

        public static PageFragment NewInstance(int page)
        {
            var args = new Bundle();
            args.PutInt(ArgPage, page);
            var fragment = new PageFragment {Arguments = args};
            return fragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            _page = Arguments.GetInt(ArgPage);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var v = inflater.Inflate(Resource.Layout.Fragment_Page, container, false);
            var tv = (TextView) v;
            tv.Text = "Fragment #" + _page;
            return v;
        }
    }
}