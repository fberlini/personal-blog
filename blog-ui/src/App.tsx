import "./App.css";
import Header from "./Components/Header/Header";
import SideBar from "./Components/SideBar";
import Content from "./Components/Content";

function App() {
  return (
    <div className="bg-gray-900 text-white">
      <Header />
      <div className="flex m-0">
        <SideBar />
        <Content />
      </div>
    </div>
  );
}

export default App;
