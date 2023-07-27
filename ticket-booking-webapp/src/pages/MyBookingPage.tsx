import { CircularProgress, Container } from "@mui/material";
import React, { useEffect, useState } from "react";
import { BiSolidMap, BiTimeFive } from "react-icons/bi";
import shallow from "zustand/shallow";
import api from "../api";
import { IEvent, IEventBooking, ISeatBooking } from "../Dto/IEvent";
import { ISeatEvent } from "../Dto/ISeat";
import { useEmailStore } from "../store/email";
import { formatDateEventDetail } from "../utils/convertDateEvent";

const MyBookingPage = () => {
  // const email = `huulongn15@gmail.com`;
  const [emailStore, setEmailStore] = useEmailStore(
    (state) => [state.emailStore, state.setEmailStore],
    shallow
  );

  
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [eventsBooking, setEventsBooking] = useState<IEventBooking[]>([]);


  const fetchBookingByEmail = async () => {
    try {
      setIsLoading(true);
      const response = await api.get(`/Invoice/${emailStore}`, {
        headers: {
          "ngrok-skip-browser-warning": "true",
        },
      });
      console.log(response);
      if (response.data) {
        setEventsBooking(response.data);
      }
    } catch (error) {
      console.error("Error fetching data:", error);
    } finally {
      setIsLoading(false);
    }
  };

  useEffect(() => {
    fetchBookingByEmail();
  }, []);

  const getTotalPrice = (seatsPicked: ISeatBooking[]) => {
    let totalPrice = 0;
    seatsPicked.forEach((seat) => {
      totalPrice += seat.price;
    });
    return totalPrice;
  };

  // console.log(getTotalPrice(eventsBooking[0].seats));

  return (
    <Container className="mt-[80px] mb-[80px]">
      {isLoading ? (
        <div className="flex justify-center">
          <CircularProgress />
          <p>Loading...</p>
        </div>
      ) : (
        <div>
          {eventsBooking.map((event) => (
            <div className="mt-[20px] flex gap-[50px] p-[20px] rounded-[20px] border-[#ccc] border-solid border-[4px] min-h-[230px]">
              <div className="flex flex-row flex-[7] gap-[16px]">
                <div>
                  <img
                    src={event.image}
                    alt="event"
                    className="w-[200px] h-full object-cover"
                  />
                </div>
                <div className="flex flex-col justify-between">
                  <h3 className="my-0 text-[24px]">{event.title}</h3>
                  <div className="flex flex-col">
                    <p className="my-0 text-[18px] font-[700] flex items-center mb-[8px] gap-[10px]">
                      <span className="flex items-center">
                        <BiTimeFive className="text-[#999]" />
                      </span>
                      <span>
                        {`${formatDateEventDetail(event.date)} (${
                          event.duration
                        })`}
                      </span>
                    </p>
                    <div className="flex items-center gap-[10px]">
                      <span className="flex items-center">
                        <BiSolidMap className="text-[#999] text-[20px]" />
                      </span>
                      <div className="flex flex-col gap-[6px]">
                        <p className="my-0 text-[18px] font-[700]">
                          {event.stageName}
                        </p>
                        <p className="my-0">{event.location}</p>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <div className="flex flex-[2] flex-col">
                <div className="flex flex-col gap-[16px]">
                  {event.seats.map((seat) => (
                    <div key={seat.name} className="flex justify-between">
                      <p className="my-0">
                        {seat.type === 0
                          ? `Standard ${`(${seat.name})`}`
                          : seat.type === 1
                          ? `VIP ${`(${seat.name})`}`
                          : `Sweet Box ${`(${seat.name})`}`}
                      </p>
                      <p className="my-0">{seat.price.toLocaleString()} x 1</p>
                    </div>
                  ))}
                </div>
                {getTotalPrice(event.seats) > 0 ? (
                  <div className="flex justify-between my-[16px]">
                    <h3 className="my-0">Total</h3>
                    <h3 className="my-0">{`${getTotalPrice(
                      event.seats
                    ).toLocaleString()} VND`}</h3>
                  </div>
                ) : (
                  ""
                )}
              </div>
            </div>
          ))}
        </div>
      )}
    </Container>
  );
};

export default MyBookingPage;
