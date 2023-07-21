import axios from "axios";
import { useState, useEffect } from "react";
import { Button, Container } from "@mui/material";
import CardEvent from "../components/CardEvent";
import EventsList from "../components/EventsList";
import { FETCH_API } from "../config";

const HomePage = () => {
  const [events, setEvents] = useState([]);
  const [isLoading, setIsLoading] = useState(false);

  useEffect(() => {
    fetchEvents();
  }, []);

  const fetchEvents = async () => {
    try {
      setIsLoading(true);
      const response = await axios.get('https://b260-203-205-32-159.ngrok-free.app/api/Event');
      console.log(response);
      // setEvents(response.data);
    } catch (error) {
      console.error("Error fetching data:", error);
    } finally {
      setIsLoading(false);
    }
  };
  return (
    <Container className="py-[80px] flex justify-center flex-col">
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
