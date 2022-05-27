import { Route, Routes, Navigate } from "react-router-dom";
import Home from "../Pages/Home";
import CadastroCliente from "../Pages/Cadastro";

const RoutesPage = () => {
  return (
    <Routes>
      <Route path="/" element={<Home />} />
      <Route path="/cadastro" element={<CadastroCliente />} />
    </Routes>
  );
};

export default RoutesPage;
