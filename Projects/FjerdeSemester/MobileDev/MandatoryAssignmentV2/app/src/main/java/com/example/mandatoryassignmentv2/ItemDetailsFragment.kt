package com.example.mandatoryassignmentv2

import android.os.Bundle
import android.util.Log
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.activityViewModels
import androidx.navigation.fragment.findNavController
import com.example.mandatoryassignmentv2.databinding.FragmentItemDetailsBinding
import com.example.mandatoryassignmentv2.models.SalesItem
import com.example.mandatoryassignmentv2.models.SalesItemViewModel
import java.text.SimpleDateFormat
import java.time.Instant
import java.util.Date

class ItemDetailsFragment : Fragment() {
    private var _binding: FragmentItemDetailsBinding? = null
    private val binding get() = _binding!!
    private val viewModel: SalesItemViewModel by activityViewModels()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        _binding = FragmentItemDetailsBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        val bundle = requireArguments()
        val itemDetailFragmentArgs: ItemDetailsFragmentArgs = ItemDetailsFragmentArgs.fromBundle(bundle)
        val position = itemDetailFragmentArgs.position
        val salesItem = viewModel[position]
        if (salesItem == null) {
            binding.textviewMessage.text = "No such book!"
            return
        }
        binding.editTextTitle.setText(salesItem.description)
        binding.editTextPrice.setText(salesItem.price.toString())
        binding.editTextEmail.setText(salesItem.sellerEmail)
        binding.editTextPhone.setText(salesItem.sellerPhone)
        binding.editTextPicture.setText(salesItem.pictureUrl)
        val simpleDateFormat = SimpleDateFormat("dd/MM/yyyy")
        val dateString = simpleDateFormat.format(Date(salesItem.time.toLong()*1000)).toString()
        binding.textviewItemTime.text = dateString


        binding.textviewItemId.text = salesItem.id.toString()

        binding.buttonBack.setOnClickListener {
            // findNavController().navigate(R.id.action_SecondFragment_to_FirstFragment)
            // https://stackoverflow.com/questions/60003039/why-android-navigation-component-screen-not-go-back-to-previous-fragment-but-a-m
            findNavController().popBackStack()
        }

        binding.buttonDelete.setOnClickListener {
            viewModel.delete(salesItem.id)
            findNavController().popBackStack()
        }

        binding.buttonUpdate.setOnClickListener {
            val description = binding.editTextTitle.text.toString().trim()
            //val publisher = binding.editTextPublisher.text.toString().trim()
            //val author = binding.editTextAuthor.text.toString().trim()
            val price = binding.editTextPrice.text.toString().trim().toInt()
            val pictureUrl = binding.editTextPicture.text.toString().trim()
            val sellerEmail = binding.editTextEmail.text.toString().trim()
            val sellPhone = binding.editTextPhone.text.toString().trim()
            val updatedItem = SalesItem(salesItem.id, description, pictureUrl, price, sellerEmail, sellPhone, (System.currentTimeMillis()/1000).toInt())
            Log.d("APPLE", "update $updatedItem")
            viewModel.update(updatedItem)
            findNavController().popBackStack()
        }


        /*binding.buttonSecond.setOnClickListener {
            findNavController().navigate(R.id.action_SecondFragment_to_FirstFragment)
        }*/
    }

    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }


}