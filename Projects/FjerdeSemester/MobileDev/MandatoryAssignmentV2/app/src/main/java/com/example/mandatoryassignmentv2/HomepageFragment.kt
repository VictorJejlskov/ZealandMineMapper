package com.example.mandatoryassignmentv2

import android.R
import android.content.res.Configuration
import android.os.Bundle
import android.util.Log
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ArrayAdapter
import androidx.fragment.app.activityViewModels
import androidx.navigation.fragment.findNavController
import androidx.recyclerview.widget.GridLayoutManager
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
        viewModel.salesItemsLiveData.observe(viewLifecycleOwner) { items ->
            //Log.d("APPLE", "observer $books")
            binding.progressbar.visibility = View.GONE
            binding.recyclerView.visibility = if (items == null) View.GONE else View.VISIBLE
            if (items != null) {
                val adapter = SalesItemAdapter(items) { position ->
                    val action =
                        HomepageFragmentDirections.actionHomepageFragmentToItemDetailsFragment(position)
                    findNavController().navigate(action)
                }
                // binding.recyclerView.layoutManager = LinearLayoutManager(activity)
                var columns = 2
                val currentOrientation = this.resources.configuration.orientation
                if (currentOrientation == Configuration.ORIENTATION_LANDSCAPE) {
                    columns = 4
                } else if (currentOrientation == Configuration.ORIENTATION_PORTRAIT) {
                    columns = 2
                }
                binding.recyclerView.layoutManager = GridLayoutManager(this.context, columns)
                binding.recyclerView.adapter = adapter
            }
        }

        viewModel.errorMessageLiveData.observe(viewLifecycleOwner) { errorMessage ->
            binding.textviewMessage.text = errorMessage
        }

        viewModel.reload()

        binding.swiperefresh.setOnRefreshListener {
            viewModel.reload()
            binding.swiperefresh.isRefreshing = false // TODO too early
        }
        binding.buttonSort.setOnClickListener {
            when (binding.spinnerSorting.selectedItemPosition) {
                0 -> viewModel.sortByDescription()
                1 -> viewModel.sortByDescriptionDescending()
                2 -> viewModel.sortByPrice()
                3 -> viewModel.sortByPriceDescending()
            }
        }

        binding.buttonFilter.setOnClickListener {
            val title = binding.edittextFilterTitle.text.toString().trim()
            /* if (title.isBlank()) {
                 binding.edittextFilterTitle.error = "No title"
                 return@setOnClickListener
             }*/
            viewModel.filterByDescription(title)
        }
    }
    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }
}