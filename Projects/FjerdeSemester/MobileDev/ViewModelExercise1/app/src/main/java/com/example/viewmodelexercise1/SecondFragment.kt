package com.example.viewmodelexercise1

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.activityViewModels
import androidx.navigation.fragment.findNavController
import com.example.viewmodelexercise1.databinding.FragmentSecondBinding

/**
 * A simple [Fragment] subclass as the second destination in the navigation.
 */
class SecondFragment : Fragment() {

    private var _binding: FragmentSecondBinding? = null

    // This property is only valid between onCreateView and
    // onDestroyView.
    private val binding get() = _binding!!
    private val viewModel: PersonViewModel by activityViewModels()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {

        _binding = FragmentSecondBinding.inflate(inflater, container, false)
        return binding.root

    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        viewModel.person.observe(viewLifecycleOwner) { person ->
            updateNameAndAge(person.name, person.age)
            updateSkillAndTotal(person.favouriteSkill, person.totalLevel)
        }


        binding.buttonSecond.setOnClickListener {
            findNavController().navigate(R.id.action_SecondFragment_to_FirstFragment)
        }
    }

    private fun updateNameAndAge(name: String? = "", age: Int? = 0) {
        var stringArray = binding.textviewNameAndAge.text.toString().split(" - ")
        var nameValue = stringArray[0]
        var ageValue = stringArray[1]
        if (!name.isNullOrEmpty()){
            nameValue = name
        }
        if (age != 0) {
            ageValue = age.toString()
        }
        binding.textviewNameAndAge.text = "$nameValue - $ageValue"
    }
    private fun updateSkillAndTotal(skill: String? = "", total: Int? = 0) {
        var stringArray = binding.textviewSkillAndTotal.text.toString().split(" - ")
        var skillValue = stringArray[0]
        var totalValue = stringArray[1]
        if (!skill.isNullOrEmpty()){
            skillValue = skill
        }
        if (total != 0) {
             totalValue = total.toString()
        }
        binding.textviewSkillAndTotal.text = "$skillValue - $totalValue"
    }

    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }
}