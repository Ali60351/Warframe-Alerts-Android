using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Util;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace WF_Alerts
{
    [Activity(Label = "WF Alerts", MainLauncher = true, Icon = "@drawable/ic_launcher")]
    public class MainActivity : AppCompatActivity
    {
        private ViewPager _viewPager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            AndroidEnvironment.UnhandledExceptionRaiser += (sender, args) =>
            {
                Log.Error("WFA", "Recieved exception " + args.ToString() + "from thread " + sender.ToString(), args);
            };

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Warframe Alerts";

            _viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            _viewPager.Adapter = new PageAdapter(SupportFragmentManager, this);

            Window.SetNavigationBarColor(Android.Graphics.Color.Rgb(0, 103, 91));

            var tabLayout = FindViewById<TabLayout>(Resource.Id.tabs);
            tabLayout.SetupWithViewPager(_viewPager);
        }
    }
}

