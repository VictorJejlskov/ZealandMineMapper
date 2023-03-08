package com.example.mandatoryassignment.models

data class Item(
    var description: String,
    var id: Int,
    var pictureUrl: Any,
    var price: Int,
    var sellerEmail: String,
    var sellerPhone: String,
    var time: Int
)