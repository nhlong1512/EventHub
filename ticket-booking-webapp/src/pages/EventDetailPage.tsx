import { CircularProgress, Container } from "@mui/material";
import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import api from "../api";
import EventDescription from "../components/EventDescription";
import SeatDescription from "../components/SeatDescription";
import SeatsList from "../components/SeatsList";
import { IEvent } from "../models/IEvents";
import { ISeat } from "../models/ISeat";

const EventDetailPage = () => {
  const { eventId } = useParams<{ eventId: string }>();

  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [event, setEvent] = useState<IEvent>();

  const fetchEvent = async () => {
    try {
      setIsLoading(true);
      const response = await api.get(`/Event/${eventId}`, {
        headers: {
          "ngrok-skip-browser-warning": "true",
        },
      });
      console.log(response.data);
      if (response.data) {
        setEvent(response.data);
      }
    } catch (error) {
      console.error("Error fetching data:", error);
    } finally {
      setIsLoading(false);
    }
  };
  useEffect(() => {
    fetchEvent();
  }, [eventId]);

  const [seatsList, setSeatsList] = useState<ISeat[]>([
    { seatId: 1, typeSeat: "standard", statusSeat: "banned" },
    { seatId: 2, typeSeat: "standard", statusSeat: "default" },
    { seatId: 3, typeSeat: "standard", statusSeat: "default" },
    { seatId: 4, typeSeat: "standard", statusSeat: "picked" },
    { seatId: 5, typeSeat: "standard", statusSeat: "default" },
    { seatId: 6, typeSeat: "standard", statusSeat: "default" },
    { seatId: 7, typeSeat: "standard", statusSeat: "default" },
    { seatId: 8, typeSeat: "standard", statusSeat: "default" },
    { seatId: 9, typeSeat: "standard", statusSeat: "default" },
    { seatId: 10, typeSeat: "standard", statusSeat: "default" },
    { seatId: 11, typeSeat: "standard", statusSeat: "default" },
    { seatId: 12, typeSeat: "standard", statusSeat: "default" },
    { seatId: 13, typeSeat: "standard", statusSeat: "default" },
    { seatId: 14, typeSeat: "standard", statusSeat: "default" },
    { seatId: 15, typeSeat: "standard", statusSeat: "default" },
    { seatId: 16, typeSeat: "standard", statusSeat: "default" },
    { seatId: 17, typeSeat: "standard", statusSeat: "default" },
    { seatId: 18, typeSeat: "standard", statusSeat: "default" },
    { seatId: 19, typeSeat: "standard", statusSeat: "default" },
    { seatId: 20, typeSeat: "standard", statusSeat: "default" },
    { seatId: 21, typeSeat: "standard", statusSeat: "default" },
    { seatId: 22, typeSeat: "standard", statusSeat: "default" },
    { seatId: 23, typeSeat: "standard", statusSeat: "default" },
    { seatId: 24, typeSeat: "standard", statusSeat: "default" },
    { seatId: 25, typeSeat: "standard", statusSeat: "default" },
    { seatId: 26, typeSeat: "standard", statusSeat: "default" },
    { seatId: 27, typeSeat: "standard", statusSeat: "default" },
    { seatId: 28, typeSeat: "standard", statusSeat: "default" },
    { seatId: 29, typeSeat: "standard", statusSeat: "default" },
    { seatId: 30, typeSeat: "standard", statusSeat: "default" },
    { seatId: 31, typeSeat: "standard", statusSeat: "default" },
    { seatId: 32, typeSeat: "standard", statusSeat: "default" },
    { seatId: 33, typeSeat: "standard", statusSeat: "default" },
    { seatId: 34, typeSeat: "standard", statusSeat: "default" },
    { seatId: 35, typeSeat: "standard", statusSeat: "default" },
    { seatId: 36, typeSeat: "standard", statusSeat: "default" },
    { seatId: 37, typeSeat: "vip", statusSeat: "banned" },
    { seatId: 38, typeSeat: "vip", statusSeat: "default" },
    { seatId: 39, typeSeat: "vip", statusSeat: "default" },
    { seatId: 40, typeSeat: "vip", statusSeat: "picked" },
    { seatId: 41, typeSeat: "vip", statusSeat: "default" },
    { seatId: 42, typeSeat: "vip", statusSeat: "default" },
    { seatId: 43, typeSeat: "vip", statusSeat: "default" },
    { seatId: 44, typeSeat: "vip", statusSeat: "default" },
    { seatId: 45, typeSeat: "vip", statusSeat: "default" },
    { seatId: 46, typeSeat: "vip", statusSeat: "default" },
    { seatId: 47, typeSeat: "vip", statusSeat: "default" },
    { seatId: 48, typeSeat: "vip", statusSeat: "default" },
    { seatId: 49, typeSeat: "vip", statusSeat: "default" },
    { seatId: 50, typeSeat: "vip", statusSeat: "default" },
    { seatId: 51, typeSeat: "vip", statusSeat: "default" },
    { seatId: 52, typeSeat: "vip", statusSeat: "default" },
    { seatId: 53, typeSeat: "vip", statusSeat: "default" },
    { seatId: 54, typeSeat: "vip", statusSeat: "default" },
    { seatId: 55, typeSeat: "vip", statusSeat: "default" },
    { seatId: 56, typeSeat: "vip", statusSeat: "default" },
    { seatId: 57, typeSeat: "vip", statusSeat: "default" },
    { seatId: 58, typeSeat: "vip", statusSeat: "default" },
    { seatId: 59, typeSeat: "vip", statusSeat: "default" },
    { seatId: 60, typeSeat: "vip", statusSeat: "default" },
    { seatId: 61, typeSeat: "vip", statusSeat: "default" },
    { seatId: 62, typeSeat: "vip", statusSeat: "default" },
    { seatId: 63, typeSeat: "vip", statusSeat: "default" },
    { seatId: 64, typeSeat: "vip", statusSeat: "default" },
    { seatId: 65, typeSeat: "vip", statusSeat: "default" },
    { seatId: 66, typeSeat: "vip", statusSeat: "default" },
    { seatId: 67, typeSeat: "vip", statusSeat: "default" },
    { seatId: 68, typeSeat: "vip", statusSeat: "default" },
    { seatId: 69, typeSeat: "vip", statusSeat: "default" },
    { seatId: 70, typeSeat: "vip", statusSeat: "default" },
    { seatId: 71, typeSeat: "vip", statusSeat: "default" },
    { seatId: 72, typeSeat: "vip", statusSeat: "default" },
    { seatId: 73, typeSeat: "sweet-box", statusSeat: "banned" },
    { seatId: 74, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 75, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 76, typeSeat: "sweet-box", statusSeat: "picked" },
    { seatId: 77, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 78, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 79, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 80, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 81, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 82, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 83, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 84, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 85, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 86, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 87, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 88, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 89, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 90, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 91, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 92, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 93, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 94, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 95, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 96, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 97, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 98, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 99, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 100, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 101, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 102, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 103, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 104, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 105, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 106, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 107, typeSeat: "sweet-box", statusSeat: "default" },
    { seatId: 108, typeSeat: "sweet-box", statusSeat: "default" },
  ]);

  const [pickingSeatsCount, setPickingSeatsCount] = useState<number>(0);

  return (
    <Container className="my-[80px]">
      {isLoading ? (
        <div className="flex justify-center">
          <CircularProgress />
          <p>Loading...</p>
        </div>
      ) : (
        <div>
          <EventDescription event={event} seatsList={seatsList} setSeatsList={setSeatsList} />
          <SeatDescription />
          <SeatsList
            seatsList={seatsList}
            setSeatsList={setSeatsList}
            pickingSeatsCount={pickingSeatsCount}
            setPickingSeatsCount={setPickingSeatsCount}
          />
        </div>
      )}
    </Container>
  );
};

export default EventDetailPage;
