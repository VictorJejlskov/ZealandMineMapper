package com.example.viewmodelexercise1

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.example.viewmodelexercise1.models.Person

class PersonViewModel : ViewModel() {
    val person: MutableLiveData<Person> = MutableLiveData()
}