package com.example.mandatoryassignmentv2.repository

import android.util.Log
import androidx.lifecycle.MutableLiveData
import com.example.mandatoryassignmentv2.models.SalesItem
import retrofit2.*
import retrofit2.converter.gson.GsonConverterFactory

class SalesItemRepository {
    private val url = "https://anbo-salesitems.azurewebsites.net/api/"

    private val salesItemService: SalesItemService
    val salesItemsLiveData: MutableLiveData<List<SalesItem>> = MutableLiveData<List<SalesItem>>()
    val errorMessageLiveData: MutableLiveData<String> = MutableLiveData()
    val updateMessageLiveData: MutableLiveData<String> = MutableLiveData()


    init {
        val build: Retrofit = Retrofit.Builder()
            .baseUrl(url)
            .addConverterFactory(GsonConverterFactory.create())
            .build()
        salesItemService = build.create(SalesItemService::class.java)
        getItems()
    }

    fun getItems(){
        salesItemService.getAllItems().enqueue(object : Callback<List<SalesItem>> {
            override fun onResponse(call: Call<List<SalesItem>>, response: Response<List<SalesItem>>) {
                if (response.isSuccessful) {
                    val b: List<SalesItem>? = response.body()
                    salesItemsLiveData.postValue(b!!)
                    errorMessageLiveData.postValue("")
                } else {
                    val message = response.code().toString() + " " + response.message()
                    errorMessageLiveData.postValue(message)
                    Log.d("APPLE", message)
                }
            }

            override fun onFailure(call: Call<List<SalesItem>>, t: Throwable) {
                //booksLiveData.postValue(null)
                errorMessageLiveData.postValue(t.message)
                Log.d("ORANGE", t.message!!)
            }
        })
    }
    fun add(book: SalesItem) {
        salesItemService.saveItem(book).enqueue(object : Callback<SalesItem> {
            override fun onResponse(call: Call<SalesItem>, response: Response<SalesItem>) {
                if (response.isSuccessful) {
                    Log.d("APPLE", "Added: " + response.body())
                    updateMessageLiveData.postValue("Added: " + response.body())
                    getItems()
                } else {
                    val message = response.code().toString() + " " + response.message()
                    errorMessageLiveData.postValue(message)
                    Log.d("APPLE", message)
                }
            }

            override fun onFailure(call: Call<SalesItem>, t: Throwable) {
                errorMessageLiveData.postValue(t.message)
                Log.d("ORANGE", t.message!!)
            }
        })
    }

    fun delete(id: Int) {
        salesItemService.deleteItem(id).enqueue(object : Callback<SalesItem> {
            override fun onResponse(call: Call<SalesItem>, response: Response<SalesItem>) {
                if (response.isSuccessful) {
                    Log.d("APPLE", "Updated: " + response.body())
                    updateMessageLiveData.postValue("Deleted: " + response.body())
                } else {
                    val message = response.code().toString() + " " + response.message()
                    errorMessageLiveData.postValue(message)
                    Log.d("APPLE", message)
                }
            }

            override fun onFailure(call: Call<SalesItem>, t: Throwable) {
                errorMessageLiveData.postValue(t.message)
                Log.d("ORANGE", t.message!!)
            }
        })
    }

    fun update(item: SalesItem) {
        salesItemService.updateItem(item.id, item).enqueue(object : Callback<SalesItem> {
            override fun onResponse(call: Call<SalesItem>, response: Response<SalesItem>) {
                if (response.isSuccessful) {
                    Log.d("APPLE", "Updated: " + response.body())
                    updateMessageLiveData.postValue("Updated: " + response.body())
                } else {
                    val message = response.code().toString() + " " + response.message()
                    errorMessageLiveData.postValue(message)
                    Log.d("APPLE", "Update: $message")
                }
            }

            override fun onFailure(call: Call<SalesItem>, t: Throwable) {
                errorMessageLiveData.postValue(t.message)
                Log.d("ORANGE", t.message!!)
            }
        })
    }

    fun sortByDescription() {
        salesItemsLiveData.value = salesItemsLiveData.value?.sortedBy { it.description }
    }

    fun sortByDescriptionDescending() {
        salesItemsLiveData.value = salesItemsLiveData.value?.sortedByDescending { it.description }
    }

    fun sortByPrice() {
        salesItemsLiveData.value = salesItemsLiveData.value?.sortedBy { it.price }
    }

    fun sortByPriceDescending() {
        salesItemsLiveData.value = salesItemsLiveData.value?.sortedByDescending { it.price }
    }

    fun filterByDescription(desc: String) {
        if (desc.isBlank()) {
            getItems()
        }else {
            salesItemsLiveData.value = salesItemsLiveData.value?.filter { book -> book.description.contains(desc) }
            // TODO: bug fix: booksLiveData.value keeps getting smaller for each filter
        }
    }
}