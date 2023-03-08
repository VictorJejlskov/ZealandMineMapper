package com.example.mandatoryassignment.models

import android.util.Log
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel

class ItemsViewModel: ViewModel() {
    private var _itemsList = mutableListOf(
        Item("Bog", 1, "null", 100, "hej@gmail.com", "+4581611117", 0),
        Item("Hat", 2, "null", 200, "hej@gmail.com", "+4581611117", 0),
        Item("Kat", 3, "null", 500, "hej@gmail.com", "+4581611117", 0),
        Item("Flat", 4, "null", 300, "hej@gmail.com", "+4581611117", 0),
        Item("Pat", 5, "null", 200, "hej@gmail.com", "+4581611117", 0),
    )
    private var _items = MutableLiveData<List<Item>>(_itemsList)
    var selected = MutableLiveData<Item>()
    var items: LiveData<List<Item>> = _items
    val adding: MutableLiveData<Boolean> = MutableLiveData(false)

    fun add(item: Item){
        item.id = _itemsList.size + 1
        _itemsList.add(item)
        _items.value = _itemsList
        Log.d("SAVE-LOG", "added item, new size: " + _itemsList.size)
    }
    fun remove(id: Int){
        _itemsList.removeAll{ item -> item.id == id}
    }
    fun update(id: Int, info: Item){
        val item: Item = _itemsList.first{ item -> item.id == id }
        item.description = info.description
        item.price = info.price
        item.pictureUrl = info.pictureUrl
        item.sellerEmail = info.sellerEmail
        item.sellerPhone = info.sellerPhone
        item.time = info.time
    }
    operator fun get(position: Int): Item {
        return _itemsList[position]
    }
}