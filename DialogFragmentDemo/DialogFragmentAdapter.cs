using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DialogFragmentDemo
{
    public class DialogFragmentAdapter : DialogFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            Dialog.Window.RequestFeature(WindowFeatures.NoTitle);

            var view = inflater.Inflate(Resource.Layout.DialogFragmentContent, container, false);

            Button closeButton = view.FindViewById<Button>(Resource.Id.CloseButton);
            closeButton.Click += delegate {
                Dismiss();
            };

            return view;
        }
       

    }
}

