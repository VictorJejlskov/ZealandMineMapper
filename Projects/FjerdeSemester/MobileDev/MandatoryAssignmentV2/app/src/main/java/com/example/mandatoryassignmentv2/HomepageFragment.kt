package com.example.mandatoryassignmentv2

import android.content.res.Configuration
import android.os.Bundle
import android.util.Log
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.activityViewModels
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.mandatoryassignmentv2.databinding.FragmentHomepageBinding
import com.example.mandatoryassignmentv2.models.SalesItemAdapter
import com.example.mandatoryassignmentv2.models.SalesItemViewModel

class HomepageFragment : Fragment() {
    private var _binding: FragmentHomepageBinding? = null
    private val binding get() = _binding!!

    private val viewModel: SalesItemViewModel by activityViewModels()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        _binding = FragmentHomepageBinding.inflate(inflater, container, false)
        return binding.root
    }
    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        viewModel.salesItemsLiveData.observe(viewLifecycleOwner) { salesItems ->
            Log.d("CHECKFORTHISTAG", "onViewCreated: " + salesItems.size)
            if(salesItems != null){

            val adapter = SalesItemAdapter(salesItems) { position ->
//                findNavController().navigate(R.id.action_homepageFragment_to_loginFragment)
            }
            binding.recyclerView.layoutManager = LinearLayoutManager(activity)
            binding.recyclerView.adapter = adapter
            }
        }
    }
    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }
}