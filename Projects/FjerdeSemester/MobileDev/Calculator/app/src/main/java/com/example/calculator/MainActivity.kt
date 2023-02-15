package com.example.calculator

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.view.View
import android.widget.ArrayAdapter
import android.widget.RadioButton
import android.widget.Spinner
import com.example.calculator.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        val view: View = binding.root
        setContentView(view)

        fun calculate() {
            val inputOne = binding.editTextInputOne.text
            val inputTwo = binding.editTextInputTwo.text
            if(inputOne.toString() == "." || inputOne.toString() == "-" || inputOne.isEmpty()) {
                binding.editTextInputOne.error = "A number is required"
                return
            }
            if(inputTwo.toString() == "." || inputTwo.toString() == "-" || inputTwo.isEmpty()) {
                binding.editTextInputTwo.error = "A number is required"
                return
            }
            val selectedRadio = binding.operatorsGroup.checkedRadioButtonId
            val operationValue = binding.operatorsGroup.findViewById<RadioButton>(selectedRadio).text.toString()
            when(operationValue){
                "plus" -> binding.textViewResult.text = (inputOne.toString().toBigDecimal() + inputTwo.toString().toBigDecimal()).toString()
                "minus" -> binding.textViewResult.text = (inputOne.toString().toBigDecimal() - inputTwo.toString().toBigDecimal()).toString()
                "divide" -> binding.textViewResult.text = (inputOne.toString().toBigDecimal() / inputTwo.toString().toBigDecimal()).toString()
                "multiply" -> binding.textViewResult.text = (inputOne.toString().toBigDecimal() * inputTwo.toString().toBigDecimal()).toString()
            }

        }

        binding.editTextInputTwo.setOnKeyListener { view, i, keyEvent ->
            calculate()
            false
        }
        binding.operatorsGroup.setOnCheckedChangeListener() { view, isChecked ->
            calculate()
            false
        }

    }
}