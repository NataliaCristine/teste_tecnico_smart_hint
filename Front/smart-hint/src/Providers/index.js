import { FilterModalProvider } from "../Providers/FilterModal";
import { GetDataProvider } from "../Providers/GetData";

const Providers = ({ children }) => {
  return (
    <GetDataProvider>
      <FilterModalProvider>{children}</FilterModalProvider>;
    </GetDataProvider>
  );
};

export default Providers;
