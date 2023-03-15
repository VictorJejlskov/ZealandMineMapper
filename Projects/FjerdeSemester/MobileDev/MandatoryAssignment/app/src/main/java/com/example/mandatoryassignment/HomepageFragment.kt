package com.example.mandatoryassignment

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.activityViewModels
import androidx.navigation.fragment.findNavController
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.mandatoryassignment.databinding.FragmentHomepageBinding
import com.example.mandatoryassignment.models.Item
import com.example.mandatoryassignment.models.ItemAdapter
import com.example.mandatoryassignment.models.ItemsViewModel


class HomepageFragment : Fragment() {
    private var _binding: FragmentHomepageBinding? = null
    private val binding get() = _binding!!

    private val viewModel: ItemsViewModel by activityViewModels()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        _binding = FragmentHomepageBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        // configure RecyclerView
        binding.recyclerView.layoutManager = LinearLayoutManager(activity)
        val items: List<Item> = viewModel.items.value!!
        viewModel.items.observe(viewLifecycleOwner) {items ->
            binding.recyclerView.layoutManager = LinearLayoutManager(activity)
            val adapter = ItemAdapter(items) {position ->
                viewModel.selected.value = viewModel[position]
                viewModel.adding.value = false
            }
            binding.recyclerView.adapter = adapter
        }
    }

    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }
}