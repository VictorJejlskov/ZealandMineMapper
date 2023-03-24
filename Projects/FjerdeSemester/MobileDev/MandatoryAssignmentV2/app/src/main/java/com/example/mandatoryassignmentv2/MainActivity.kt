package com.example.mandatoryassignmentv2

import android.os.Build
import android.os.Bundle
import android.text.InputType
import android.util.Log
import com.google.android.material.snackbar.Snackbar
import androidx.appcompat.app.AppCompatActivity
import androidx.navigation.findNavController
import androidx.navigation.ui.AppBarConfiguration
import androidx.navigation.ui.navigateUp
import androidx.navigation.ui.setupActionBarWithNavController
import android.view.Menu
import android.view.MenuItem
import android.widget.EditText
import android.widget.LinearLayout
import androidx.annotation.RequiresApi
import androidx.appcompat.app.AlertDialog
import com.example.mandatoryassignmentv2.databinding.ActivityMainBinding
import com.example.mandatoryassignmentv2.models.SalesItem
import com.example.mandatoryassignmentv2.models.SalesItemViewModel
import com.google.firebase.auth.FirebaseAuth
import java.time.LocalDateTime

class MainActivity : AppCompatActivity() {

    private lateinit var appBarConfiguration: AppBarConfiguration
    private lateinit var binding: ActivityMainBinding
    private var _salesItemViewModel = SalesItemViewModel()
    private var auth: FirebaseAuth = FirebaseAuth.getInstance()

    @RequiresApi(Build.VERSION_CODES.O)
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        setSupportActionBar(binding.toolbar)

        val navController = findNavController(R.id.nav_host_fragment_content_main)
        appBarConfiguration = AppBarConfiguration(navController.graph)
        setupActionBarWithNavController(navController, appBarConfiguration)

        binding.fab.setOnClickListener { view ->
            showDialog()
        }
    }

    override fun onCreateOptionsMenu(menu: Menu): Boolean {
        // Inflate the menu; this adds items to the action bar if it is present.
        menuInflater.inflate(R.menu.menu_main, menu)
        return true
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        return when (item.itemId) {
            R.id.action_settings -> true
            else -> super.onOptionsItemSelected(item)
        }
    }

    override fun onSupportNavigateUp(): Boolean {
        val navController = findNavController(R.id.nav_host_fragment_content_main)
        return navController.navigateUp(appBarConfiguration)
                || super.onSupportNavigateUp()
    }
    @RequiresApi(Build.VERSION_CODES.O)
    private fun showDialog(){
        val user = auth.currentUser
        if(user === null) return
        val builder: AlertDialog.Builder = AlertDialog.Builder(this)
        builder.setTitle("Add Item")

        val layout = LinearLayout(this@MainActivity)
        layout.orientation = LinearLayout.VERTICAL

        val descriptionInputField = EditText(this)
        descriptionInputField.hint = "Description"
        descriptionInputField.inputType = InputType.TYPE_CLASS_TEXT
        layout.addView(descriptionInputField)

        val priceInputField = EditText(this)
        priceInputField.hint = "Price"
        priceInputField.inputType = InputType.TYPE_CLASS_NUMBER or InputType.TYPE_NUMBER_FLAG_DECIMAL
        layout.addView(priceInputField)

        val phoneInputField = EditText(this)
        phoneInputField.hint = "Phone"
        phoneInputField.inputType = InputType.TYPE_CLASS_TEXT
        layout.addView(phoneInputField)

        val pictureInputField = EditText(this)
        pictureInputField.hint = "PictureURL"
        pictureInputField.inputType = InputType.TYPE_CLASS_TEXT
        layout.addView(pictureInputField)



        builder.setView(layout)

        builder.setPositiveButton("OK") { dialog, which ->
            val description = descriptionInputField.text.toString().trim()
            val priceStr = priceInputField.text.toString().trim()
            val pictureStr = pictureInputField.text.toString().trim()
            val phoneStr = phoneInputField.text.toString().trim()

            when {
                description.isEmpty() ->
                    Snackbar.make(binding.root, "No Title", Snackbar.LENGTH_LONG).show()
                priceStr.isEmpty() ->
                    Snackbar.make(binding.root, "No Price", Snackbar.LENGTH_LONG).show()
                phoneStr.isEmpty() ->
                    Snackbar.make(binding.root, "No Phone", Snackbar.LENGTH_LONG).show()
                else -> {
                    val newItem = SalesItem(0, description, pictureStr, priceStr.toInt(), user.email.toString(), phoneStr, (System.currentTimeMillis()/1000).toInt())
                    Log.d("New ITEM", newItem.toString())
                    _salesItemViewModel.add(newItem)
                }
            }
        }
        builder.setCancelable(false);
        builder.setNegativeButton("Cancel"){dialog, which -> dialog.cancel()}
        builder.show()
    }
}