package com.example.bryan.boxfollowsfinger;

import android.net.Uri;
import android.support.v4.view.GestureDetectorCompat;
import android.support.v4.view.MotionEventCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.GestureDetector;
import android.view.MotionEvent;
import android.view.View;

import com.google.android.gms.appindexing.Action;
import com.google.android.gms.appindexing.AppIndex;
import com.google.android.gms.common.api.GoogleApiClient;

import org.w3c.dom.Text;

public class MainActivity extends AppCompatActivity{
    //for the above always implement a onDown that return true because every other call of a gesture starts with ondown()

    private GestureDetectorCompat mDetector;

    /**
     * ATTENTION: This was auto-generated to implement the App Indexing API.
     * See https://g.co/AppIndexing/AndroidStudio for more information.
     */

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //new gesture detector for this activity, using our mygesturelistener class created below
        mDetector = new GestureDetectorCompat(this, new MyGestureListener());

    }

    //TODO Read up on "Best Practices for User Input" -> "Touch Gestures"
    //NOTE ON DETECTING COMMON GESTURES
    //when screen touch, onTouchEvent() is fired on the view that receive the touches
    //for each seq of touch events (pressure, size, position, etc), onTouchEvent() is fired several times
    //the motionEvent() delivered to onTouchEvent() provides the details of every interaction
    //you can use the motionEvent() data to determine if you care about a gesture made
    //LEFT OFF at "Capturing touch events for a single view"

    //TODO learn how to use an OnTouchEvent but only on a specific thing with an id to conserve power - does it really conserve power...?

    @Override
    public boolean onTouchEvent(MotionEvent event){
        this.mDetector.onTouchEvent(event);
        // Be sure to call the superclass implementation
        return super.onTouchEvent(event);
    }

    //TODO read more up on the GestureDetector Class, learn to use presets and to retreive custom info from it

    //simpleOnGestureListener only worries about the gestures you care about and automatically returns false for the rest for speed
    class MyGestureListener extends GestureDetector.SimpleOnGestureListener{
        //FOR DEBUGGING PURPOSES ONLY
        private static final String DEBUG_TAG = "MyActivity";

        @Override
        public boolean onDown(MotionEvent event) {
            Log.d(DEBUG_TAG,"onDown: " + event.toString());
            return true;
        }

        @Override
        public void onLongPress(MotionEvent event) {
            Log.d(DEBUG_TAG, "onLongPress: " + event.toString());
        }

        @Override
        public void onShowPress(MotionEvent event) {
            Log.d(DEBUG_TAG, "onShowPress: " + event.toString());
        }
    }



    //instead of using the onTouchEvent you can attach an View.OnListner obj to any View Obj using the setOnTouchListener() - DIDNT WORK FOR ME... :(



    //TODO if more than one finger is touching the screen ask user to only use one (PASSIVELY)
    //TODO when one finger on screen, track its location visually
}
