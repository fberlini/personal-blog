import Logo from "./Logo";
import SearchBar from "./SearchBar";
import Title from "./Title";

const Header = () => {
  return (
    <nav className="flex items-center pt-5">
      <Logo />
      <Title />
      <SearchBar />
    </nav>
  );
};

export default Header;
