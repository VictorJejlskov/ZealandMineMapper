package com.example.collectwords

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import com.example.collectwords.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        val view: View = binding.root
        setContentView(view)

        val words = ArrayList<String>()
        binding.buttonSave.setOnClickListener {
            val input = binding.editTextInput.text
            if(input.isEmpty()){
                binding.editTextInput.error = "No name written!"
                return@setOnClickListener
            }
            words.add(input.toString())
        }
        binding.buttonShow.setOnClickListener {
            val input = binding.editTextInput.text
            if(input.isEmpty()){
                binding.editTextInput.error = "No name written!"
                return@setOnClickListener
            }
            binding.textViewOutput.text = words.toString()
        }
        binding.buttonClear.setOnClickListener {
            val input = binding.editTextInput.text
            if(input.isEmpty()){
                binding.editTextInput.error = "No name written!"
                return@setOnClickListener
            }
            binding.textViewOutput.text = ""
            words.clear()
        }
    }
}