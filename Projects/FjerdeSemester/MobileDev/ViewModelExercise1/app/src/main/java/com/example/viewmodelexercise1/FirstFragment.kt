package com.example.viewmodelexercise1

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.activityViewModels
import androidx.lifecycle.ViewModel
import androidx.navigation.fragment.findNavController
import com.example.viewmodelexercise1.databinding.FragmentFirstBinding
import com.example.viewmodelexercise1.models.Person

/**
 * A simple [Fragment] subclass as the default destination in the navigation.
 */
class FirstFragment : Fragment() {

    private var _binding: FragmentFirstBinding? = null

    // This property is only valid between onCreateView and
    // onDestroyView.
    private val binding get() = _binding!!
    private val viewModel: PersonViewModel by activityViewModels()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {

        _binding = FragmentFirstBinding.inflate(inflater, container, false)
        return binding.root

    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        binding.buttonFirst.setOnClickListener {
            saveData()
            findNavController().navigate(R.id.action_FirstFragment_to_SecondFragment)
        }
    }
    fun saveData(){
        val name = binding.edittextName.text.trim().toString()
        val age = binding.edittextAge.text.trim().toString().toInt()
        val favouriteSkill = binding.edittextFavouriteSkill.text.trim().toString()
        val totalLevel = binding.edittextTotalLevel.text.trim().toString().toInt()
        var person: Person = Person("", 0, "", 0)
        person.name = name
        person.age = age
        person.favouriteSkill = favouriteSkill
        person.totalLevel = totalLevel
        viewModel.person.value = person

    }

    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }
}