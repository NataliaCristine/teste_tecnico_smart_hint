import HeaderMenu from "../../Components/Header";
import { useFilterModal } from "../../Providers/FilterModal";
import DataGridDemo from "../../Components/FormFilterClient";
import ModalBasico from "../../Components/Modal";
import { useEffect, useState } from "react";
import TextField from "@mui/material/TextField";
import api from "../../Services";

import InputLabel from "@mui/material/InputLabel";
import MenuItem from "@mui/material/MenuItem";
import FormControl from "@mui/material/FormControl";
import Select from "@mui/material/Select";
import Button from "@mui/material/Button";

import { useGetData } from "../../Providers/GetData";

const Home = () => {
  const { status, setStatus } = useFilterModal();
  const { outputData, setOutputData } = useGetData();
  const [botaoDelete, setbotaoDelete] = useState(false);
  const [filterClient, setFilterClient] = useState({
    nomeRazaoSocial: null,
    email: null,
    telefone: null,
    dataCadastro: null,
    bloqueado: null,
  });

  useEffect(() => {}, [status, filterClient]);

  const filterClientsGet = (data) => {
    let queryParams = "a=b";

    if (filterClient.nomeRazaoSocial != null) {
      queryParams += `&nomeRazaoSocial=${filterClient.nomeRazaoSocial}`;
    }

    if (filterClient.email != null) {
      queryParams += `&email=${filterClient.email}`;
    }

    if (filterClient.telefone != null) {
      queryParams += `&telefone=${filterClient.telefone}`;
    }

    if (filterClient.dataCadastro != null) {
      queryParams += `&dataCadastro=${filterClient.dataCadastro}`;
    }

    api
      .get(`/client?${queryParams}`)
      .then((res) => {
        console.log(res);
        setOutputData(res.data);
      })
      .catch((err) => {
        console.log(err);
      });

    return outputData;
  };

  return (
    <div>
      <HeaderMenu />
      {status && (
        <ModalBasico open={status} handleClose={() => setStatus(false)}>
          <TextField
            id="outlined-basic"
            label="Nome ou Razão Social do Cliente"
            variant="outlined"
            onChange={(e) =>
              setFilterClient({
                ...filterClient,
                nomeRazaoSocial: e.target.value,
              })
            }
          />
          <TextField
            id="outlined-basic"
            label="E-mail do Cliente"
            variant="outlined"
            onChange={(e) =>
              setFilterClient({ ...filterClient, email: e.target.value })
            }
          />
          <TextField
            id="outlined-basic"
            label="Telefone do Cliente"
            variant="outlined"
            onChange={(e) =>
              setFilterClient({ ...filterClient, telefone: e.target.value })
            }
          />
          <TextField
            margin="normal"
            label="Data de Cadastro"
            type="datetime-local"
            InputLabelProps={{ shrink: true }}
            variant="outlined"
            name="realization_time"
            onChange={(newValue) => {
              setFilterClient({ ...filterClient, dataCadastro: newValue });
            }}
          />

          <FormControl fullWidth>
            <InputLabel id="demo-simple-select-label">Bloqueado</InputLabel>
            <Select
              labelId="demo-simple-select-label"
              id="demo-simple-select"
              label="bloqueado"
              onChange={(e) =>
                setFilterClient({
                  ...filterClient,
                  bloqueado: e.target.value === "Sim",
                })
              }
            >
              <MenuItem value={"Sim"}> Sim</MenuItem>
              <MenuItem value={"Não"}>Não</MenuItem>
            </Select>
          </FormControl>
          <div>
            <Button
              variant="contained"
              onClick={() => {
                filterClientsGet(filterClient);
                setStatus(false);
                setbotaoDelete(true);
              }}
            >
              Aplicar Filtro
            </Button>
            <Button
              variant="contained"
              onClick={() => {
                setFilterClient({
                  nomeRazaoSocial: "",
                  email: "",
                  telefone: "",
                  dataCadastro: "",
                  bloqueado: false,
                });
              }}
            >
              Limpar Filtro
            </Button>
          </div>
        </ModalBasico>
      )}
      <DataGridDemo />
      {botaoDelete && (
        <Button
          variant="contained"
          onClick={() => {
            setFilterClient({
              nomeRazaoSocial: "",
              email: "",
              telefone: "",
              dataCadastro: "",
              bloqueado: false,
            });
            setStatus(true);
            setbotaoDelete(false);
          }}
        >
          Deletar Filtro
        </Button>
      )}
    </div>
  );
};

export default Home;
