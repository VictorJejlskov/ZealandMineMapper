import { toast } from "react-toastify"

export const showSnackbar = (message) => {
    toast(message, {
        position: "bottom-right",
        autoClose: 3000,
        hideProgressBar: false,
        closeOnClick: true,
        pauseOnHover: true,
        draggable: false,
        progress: undefined,
        theme: "dark",
        });
    
}
