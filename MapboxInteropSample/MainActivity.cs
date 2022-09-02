using Android.Views;

namespace MapboxInteropSample;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    global::Com.Microsoft.Maui.Mapboxinteroplib.MapboxInterop mapbox;
    View mapView;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);

        mapbox = new global::Com.Microsoft.Maui.Mapboxinteroplib.MapboxInterop(this);

        mapView = mapbox.MapView;

    }
}