import React, { useEffect } from 'react';
import { onAuthStateChanged } from "firebase/auth";
import { auth } from '../firebase';
import { Navigate } from "react-router-dom";
const AuthPage = (props) => {
    useEffect(() => {
        onAuthStateChanged(auth, (user) => {
          if (user) {
          } else {
            Navigate("/login")
          }
        });
      }, [])
      return (
        <>
            {props.children}
        </>
      )
}
export default AuthPage