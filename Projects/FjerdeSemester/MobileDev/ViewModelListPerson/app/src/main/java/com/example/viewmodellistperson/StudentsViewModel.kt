package com.example.viewmodellistperson

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel

class StudentsViewModel: ViewModel() {
    private var _nextId = 1
    private var _studentList = mutableListOf(
        Student(_nextId++, "Victor", "Roskilde", 1997, 4),
        Student(_nextId++, "Andreas", "Jyllinge", 1996, 4),
        Student(_nextId++, "Martin", "Kirke EtEllerAndet", 1970, 4),
        Student(_nextId++, "Mads", "Taastrup", 2000, 4),
        Student(_nextId++, "Frederik", "Roskilde", 1999, 4)
    )
    private var _students = MutableLiveData<List<Student>>(_studentList)
    var selected = MutableLiveData<Student>()

    var students:   LiveData<List<Student>> = _students
    val adding: MutableLiveData<Boolean> = MutableLiveData(false)

    fun add(student: Student) {
        student.id = _nextId++
        _studentList.add(student)
        _students.value = _studentList
    }
    fun remove(id: Int){
        _studentList.removeAll{ student -> student.id == id}
    }
    fun update(id: Int, info: Student){
        val student: Student = _studentList.first { stud -> stud.id == id}
        student.name = info.name
        student.address = info.address
        student.semester = info.semester
        student.yearOfBirth = info.yearOfBirth
    }

    operator fun get(position: Int): Student {
        return _studentList[position]
    }
}