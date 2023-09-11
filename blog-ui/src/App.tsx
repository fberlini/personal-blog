import React from "react";
import "./App.css";
import Post from "./Components/Post/Post";
import Header from "./Components/Header/Header";
import SideBar from "./Components/SideBar";

function App() {
  return (
    <div className="bg-gray-900 text-white space-y-4">
      <Header />
      <div className="flex m-0">
        <SideBar />
        <Post />
      </div>
    </div>
  );
}

export default App;
