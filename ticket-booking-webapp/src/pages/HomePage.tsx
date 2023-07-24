import axios from "axios";
import { useState, useEffect } from "react";
import { Button, Container } from "@mui/material";
import CardEvent from "../components/CardEvent";
import EventsList from "../components/EventsList";
import api from "../api";

const HomePage = () => {
  const [events, setEvents] = useState([]);
  const [isLoading, setIsLoading] = useState(false);

  const fetchEvents = async () => {
    try {
      setIsLoading(true);
      const response = await api.get("/Event", {
        headers: {
          "ngrok-skip-browser-warning": "true",
        },
      });
      console.log(response);
      // setEvents(response.data);
    } catch (error) {
      console.error("Error fetching data:", error);
    } finally {
      setIsLoading(false);
    }
  };
  useEffect(() => {
    fetchEvents();
  }, []);
  return (
    <Container className="my-[80px] flex justify-center flex-col">
      <EventsList />
      <Button
        variant="contained"
        className="rounded-[20px] bg-main text-[#fff] text-[16px] px-[24px] py-[6px] mt-[24px] self-center"
        style={{ textTransform: "none" }}
      >
        See more
      </Button>
    </Container>
  );
};

export default HomePage;
