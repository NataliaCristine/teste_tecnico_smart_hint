import { DataGrid } from "@mui/x-data-grid";
import { useNavigate } from "react-router-dom";
import { useGetData } from "../../Providers/GetData";

const columns = [
  { field: "userId", headerName: "ID", width: 90 },
  {
    field: "nomeRazaoSocial",
    headerName: "Nome/Razão Social",
    width: 150,
    editable: false,
  },
  {
    field: "email",
    headerName: "E-mail",
    width: 150,
    editable: false,
  },
  {
    field: "telefone",
    headerName: "Telefone",
    width: 150,
    editable: false,
  },
  {
    field: "dataCadastro",
    headerName: "Data de Cadastro",
    width: 150,
    editable: false,
  },
  {
    field: "bloqueado",
    headerName: "bloqueado",
    type: "boolean",
    width: 110,
    editable: true,
  },
];

// const rows = [
//   { id: 1, lastName: "Snow", firstName: "Jon", age: 35 },
//   { id: 2, lastName: "Lannister", firstName: "Cersei", age: 42 },
//   { id: 3, lastName: "Lannister", firstName: "Jaime", age: 45 },
//   { id: 4, lastName: "Stark", firstName: "Arya", age: 16 },
//   { id: 5, lastName: "Targaryen", firstName: "Daenerys", age: null },
//   { id: 6, lastName: "Melisandre", firstName: null, age: 150 },
//   { id: 7, lastName: "Clifford", firstName: "Ferrara", age: 44 },
//   { id: 8, lastName: "Frances", firstName: "Rossini", age: 36 },
//   { id: 9, lastName: "Roxie", firstName: "Harvey", age: 65 },
// ];

const DataGridDemo = () => {
  const { outputData, setOutputData } = useGetData();

  const navigate = useNavigate();
  // rows = rows.map((item) => (item["edicao"] = "Edição"));

  const updateStatus = (parametro) => {
    console.log(parametro);
    if (parametro !== outputData.bloqueado) {
      // const data = {
      //   bloqueado: parametro,
      // };
      // função que faz o put com a apis
    }
  };
  return (
    <div style={{ height: 800, width: "100%" }}>
      <DataGrid
        rows={outputData}
        columns={columns}
        pageSize={20}
        getRowId={(row) => row.userId}
        rowsPerPageOptions={[20]}
        checkboxSelection
        disableSelectionOnClick
        // onRowClick={(params, event) => {
        //   event.defaultMuiPrevented = true;
        //   navigate("/editar");
        // }}
        onCellEditStop={(params) => updateStatus(params.row.bloqueado)}
      />
    </div>
  );
};

export default DataGridDemo;
