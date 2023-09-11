const SearchBar = () => {
  return (
    <div className="mr-5">
      <input
        type="text"
        placeholder="Search"
        className="content-center border-solid border-2 border-slate-600 rounded-full bg-transparent pl-4 w-96 h-12 placeholder:italic placeholder:text-slate-400 appearance-none focus:border-slate-300 focus:outline-none"
      ></input>
    </div>
  );
};

export default SearchBar;
