package com.example.mandatoryassignmentv2.models

data class SalesItem(
    var id: Int,
    var description: String,
    var pictureUrl: String,
    var price: Int,
    var sellerEmail: String,
    var sellerPhone: String,
    var time: Int
)