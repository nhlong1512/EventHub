import { useState, useEffect } from "react";
import { Button, CircularProgress, Container } from "@mui/material";
import EventsList from "../components/EventsList";
import { shallow } from "zustand/shallow";
import api from "../api";
import { IEvent } from "../Dto/IEvent";
import { useSearchStore } from "../store/search";

const UnpublishedEvent = () => {
  const [searchString, setSearchString] = useSearchStore(
    (state) => [state.searchString, state.setSearchString],
    shallow
  );

  const [events, setEvents] = useState<IEvent[]>([]);
  const [isLoading, setIsLoading] = useState<boolean>(false);

  const fetchEvents = async () => {
    try {
      setIsLoading(true);
      const response = await api.get("/Event", {
        params: {
          isPublished: "false",
        },
        headers: {
          "ngrok-skip-browser-warning": "true",
        },
      });
      setEvents(response.data);
    } catch (error) {
      console.error("Error fetching data:", error);
    } finally {
      setIsLoading(false);
    }
  };
  useEffect(() => {
    fetchEvents();
  }, []);

  //handle search
  const filterEventsSearch = events.filter(
    (event) =>
      event.title.toLowerCase().includes(searchString.toLowerCase().trim()) ||
      event.minPrice
        .toString()
        .toLowerCase()
        .includes(searchString.toLowerCase().trim()) ||
      event.date.toLowerCase().includes(searchString.toLowerCase().trim()) ||
      event.city.toLowerCase().includes(searchString.toLowerCase().trim())
  );

  return (
    <Container className="my-[80px] flex items-center justify-start self-start flex-col">
      <h3 className="m-0 mb-[60px] text-[32px] leading-[40px] text-main">
        Unpublished Events List
      </h3>
      {isLoading ? (
        <div>
          <CircularProgress />
          <p>Loading...</p>
        </div>
      ) : (
        <EventsList events={filterEventsSearch} />
      )}
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

export default UnpublishedEvent;