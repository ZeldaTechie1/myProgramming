package com.example.bryan.boxfollowsfinger;

import android.support.v4.view.MotionEventCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    //TODO Read up on "Best Practices for User Input" -> "Touch Gestures"
    //NOTE ON DETECTING COMMONG GESTURES
    //when screen touch, onTouchEvent() is fired on the view that receive the touches
    //for each seq of touch events (pressure, size, position, etc), onTouchEvent() is fired several times
    //the motionEvent() delivered to onTouchEvent() provides the details of every interaction
    //you can use the motionEvent() data to determine if you care about a gesture made
    //LEFT OFF at "Capturing touch events for a single view"

    @Override
    public boolean onTouchEvent(MotionEvent event)
    {
        //uses getActionMasked to extract the action the user performed from the event parameter [this gives you raw data to determine if gesture]
        //used to detect custom gestures
        int action = MotionEventCompat.getActionMasked(event);

        //TODO figure out where to make this DEBUG_TAGE thing
        switch(action) {
            case (MotionEvent.ACTION_DOWN) :
                Log.d(DEBUG_TAG,"Action was DOWN");
                return true;
            case (MotionEvent.ACTION_MOVE) :
                Log.d(DEBUG_TAG,"Action was MOVE");
                return true;
            case (MotionEvent.ACTION_UP) :
                Log.d(DEBUG_TAG,"Action was UP");
                return true;
            case (MotionEvent.ACTION_CANCEL) :
                Log.d(DEBUG_TAG,"Action was CANCEL");
                return true;
            case (MotionEvent.ACTION_OUTSIDE) :
                Log.d(DEBUG_TAG,"Movement occurred outside bounds " +
                        "of current screen element");
                return true;
            default :
                return super.onTouchEvent(event);

        //NOTE: if you use commong gestures take advantage of the GestureDetector class
    }
    //TODO if more than one finger is touching the screen ask user to only use one (PASSIVELY)
    //TODO when one finger on screen, track its location visually
}
