import { Toaster } from "react-hot-toast";
import RoutesPage from "../src/Routes";

function App() {
  return (
    <>
      <Toaster position="top-center" reverseOrder={false} />
      <RoutesPage />
    </>
  );
}

export default App;
