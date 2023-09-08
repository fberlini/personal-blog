import React from 'react';
import './App.css';
import Post from './Components/Post';
import Header from './Components/Header';
import SideBar from './Components/SideBar';

function App() {
  return (
    <div className="App">
      <Header/>
      <Post/>
      <SideBar/>
    </div>
  );
}

export default App;
