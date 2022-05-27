import Button from "@mui/material/Button";
import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { useForm } from "react-hook-form";
import TextField from "@mui/material/TextField";
import InputLabel from "@mui/material/InputLabel";
import MenuItem from "@mui/material/MenuItem";
import FormControl from "@mui/material/FormControl";
import Select, { SelectChangeEvent } from "@mui/material/Select";
import FormControlLabel from "@mui/material/FormControlLabel";
import Checkbox from "@mui/material/Checkbox";
import { Container } from "./style";
import { toast } from "react-hot-toast";
import api from "../../Services";

const CadastroCliente = () => {
  const navigate = useNavigate();

  const [inscricaoEstadual, setInscricaoEstadual] = useState(false);
  const [bloqueado, setBloqueado] = useState(false);
  const [tipoPessoa, setTipoPessoa] = useState(0);

  const {
    register,
    formState: { errors },
    handleSubmit,
    getValues,
  } = useForm();

  const onSubmitData = (data) => {
    data["tipoPessoa"] = tipoPessoa;
    data["telefone"] = parseInt(data["telefone"]);
    delete data.confirmPassword;
    if (tipoPessoa === 1) {
      data["cpf"] = parseInt(data["cpf"]);
    } else {
      data["cnpj"] = parseInt(data["cnpj"]);
      data["inscricaoEstadual"] = parseInt(data["inscricaoEstadual"]);
    }

    console.log(data);
    // enviar para api no post
    api
      .post("/client", data)
      .then((res) => navigate("/"))
      .catch((err) => {
        toast.error(`${err.response.data}`);
      });

    setInscricaoEstadual(false);
    setBloqueado(false);
  };

  useEffect(() => {});

  const handleChange = (event) => {
    setTipoPessoa(event.target.value);
  };

  return (
    <Container>
      <form onSubmit={handleSubmit(onSubmitData)} className="form">
        <TextField
          id="outlined-basic"
          label="Nome ou Razão Social do Cliente"
          variant="outlined"
          className="TextField"
          {...register("nomeRazaoSocial", { required: true })}
        />
        {errors.nomeRazaoSocial && "Field is required"}
        <TextField
          id="outlined-basic"
          label="E-mail do Cliente"
          variant="outlined"
          className="TextField"
          {...register("email", { required: true })}
        />
        {errors.email && "Field is required"}
        <TextField
          id="outlined-basic"
          label="Telefone do Cliente"
          variant="outlined"
          className="TextField"
          {...register("telefone", { required: true })}
        />
        {errors.telefone && "Field is required"}
        <TextField
          margin="normal"
          label="Data/Hora"
          type="datetime-local"
          InputLabelProps={{ shrink: true }}
          variant="outlined"
          className="TextField"
          name="realization_time"
          {...register("dataCadastro")}
        />
        <TextField
          id="outlined-basic"
          label="Password"
          variant="outlined"
          type="password"
          className="TextField"
          {...register("password", { required: true, min: 8, max: 15 })}
        />
        {errors?.password?.type === "required" && "Field is required"}
        {errors?.password?.type === "min" &&
          "Passwords must have at least 8 characters"}
        {errors?.password?.type === "max" &&
          "Passwords must have at most 8 characters"}
        <TextField
          id="outlined-basic"
          label="Confirma Password"
          variant="outlined"
          type="password"
          className="TextField"
          {...register("confirmPassword", {
            required: true,
            validate: (value) => value === getValues("password"),
          })}
        />
        {errors?.confirmPassword?.type === "required" && "Field is required"}
        {errors?.confirmPassword?.type === "validate" &&
          "Passwords doesn't match"}

        <FormControl fullWidth className="TextField">
          <InputLabel id="demo-simple-select-label">Tipo de pessoa</InputLabel>
          <Select
            labelId="demo-simple-select-label"
            id="demo-simple-select"
            label="pessoa fisica"
            onChange={handleChange}
            value={tipoPessoa}
          >
            <MenuItem value={1}> Física</MenuItem>
            <MenuItem value={2}>Jurídica</MenuItem>
          </Select>
          {errors.tipoPessoa && "Field is required"}
        </FormControl>

        {tipoPessoa === 1 && (
          <>
            <TextField
              id="outlined-basic"
              label="CPF do cliente"
              variant="outlined"
              className="TextField"
              {...register("cpf", { required: tipoPessoa === 1, min: 11 })}
            />
            {errors?.cpf?.type === "required" && "Field is required"}
            {errors?.cpf?.type === "min" && "Must contain 11 characters"}

            <FormControl fullWidth className="TextField">
              <InputLabel id="demo-simple-select-label">Gênero</InputLabel>
              <Select
                labelId="demo-simple-select-label"
                id="demo-simple-select"
                label="genêro"
                defaultValue=""
                {...register("genero", { required: tipoPessoa === 1 })}
              >
                <MenuItem value={"F"}> Feminino</MenuItem>
                <MenuItem value={"M"}>Masculino</MenuItem>
              </Select>
              {errors.genero && "Field is required"}
            </FormControl>
            <TextField
              margin="normal"
              label="Data de Nascimento"
              type="datetime-local"
              InputLabelProps={{ shrink: true }}
              variant="outlined"
              name="realization_time"
              className="TextField"
              {...register("dataNascimento", { required: tipoPessoa === 1 })}
            />
            {errors.dataNascimento && "Field is required"}
          </>
        )}
        {tipoPessoa === 2 && (
          <>
            <TextField
              id="outlined-basic"
              label="CNPJ do cliente"
              variant="outlined"
              className="TextField"
              {...register("cnpj", { required: tipoPessoa === 2 })}
            />
            {errors?.cnpj?.type === "required" && "Field is required"}

            <TextField
              id="outlined-basic"
              label="Inscrição Estadual"
              variant="outlined"
              className="TextField"
              disabled={inscricaoEstadual}
              {...register("inscricaoEstadual", {
                required: tipoPessoa === 2,
              })}
            />
            {errors.inscricaoEstadual?.type === "required" &&
              "Field is required"}

            <FormControlLabel
              control={<Checkbox />}
              label="isento"
              onChange={(e) => setInscricaoEstadual(!inscricaoEstadual)}
            />
          </>
        )}
        <FormControlLabel
          control={<Checkbox />}
          label="bloqueado"
          onChange={(e) => setBloqueado(!bloqueado)}
        />
        <Button type="submit" variant="outlined" className="TextField">
          Cadastrar
        </Button>
      </form>
      <Button
        variant="contained"
        onClick={() => {
          navigate("/");
        }}
        className="TextField"
      >
        Voltar
      </Button>
    </Container>
  );
};
export default CadastroCliente;
