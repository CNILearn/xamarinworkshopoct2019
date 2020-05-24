using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace MyAndroidApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += (sender, e) =>
            {
                Toast.MakeText(ApplicationContext, Resource.String.hello, ToastLength.Long).Show();
            };

            Button showBooksButton = FindViewById<Button>(Resource.Id.buttonshowlist);
            showBooksButton.Click += (sender, e) =>
            {
                StartActivity(typeof(BooksListActivity));
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}