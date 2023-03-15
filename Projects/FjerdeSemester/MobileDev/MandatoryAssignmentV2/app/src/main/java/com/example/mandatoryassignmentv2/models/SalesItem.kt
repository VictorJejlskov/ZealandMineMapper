package com.example.mandatoryassignmentv2.models

data class SalesItem(
    var description: String,
    var id: Int,
    var pictureUrl: Any,
    var price: Int,
    var sellerEmail: String,
    var sellerPhone: String,
    var time: Int
)