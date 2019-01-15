using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace MAF.LearnMobile.XamarinAndroid_1
{
    [Activity( Label = "@string/app_name" , Theme = "@style/AppTheme" , MainLauncher = true )]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate ( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );
            // Set our view from the "main" layout resource
            SetContentView( Resource.Layout.activity_main );

            // New code
            EditText phoneNumberText = FindViewById<EditText>( Resource.Id.PhoneNumberText );
            TextView translatedPhoneWord = FindViewById<TextView>( Resource.Id.TranslatedPhoneword );
            Button translateButton = FindViewById<Button>( Resource.Id.TranslateButton );
            
        }
    }
}