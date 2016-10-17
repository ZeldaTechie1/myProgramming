package com.example.bryan.boxfollowsfinger;

import android.app.Activity;
import android.content.Context;
import android.net.Uri;
import android.support.v4.view.GestureDetectorCompat;
import android.support.v4.view.MotionEventCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.GestureDetector;
import android.view.MotionEvent;
import android.view.ScaleGestureDetector;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.gms.appindexing.Action;
import com.google.android.gms.appindexing.AppIndex;
import com.google.android.gms.common.api.GoogleApiClient;

import org.w3c.dom.Text;

public class MainActivity extends Activity
{

    //required for Activities
    //although I can also use others dependant on that activities state (onResume, onStop)
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);

        //NOTE: there is a root view attached to the window, in this case I beleive its the relativeLayoutView

        //NOTE: you can use getLeft and getTop to get the coordinate of a view RELATIVE to its parent view

        //TODO investigate a bit more on the decoView
        /*The Event Handling Pipeline looks a littleBit like this
        1. Window (input manager service interact with window)
        2. Activity
        2. DecoView
         */

        //TODO find out what the status bar and navigation bar look like and why I don't have them
        /*inside of the DECO VIEW you find 3 things (from top to bottom)
        1. status bar
        2. content view
        3. navigation bar
        */

        setContentView(R.layout.activity_main); //R.layout.activity_main

        //all the things Im referencing
        View myRelView = (View) findViewById(R.id.relativeLayoutView);
        final ImageButton imgThing = (ImageButton) findViewById(R.id.menuBtn);

        //NOTE: I can implement all my onclick and what not here but I want to try gesture detectors
    }


    //this is the first thing to be called
    @Override
    public boolean dispatchTouchEvent(MotionEvent ev) {

        //TODO figure out why i can use MotionEventCompat to make this work
        final int action = ev.getAction();

        //TODO stop this wonky way of doing things, I should only pass down the event to a child if a child is clicked, no if any part of the screen is touched
        //if screen is touch go to the onTouchEvent
        if(action==MotionEvent.ACTION_DOWN)
            onTouchEvent(ev);

        return super.dispatchTouchEvent(ev);   //this is done because of how the framework was designed to function
        //FRAMEWORK designed to function by processing dispatchTouchEvent from parent to lowest children and then TouchEvent from lowestest child to parent
    }

    boolean draggingActive = false;//this needs to be initialized here or you have to strange error with it needing to be final

    //NOTE: the Activities onTouchEvent (below) Should ONLY be called if no views consume the event



    //DONT FORGET that the events each call creates are different, very different!
    //TODO figure out if I can make an onTouch Event Specific to an object or if an ontouchevent is actually what is called when the BIG parent (relativeLayoutView) view is called
    //TODO figure out why I need this and I cant just ontouchlistener of an item straight up


    @Override
    public boolean onTouchEvent(final MotionEvent eventForOnTouchEvent){

        draggingActive = false; //required or it wont reset the variable

        final ImageButton imgThing = (ImageButton) findViewById(R.id.menuBtn);

        //Toast Indicators - for debug purposes
        Context context = getApplicationContext(); //TODO figure out what this context does
        final int duration = Toast.LENGTH_SHORT;
        CharSequence textOnLong = "dragging time";
        CharSequence textOnShort = "menu time";
        CharSequence textOnLongStop = "dragging OVER";
        final Toast toastLong = Toast.makeText(context, textOnLong, duration);
        final Toast toastShort = Toast.makeText(context, textOnShort, duration);
        final Toast toastStop = Toast.makeText(context, textOnLongStop, duration);

        //TODO stop if from jumping from finger to finger by paying attention to the ID (once the finger that started the drag event leaves the screen the drag event is over)

        final MotionEvent eventFromOnTouchEvent = eventForOnTouchEvent;

        imgThing.setOnTouchListener(new View.OnTouchListener() {

            @Override
            public boolean onTouch(View v, MotionEvent ev) {

                final int action = eventFromOnTouchEvent.getAction();

                //onLongClick the box should follow my finger
                imgThing.setOnLongClickListener(new View.OnLongClickListener() {
                    @Override
                    public boolean onLongClick(View v) {

                        draggingActive = true;

                        toastLong.show();//for debugging purposes

                        //TODO set the ACTIVE pointer ID

                        return false;
                    }
                });

                //stops draggin if our pointer goes up
                //TODO use our pointer ID
                if(action == eventFromOnTouchEvent.ACTION_UP && draggingActive) //TODO add "AND" our main pointer is the one that was raised...
                {
                    draggingActive = false;
                    toastStop.show();
                }

                //TODO use pointer ID BECAUSE NOT SUPER SURE if primary finger is in position 0 on array all the time
                if(draggingActive)
                {
                    imgThing.setX(eventFromOnTouchEvent.getX(0) - (imgThing.getWidth() / 2));
                    imgThing.setY(eventFromOnTouchEvent.getY(0) - (imgThing.getHeight() / 2));
                }

                //onClick the box should open a menu
                imgThing.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {

                        if(draggingActive)
                        {
                            draggingActive = false;
                            toastStop.show();
                        }
                        else
                        {
                            toastShort.show();//for debugging purposes
                        }

                    }
                });

                return false; //TODO find out if this matters
            }
        });



        return false; //TODO find out if this matters

    }








    //---------NOTES

    //TODO Read up on "Best Practices for User Input" -> "Touch Gestures"
    //NOTE ON DETECTING COMMON GESTURES
    //when screen touch, onTouchEvent() is fired on the view that receive the touches
    //for each seq of touch events (pressure, size, position, etc), onTouchEvent() is fired several times
    //the motionEvent() delivered to onTouchEvent() provides the details of every interaction
    //you can use the motionEvent() data to determine if you care about a gesture made
    //LEFT OFF at "Capturing touch events for a single view"


    //ANY VIEWS dispatchTouchEvent sends the event to listener first IF IT EXISTS, if not then goes to that views onTouch

    //RETURNING true from an onTouchEvent means that you processed the event there, false means that you didnt

    //ONLY a view group has the onInterceptTouchEvent()

    /*
    THE ORDER IN WHICH TOUCHES ARE PROCESSED

    Activity.dispatchTouchEvent()
    ViewGroup.dispatchTouchEvent()
    View.dispatchTouchEvent()
    View.onTouchEvent()
    ViewGroup.onTouchEvent()
    Activity.onTouchEvent()
     */

    //----------UNFINISHED PARTS

    // The ‘active pointer’ is the one currently moving our object.
    private static final int INVALID_POINTER_ID = -1;
    private int mActivePointerId = INVALID_POINTER_ID;

    //Detect your primary finger and only let you move the menu with your primary finger----------

    //get action masked is designed to work with multiple pointers, it return the action being performed without including the pointer index bits
    //BUT for some reason it makes the variable i set to seperate the menu action from the drag action... idk why
    //final int action = MotionEventCompat.getActionMasked(event);

    /*
    //used to update the active finger, so that the finger that starts dragging is the only one that will drag the object, that way the object wont jump between fingers
    switch (action){

        //if your first finger goes down on the screen mark that fingers id as the one your will follow
        case MotionEvent.ACTION_DOWN:
            mActivePointerId = event.getPointerId(0);
            Log.d("in switch", "Main Finger PRESENT");
            break;

        //if you remove another finger DO NOTHING
        case MotionEvent.ACTION_POINTER_DOWN:
            //TODO figure out why fingers are not being detected here
            Log.d("in switch", "ANOTHER Finger PRESENT");
            break;

        //if you remove your ACTIVE finger then WAIT until all finger are removed to set the active pointer again
        case MotionEvent.ACTION_UP:
        case MotionEvent.ACTION_POINTER_UP:
            Log.d("in switch","a finger was REMOVED");

            if(event.getPointerCount()!=0)
            {
                int checkIndex;
                //this loops through all existing pointers
                for(checkIndex = 0; checkIndex< event.getPointerCount(); checkIndex++)
                {

                }
            }
            else
                Log.d("in switch","LAST Finger REMOVED");

            break;
    }
    */

    //Dont make the user have to press that outer area to interact with the button----------

    /*
    //a class for the relative layout inside that activity
    public class fullScreen extends RelativeLayout{

        //constructor
        public fullScreen(Context context) {
            super(context);
        }

        //used to receive all motion events on the screen
        @Override
        public boolean onInterceptTouchEvent(MotionEvent ev) {

            Log.v("Intercept", "the screen has been touched");

            return true; //BIG DIFFERENCE WHEN TRUE AND FALSE
        }
    }
    */

}
