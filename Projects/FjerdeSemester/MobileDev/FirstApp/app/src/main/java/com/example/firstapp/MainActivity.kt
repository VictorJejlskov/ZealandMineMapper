package com.example.firstapp

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import com.example.firstapp.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        val view: View = binding.root
        setContentView(view)

        binding.buttonSubmit.setOnClickListener {
            val name = binding.editTextName.text
            if(name.isEmpty()){
                binding.editTextName.error = "No name written!"
                return@setOnClickListener
            }
            binding.textViewMessage.text = "Hello: " + name
        }
    }
}