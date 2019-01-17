using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

using Android.Content;
using System.Collections.Generic;

namespace MAF.LearnMobile.XamarinAndroid_1
{
    [Activity( Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true )]
    public class MainActivity : AppCompatActivity
    {
        static readonly List<string> phoneNumbers = new List<string>();

        protected override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate( savedInstanceState );
            // Set our view from the "main" layout resource
            SetContentView( Resource.Layout.activity_main );

            // New code
            EditText phoneNumberText = FindViewById<EditText>( Resource.Id.PhoneNumberText );
            TextView translatedPhoneWord = FindViewById<TextView>( Resource.Id.TranslatedPhoneword );
            Button translateButton = FindViewById<Button>( Resource.Id.TranslateButton );
            Button translationHistoryButton = FindViewById<Button>( Resource.Id.TranslationHistoryButton );


            translateButton.Click += (sender, e) =>
            {
                string translatedNumber = Core.PhonewordTranslator.ToNumber( phoneNumberText.Text );

                if ( string.IsNullOrWhiteSpace( translatedNumber ) )
                {
                    translatedPhoneWord.Text = string.Empty;
                }
                else
                {
                    translatedPhoneWord.Text = translatedNumber;
                    phoneNumbers.Add( translatedNumber );
                    translationHistoryButton.Enabled = true;
                }
            };

            translationHistoryButton.Click += (sender, e) =>
            {
                var intent = new Intent( this, typeof( TranslationHistoryActivity ) );
                intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
                StartActivity(intent);
            };
        }
    }
}