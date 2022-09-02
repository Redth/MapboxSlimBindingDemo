package com.microsoft.maui.mapboxinteroplib;

import android.content.Context;
import android.view.View;

import com.mapbox.maps.MapInitOptions;
import com.mapbox.maps.MapView;
import com.mapbox.maps.MapboxMap;

public class MapboxInterop {

    private MapView mapView;
    private MapboxMap map;

    public MapboxInterop(Context context) {


        mapView = new MapView(context);

        map = mapView.getMapboxMap();
    }

    public View getMapView() {
        return mapView;
    }
}
