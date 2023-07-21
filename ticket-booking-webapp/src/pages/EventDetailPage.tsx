import { Container } from "@mui/material";
import React from "react";
import SeatsList from "../components/SeatsList";

const EventDetailPage = () => {
  return (
    <Container className="my-[80px]">
      <SeatsList />
    </Container>
  );
};

export default EventDetailPage;
