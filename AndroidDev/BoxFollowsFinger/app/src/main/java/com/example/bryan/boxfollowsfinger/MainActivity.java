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
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.gms.appindexing.Action;
import com.google.android.gms.appindexing.AppIndex;
import com.google.android.gms.common.api.GoogleApiClient;

import org.w3c.dom.Text;

//i used to extend appcomapactivity and that added the action bar, it seems that the notification bar also adds some slight skew to the position of the bar

public class MainActivity extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    }

    //TODO Read up on "Best Practices for User Input" -> "Touch Gestures"
    //NOTE ON DETECTING COMMON GESTURES
    //when screen touch, onTouchEvent() is fired on the view that receive the touches
    //for each seq of touch events (pressure, size, position, etc), onTouchEvent() is fired several times
    //the motionEvent() delivered to onTouchEvent() provides the details of every interaction
    //you can use the motionEvent() data to determine if you care about a gesture made
    //LEFT OFF at "Capturing touch events for a single view"

    // The ‘active pointer’ is the one currently moving our object.
    private static final int INVALID_POINTER_ID = -1;
    private int mActivePointerId = INVALID_POINTER_ID;

    boolean draggingActive = false;

    //quick side note that you can also use onTouch, but you need to implement an onTouch Listener and that didnt work for me the first time
    @Override
    public boolean onTouchEvent(MotionEvent event){

        Log.v("onTouch: ", "you have triggered an ontouchevent"); //TODO figure out why this isnt being triggered if i straight up touch the button and idk why

        //the objects Im messing with inside of the functions
        final ImageButton imgThing = (ImageButton) findViewById(R.id.menuBtn);

        //Toast Indicators
        Context context = getApplicationContext(); //TODO figure out what this context does
        final int duration = Toast.LENGTH_SHORT;
        CharSequence textOnLong = "dragging time";
        CharSequence textOnShort = "menu time";
        CharSequence textCreepy = "dragging OVER";

        final Toast toastLong = Toast.makeText(context, textOnLong, duration);
        final Toast toastShort = Toast.makeText(context, textOnShort, duration);
        final Toast toastCreepy = Toast.makeText(context, textCreepy, duration);

        //TODO stop if from jumping from finger to finger by paying attention to the ID (once the finger that started the drag event leaves the screen the drag event is over)
        //TODO stop the requirement that it has for your to click the main view before you start messing with the button

        final MotionEvent evForDragging = event;

        imgThing.setOnTouchListener(new View.OnTouchListener() {

            @Override
            public boolean onTouch(View v, MotionEvent event) {

                final int action = evForDragging.getAction();


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
                if(action == evForDragging.ACTION_UP && draggingActive)
                {
                    draggingActive = false;
                    toastCreepy.show();
                }

                //TODO use pointer ID
                if(draggingActive)
                {
                    imgThing.setX(evForDragging.getX(0) - (imgThing.getWidth() / 2));
                    imgThing.setY(evForDragging.getY(0) - (imgThing.getHeight() / 2));
                }

                //onClick the box should open a menu
                imgThing.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {

                        if(draggingActive)
                        {
                            draggingActive = false;
                            toastCreepy.show();
                        }
                        else
                        {
                            toastShort.show();//for debugging purposes

                        }

                    }
                });

                return false;
            }
        });

        return true;

    }


}
