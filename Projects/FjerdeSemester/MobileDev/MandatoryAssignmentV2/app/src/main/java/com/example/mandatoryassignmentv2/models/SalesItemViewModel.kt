package com.example.mandatoryassignmentv2.models

import android.util.Log
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.example.mandatoryassignmentv2.repository.SalesItemRepository

class SalesItemViewModel: ViewModel() {
    private val repository = SalesItemRepository()
    val salesItemsLiveData: LiveData<List<SalesItem>> = repository.salesItemsLiveData
    val errorMessageLiveData: LiveData<String> = repository.errorMessageLiveData
    val updateMessageLiveData: LiveData<String> = repository.updateMessageLiveData

    init {
        reload()
    }

    fun reload() {
        repository.getItems()
    }

    operator fun get(index: Int): SalesItem? {
        return salesItemsLiveData.value?.get(index)
    }

    fun add(item: SalesItem) {
        repository.add(item)
    }

    fun delete(id: Int) {
        repository.delete(id)
    }

    fun update(item: SalesItem) {
        repository.update(item)
    }

    fun sortByDescription() {
        repository.sortByDescription()
    }

    fun sortByDescriptionDescending() {
        repository.sortByDescriptionDescending()
    }

    fun sortByPrice() {
        repository.sortByPrice()
    }

    fun sortByPriceDescending() {
        repository.sortByPriceDescending()
    }

    fun filterByDescription(desc: String) {
        repository.filterByDescription(desc)
    }

    fun filterByEmail(email: String){
        repository.filterByEmail(email)
    }
}