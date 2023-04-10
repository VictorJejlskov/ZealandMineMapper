import { useEffect, useState } from "react";
import { onAuthStateChanged } from "firebase/auth";
import { auth } from '../../firebase';
import { useNavigate } from 'react-router-dom'
export function useUser() {
    const [authenticated, setAuthenticated] = useState(false);
    const [user, setUser] = useState(null);
    const navigate = useNavigate();


    useEffect(() => {
        onAuthStateChanged(auth, (user) => {
            if (!user) {
                navigate("/login")
            } else {
                setUser(user)
                setAuthenticated(true)
            }
        });
    }, [navigate]);

    return { user, authenticated };
}