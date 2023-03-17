package com.example.mandatoryassignmentv2.repository

import com.example.mandatoryassignmentv2.models.SalesItem
import retrofit2.Call
import retrofit2.http.*

interface SalesItemService {
    @GET("salesitems")
    fun getAllItems(): Call<List<SalesItem>>

    @GET("salesitems/{itemId}")
    fun getItemById(@Path("itemId") itemId: Int): Call<SalesItem>

    @POST("salesitems")
    fun saveItem(@Body item: SalesItem): Call<SalesItem>

    @DELETE("salesitems/{id}")
    fun deleteItem(@Path("id") id: Int): Call<SalesItem>

    @PUT("salesitems/{id}")
    fun updateItem(@Path("id") id: Int, @Body item: SalesItem): Call<SalesItem>
}