// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getAuth } from "firebase/auth";
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "AIzaSyCdPFFv1pM8PIMmaGViCEEef9sEppQunyI",
  authDomain: "mandatoryassignmentwebapps.firebaseapp.com",
  projectId: "mandatoryassignmentwebapps",
  storageBucket: "mandatoryassignmentwebapps.appspot.com",
  messagingSenderId: "1034651790527",
  appId: "1:1034651790527:web:2f18c10ecbf8f645a26a0a",
  measurementId: "G-GLWBEX9FF6"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);

export const auth = getAuth(app);
export default app