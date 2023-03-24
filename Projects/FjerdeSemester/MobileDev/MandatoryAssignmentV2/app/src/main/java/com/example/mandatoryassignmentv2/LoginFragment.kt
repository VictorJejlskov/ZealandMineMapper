package com.example.mandatoryassignmentv2

import android.os.Bundle
import android.util.Log
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.navigation.fragment.findNavController
import com.example.mandatoryassignmentv2.databinding.FragmentLoginBinding
import com.google.firebase.auth.FirebaseAuth
import com.google.firebase.auth.ktx.auth
import com.google.firebase.firestore.FirebaseFirestore
import com.google.firebase.ktx.Firebase

class LoginFragment : Fragment() {
    private var _binding: FragmentLoginBinding? = null
    private val binding get() = _binding!!

    private var auth: FirebaseAuth = FirebaseAuth.getInstance();

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        _binding = FragmentLoginBinding.inflate(inflater, container, false)
        return binding.root
    }
    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        binding.buttonLoginSignIn.setOnClickListener {
            val email = binding.edittextLoginUsername.text.trim().toString()
            if (email.isEmpty()){
                binding.edittextLoginUsername.error = "No username entered!"
                return@setOnClickListener
            }
            val password = binding.edittextLoginPassword.text.trim().toString()
            if (password.isEmpty()){
                binding.edittextLoginPassword.error ="No password entered!"
                return@setOnClickListener
            }
            auth.signInWithEmailAndPassword(email, password)
                .addOnCompleteListener(requireActivity()){
                    task ->
                    if (task.isSuccessful){
                        Log.d("LOGINTAG", "Login: LOGGED IN!!!!")
                        val user = auth.currentUser
                        findNavController().navigate(R.id.action_loginFragment_to_homepageFragment)
                    }
                    else {
                        Log.d("LOGINTAGFAIL", "Login: FAILED!!!", task.exception)

                    }
                }
        }
    }
    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }

}