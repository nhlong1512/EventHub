import { Button, TextField } from "@mui/material";
import { Link } from "react-router-dom";
import { createTheme, ThemeProvider } from "@mui/material/styles";
import React from "react";

const theme = createTheme({
  palette: {
    primary: {
      main: "#5669FF",
    },
  },
});
const NavBar = () => {
  return (
    <div className="flex justify-between items-center px-[40px] py-[20px] border-b-[3px] border-b-[#ccc]">
      <div className="flex gap-[24px] items-center ">
        <Link to="/">
          <div className="cursor-pointer">
            <img src={require("../assets/icons/Logo.png")} alt="logo" />
          </div>
        </Link>
        <div className="">
          <ThemeProvider theme={theme}>
            <TextField
              label="Search"
              variant="outlined"
              className="w-[360px] rounded-[10px]"
            />
          </ThemeProvider>
        </div>
      </div>
      <div className="flex gap-[24px]">
        <Link to="/create-event">
          <Button
            variant="outlined"
            className="rounded-[20px] border-x-main border-y-main text-main px-[24px] py-[6px]"
          >
            Create event
          </Button>
        </Link>
        <Link to="/statistic">
          <Button
            variant="contained"
            className="rounded-[20px] bg-main text-[#fff] px-[24px] py-[6px]"
          >
            Statistic
          </Button>
        </Link>
      </div>
    </div>
  );
};

export default NavBar;
