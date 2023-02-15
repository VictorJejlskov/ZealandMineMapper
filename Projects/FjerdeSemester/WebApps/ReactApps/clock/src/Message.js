import React, { Component } from 'react';
import Clock from './Clock';

class Message extends Component {
    render(props) {
      return (
        <div className="Message">
          <Clock/>
        </div>
      );
    }
  }
  export default Message