package com.example.mandatoryassignmentv2.models

import android.util.Log
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel

class SalesItemViewModel: ViewModel() {
    var adding: MutableLiveData<Boolean> = MutableLiveData(false)
    var selected = MutableLiveData<SalesItem>()


    private var _nextId = 1;
    private var _salesItemList = mutableListOf<SalesItem>(
        SalesItem("Bog", _nextId++, "null", 100, "lol@gmail.com", "81611117", 0),
        SalesItem("Hus", _nextId++, "null", 2423623, "xD@gmail.com", "81611117", 0),
        SalesItem("Kat", _nextId++, "null", 2667, "viggo@gmail.com", "81611117", 0),
        SalesItem("Hund", _nextId++, "null", 655, "feij@gmail.com", "81611117", 0),
        SalesItem("PC", _nextId++, "null", 423, "haje@gmail.com", "81611117", 0),
    )
    private var salesItemMutableLiveData: MutableLiveData<List<SalesItem>> = MutableLiveData(_salesItemList)
    val salesItemsLiveData: LiveData<List<SalesItem>> = salesItemMutableLiveData


    fun add(salesItem: SalesItem){
        salesItem.id = _nextId++
        _salesItemList.add(salesItem)
        salesItemMutableLiveData.value = _salesItemList
        Log.d("ADDEDITEMNOTIFICATION", "ADDED: " + salesItem + "  -  new length: " + salesItemsLiveData.value!!.size)
    }
    fun remove(id: Int){
        _salesItemList.removeAll { salesItem -> salesItem.id == id }
    }
    fun update(id: Int, info: SalesItem){
        val salesItem: SalesItem = _salesItemList.first{salesitem -> salesitem.id == id}
        salesItem.description = info.description
        salesItem.price = info.price
        salesItem.pictureUrl = info.pictureUrl
        salesItem.sellerEmail = info.sellerEmail
        salesItem.sellerPhone = info.sellerPhone
        salesItem.time = info.time
    }
    operator fun get(position: Int): SalesItem{
        return _salesItemList[position]
    }
}