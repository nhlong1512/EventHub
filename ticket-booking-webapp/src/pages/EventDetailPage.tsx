import { Container } from "@mui/material";
import React from "react";
import EventDescription from "../components/EventDescription";
import SeatDescription from "../components/SeatDescription";
import SeatsList from "../components/SeatsList";

const EventDetailPage = () => {
  return (
    <Container className="my-[80px]">
      <EventDescription/>
      <SeatDescription/>
      <SeatsList />
    </Container>
  );
};

export default EventDetailPage;
