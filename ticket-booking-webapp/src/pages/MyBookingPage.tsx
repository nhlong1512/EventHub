import { Container } from "@mui/material";
import React from "react";
import { BiSolidMap, BiTimeFive } from "react-icons/bi";
import { formatDateEventDetail } from "../utils/convertDateEvent";

const MyBookingPage = () => {
  return (
    <Container className="mt-[80px] mb-[80px]">
        MyBookingPage
      {/* <div className="mt-[80px] flex gap-[50px] p-[20px] rounded-[20px] border-[#ccc] border-solid border-[4px] min-h-[230px]">
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
                  {`${formatDateEventDetail(event.date)} (${event.duration})`}
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
            {seatsPicking.map((seat) => (
              <div key={seat.seatId} className="flex justify-between">
                <p className="my-0">
                  {seat.seat.type === 0
                    ? `Standard ${`(${seat.seatId})`}`
                    : seat.seat.type === 1
                    ? `VIP ${`(${seat.seatId})`}`
                    : `Sweet Box ${`(${seat.seatId})`}`}
                </p>
                <p className="my-0">{seat.price.toLocaleString()} x 1</p>
              </div>
            ))}
          </div>
          {totalTickets > 0 ? (
            <div className="flex justify-between my-[16px]">
              <h3 className="my-0">Total</h3>
              <h3 className="my-0">{`${totalPrice.toLocaleString()} VND`}</h3>
            </div>
          ) : (
            ""
          )}
          <p className="my-0 mb-[16px]">
            (Number of tickets booked: {totalTickets}/3)
          </p>
        </div>
      </div> */}
    </Container>
  );
};

export default MyBookingPage;
