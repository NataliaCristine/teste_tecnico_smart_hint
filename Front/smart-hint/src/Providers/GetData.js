import { createContext, useContext, useState } from "react";

export const GetDataContext = createContext();

export const GetDataProvider = ({ children }) => {
  const [outputData, setOutputData] = useState(false);

  return (
    <GetDataContext.Provider
      value={{
        outputData,
        setOutputData,
      }}
    >
      {children}
    </GetDataContext.Provider>
  );
};

export const useGetData = () => useContext(GetDataContext);
