package com.example.mandatoryassignment.models

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.example.mandatoryassignment.R

class ItemAdapter(
    private val items: List<Item>,
    private val onItemClicked: (position: Int) -> Unit
) :
    RecyclerView.Adapter<ItemAdapter.MyViewHolder>() {

    override fun getItemCount(): Int {
        return items.size
    }

    override fun onCreateViewHolder(viewGroup: ViewGroup, viewType: Int): MyViewHolder {
        // Create a new view, which defines the UI of the list item
        val view = LayoutInflater.from(viewGroup.context)
            .inflate(R.layout.salesitem_list_item, viewGroup, false)
        return MyViewHolder(view, onItemClicked)
    }

    override fun onBindViewHolder(viewHolder: MyViewHolder, position: Int) {
        // Get element from your dataset at this position and replace the
        // contents of the view with that element
        viewHolder.textViewItemId.text = items[position].id.toString()
        viewHolder.textViewItemDescription.text = items[position].description
    }

    class MyViewHolder(itemView: View, private val onItemClicked: (position: Int) -> Unit) :
        RecyclerView.ViewHolder(itemView), View.OnClickListener {
        val textViewItemId: TextView = itemView.findViewById(R.id.textview_item_id)
        val textViewItemDescription: TextView = itemView.findViewById(R.id.textview_item_description)

        init {
            itemView.setOnClickListener(this)
        }

        override fun onClick(view: View) {
            val position = bindingAdapterPosition
            // gradle     implementation "androidx.recyclerview:recyclerview:1.2.1"
            onItemClicked(position)
        }
    }
}