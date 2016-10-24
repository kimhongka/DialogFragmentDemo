using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DialogFragmentDemo
{
    [Activity(Label = "DialogFragmentDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button popupDialogButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Main);
            popupDialogButton = FindViewById<Button>(Resource.Id.Dialog_Button);
            popupDialogButton.Click += OnPopupWinowButtonClicked;
        }

        private void OnPopupWinowButtonClicked(object sender, EventArgs e)
        {
            popupDialogButton.Enabled = false;

            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            DialogFragmentAdapter dialogFragmentAdapter = new DialogFragmentAdapter();
            dialogFragmentAdapter.Show(transaction, "testTag");
            popupDialogButton.Enabled = true;
        }
    }
}

