import { useNavigate } from "react-router-dom";
import Button from "@mui/material/Button";
import { useFilterModal } from "../../Providers/FilterModal";
import { Container } from "./style";

const HeaderMenu = () => {
  const navigate = useNavigate();
  const { setStatus, status } = useFilterModal();

  return (
    <div>
      <Container>
        <h3>
          Consulte os seus Clientes cadastrados na sua Loja ou realize o
          cadastro de novos Cliente
        </h3>
        <Button
          variant="contained"
          onClick={() => {
            navigate("/cadastro");
          }}
        >
          Adicionar Cliente
        </Button>
        <Button
          variant="contained"
          onClick={() => {
            setStatus(true);
          }}
        >
          Filtrar
        </Button>
      </Container>
    </div>
  );
};

export default HeaderMenu;
