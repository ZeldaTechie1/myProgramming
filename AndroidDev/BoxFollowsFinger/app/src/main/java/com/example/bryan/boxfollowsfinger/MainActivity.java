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
import android.widget.ImageView;
import android.widget.TextView;

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

    //quick side note that you can also use onTouch, but you need to iplement an onTouch Listener that didnt work for me the first time
    @Override
    public boolean onTouchEvent(MotionEvent event){
        this.mDetector.onTouchEvent(event);

        //When one finger on screen, track its location visually (yes this will only track the movement on the first finger that touches the screen)
        //TODO perhaps add something where it place priority on the finger with most presure
        TextView xTextBox = (TextView)findViewById(R.id.xPos);
        TextView yTextBox = (TextView)findViewById(R.id.yPos);

        TextView xBoxBox = (TextView)findViewById(R.id.xPosBox);
        TextView yBoxBox = (TextView)findViewById(R.id.yPosBox);

        ImageView imgThing = (ImageView) findViewById(R.id.menuBtn);

        xTextBox.setText("X: "+Integer.toString((int)event.getX()));
        yTextBox.setText("Y: "+Integer.toString((int)event.getY()));

        xBoxBox.setText("X: "+Integer.toString((int)imgThing.getX()));
        yBoxBox.setText("Y: "+Integer.toString((int)imgThing.getY()));

        //TODO only follow finger when long press
        //TODO get rid of margins or whatever is stoping the box from following the center of my finger
        //menubutton follows my finger
        imgThing.setX(event.getX() - (imgThing.getWidth()/2));
        imgThing.setY(event.getY() - imgThing.getHeight() );

        // Be sure to call the superclass implementation
        return super.onTouchEvent(event);
    }


    //simpleOnGestureListener only worries about the gestures you care about and automatically returns false for the rest for speed
    class MyGestureListener extends GestureDetector.SimpleOnGestureListener{
        //FOR DEBUGGING PURPOSES ONLY
        private static final String DEBUG_TAG = "MyActivity";

        @Override
        public boolean onDown(MotionEvent event) {
            Log.d(DEBUG_TAG,"onDown: " + event.toString());
            TextView txtV = (TextView)findViewById(R.id.infoBox);
            txtV.setText("onDown");
            return true;
        }

        @Override
        public void onLongPress(MotionEvent event) {
            Log.d(DEBUG_TAG, "onLongPress: " + event.toString());
            TextView txtV = (TextView)findViewById(R.id.infoBox);
            txtV.setText("onLongPress");
        }

        @Override
        public void onShowPress(MotionEvent event) {
            Log.d(DEBUG_TAG, "onShowPress: " + event.toString());
            TextView txtV = (TextView)findViewById(R.id.infoBox);
            txtV.setText("onShowPress");
        }

    }

}
