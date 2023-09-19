const SearchBar = () => {
  return (
    <div className="flex mr-5 w-1/3 justify-end">
      <input
        type="text"
        placeholder="Search"
        className="content-center border-solid border-2 border-slate-600 rounded-full bg-transparent pl-4 w-96 h-12 placeholder:italic placeholder:text-slate-400 appearance-none focus:border-slate-300 focus:outline-none"
      ></input>
    </div>
  );
};

export default SearchBar;
