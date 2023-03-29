package com.example.mandatoryassignment

import android.os.Bundle
import android.text.InputType
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
import androidx.appcompat.app.AlertDialog
import com.example.mandatoryassignment.databinding.ActivityMainBinding
import com.example.mandatoryassignment.models.Item
import com.example.mandatoryassignment.models.ItemsViewModel

class MainActivity : AppCompatActivity() {

    private lateinit var appBarConfiguration: AppBarConfiguration
    private lateinit var binding: ActivityMainBinding
    private var _itemsViewModel = ItemsViewModel()

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

    private fun showDialog() {
        val builder: AlertDialog.Builder = AlertDialog.Builder(this)
        builder.setTitle("Add Book")

        val layout = LinearLayout(this@MainActivity)
        layout.orientation = LinearLayout.VERTICAL

        val titleInputField = EditText(this)
        titleInputField.hint = "Description"
        titleInputField.inputType = InputType.TYPE_CLASS_TEXT
        layout.addView(titleInputField)

        val bodyInputField = EditText(this)
        bodyInputField.hint = "Price"
        bodyInputField.inputType =
            InputType.TYPE_CLASS_NUMBER or InputType.TYPE_NUMBER_FLAG_DECIMAL
        layout.addView(bodyInputField)

        builder.setView(layout)

        builder.setPositiveButton("OK") { dialog, which ->
            val description = titleInputField.text.toString().trim()
            val priceStr = bodyInputField.text.toString().trim()
            when {
                title.isEmpty() ->
                    //inputField.error = "No word"
                    Snackbar.make(binding.root, "No title", Snackbar.LENGTH_LONG).show()
                title.isEmpty() -> Snackbar.make(binding.root, "No title", Snackbar.LENGTH_LONG)
                    .show()
                priceStr.isEmpty() -> Snackbar.make(
                    binding.root,
                    "No price",
                    Snackbar.LENGTH_LONG
                )
                    .show()
                else -> {
                    val item = Item(description, 0, "", priceStr.toInt(), "", "", 0)
                    _itemsViewModel.add(item)
                }
            }
        }
        builder.setNegativeButton("Cancel") { dialog, which -> dialog.cancel() }
        builder.show()
    }
}