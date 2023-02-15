// Import of React libraries
import React from 'react';
import ReactDOM from 'react-dom';

const greetingText = "Hello World :))!"
// Create a React component
const App = () => { 
    return <div style={{ backgroundColor: 'green'}}>{greetingText}</div>; 
}
// Render the React component in the browser
ReactDOM.render(<App/>, document.getElementById('root') );
