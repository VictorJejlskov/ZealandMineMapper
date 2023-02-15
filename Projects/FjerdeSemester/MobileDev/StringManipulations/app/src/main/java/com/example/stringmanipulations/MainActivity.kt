package com.example.stringmanipulations

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import com.example.stringmanipulations.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        val view: View = binding.root
        setContentView(view)

        binding.buttonCapitalize.setOnClickListener {
            val input = binding.editTextInputText.text
            if(input.isEmpty()){
                binding.editTextInputText.error = "Cannot be empty"
                return@setOnClickListener
            }
            binding.textViewResult.text = input
                .split(' ')
                .joinToString(" ") { it.replaceFirstChar(Char::uppercaseChar) }
        }

        binding.buttonLowerCase.setOnClickListener {
            val input = binding.editTextInputText.text
            if(input.isEmpty()){
                binding.editTextInputText.error = "Cannot be empty"
                return@setOnClickListener
            }
            binding.textViewResult.text = input
                .split(' ')
                .joinToString(" ") { it.lowercase() }
        }
        binding.buttonUpperCase.setOnClickListener {
            val input = binding.editTextInputText.text
            if(input.isEmpty()){
                binding.editTextInputText.error = "Cannot be empty"
                return@setOnClickListener
            }
            binding.textViewResult.text = input
                .split(' ')
                .joinToString(" ") { it.uppercase() }
        }
        binding.buttonReverse.setOnClickListener {
            val input = binding.editTextInputText.text
            if(input.isEmpty()){
                binding.editTextInputText.error = "Cannot be empty"
                return@setOnClickListener
            }
            binding.textViewResult.text = input
                .split(' ')
                .joinToString(" ") { it.reversed() }
        }
    }
}