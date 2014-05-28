package projet.rentcarappli.app;

import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;

import com.loopj.android.http.JsonHttpResponseHandler;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;


public class RentCarAppliMainActivity extends ActionBarActivity {

    private Button b = null;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_rent_car_appli_main);

        b = (Button) findViewById(R.id.button);

        b.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                try {
                    getVoiture();
                } catch (JSONException e) {
                    e.printStackTrace();
                }

            }
        });
    }

    public void getVoiture() throws JSONException {
        RentCarHttpClient.get("connexion_mysql.php", null, new JsonHttpResponseHandler() {

            @Override
            public void onStart(){

            }
            @Override
            public void onSuccess(JSONArray voitures) {
                // Pull out the first event on the public timeline

                JSONObject firstCar = null;
                try {
                    firstCar = (JSONObject)voitures.get(0);
                } catch (JSONException e) {
                    e.printStackTrace();
                }
                String voitureText = null;
                try {
                    voitureText = firstCar.getString("Voiture");
                } catch (JSONException e) {
                    e.printStackTrace();
                }

                // Do something with the response
                System.out.println(voitureText);
            }
            @Override
            public void onFailure(java.lang.Throwable e, org.json.JSONObject errorResponse) {
                System.out.println("test");
            }
        });
    }



    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.rent_car_appli_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        if (id == R.id.action_settings) {
            return true;
        }
        return super.onOptionsItemSelected(item);
    }
}
