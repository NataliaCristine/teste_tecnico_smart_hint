import { createContext, useContext, useState } from "react";

export const FilterModalContext = createContext();

export const FilterModalProvider = ({ children }) => {
  const [status, setStatus] = useState(false);

  return (
    <FilterModalContext.Provider
      value={{
        status,
        setStatus,
      }}
    >
      {children}
    </FilterModalContext.Provider>
  );
};

export const useFilterModal = () => useContext(FilterModalContext);
