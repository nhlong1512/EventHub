import { Button, TextField } from "@mui/material";
import { Link } from "react-router-dom";
import React from "react";

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
          <input
            type="search"
            className="m-0 block rounded border border-solid w-[300px] border-[#ccc] px-[16px] py-[8px] text-[18px] leading-[24px] outline-none transition duration-200 ease-in-out focus:z-[3] focus:border-main focus:shadow-[inset_0_0_0_1px_rgb(59,113,202)] focus:outline-none"
            placeholder="🔍 Search"
          />
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
