import { Container, Divider } from "@mui/material";
import React from "react";
import { Outlet } from "react-router-dom";
import Footer from "./Footer";
import NavBar from "./NavBar";

const Layout = () => {
  return (
    <div className="h-full min-h-[100vh]">
      <NavBar />
      <Divider />
      <Outlet />
      <Footer />
    </div>
  );
};

export default Layout;