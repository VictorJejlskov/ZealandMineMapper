import { useCallback } from 'react';
import { auth } from '../../firebase';
import { useNavigate } from 'react-router-dom';

export function useLogout() {
  const navigate = useNavigate();

  const handleLogout = useCallback(async () => {
    try {
      await auth.signOut();
      navigate('/login');
      console.log('Signed out successfully');
    } catch (error) {
      console.error('Error signing out:', error);
    }
  }, [navigate]);


  return handleLogout;
}