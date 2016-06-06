package com.example.drnegativeslaptop.myfirstapp;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.RelativeLayout;
import android.widget.TextView;

public class DisplayMessageActivity extends AppCompatActivity {



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_display_message);

        //EVERY Activity is invoked by an Intent, REGARDLESS of how user navigated there
        //get Intent that started it by calling getIntent()

        Intent intent = getIntent();
        String message = intent.getStringExtra(MyActivity.EXTRA_MESSAGE);

        //make a new text view with the message that we recieved from intent
        TextView textView = new TextView(this);
        textView.setTextSize(40);
        textView.setText(message);

        //add the textview to the relative layout
        RelativeLayout layout = (RelativeLayout) findViewById(R.id.content);
        layout.addView(textView);
    }


}
