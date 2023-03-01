package com.example.viewmodellistperson

class Student(
    var id: Int = -1,
    var name: String,
    var address: String,
    var yearOfBirth: Int,
    var semester: Int
) {
    override fun toString(): String {
        return "$id $name"
    }
}