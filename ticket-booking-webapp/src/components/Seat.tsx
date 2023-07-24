import React from "react";
import classNames from "classnames";
import { ISeatEvent } from "../models/ISeat";
import { Alert } from "@mui/material";

interface Props {
  typeSeat: number;
  seatStatus: number;
  seatId: string;
  seatsList: ISeatEvent[];
  setSeatsList: (seatsList: ISeatEvent[]) => void;
  pickingSeatsCount: number;
  setPickingSeatsCount: (pickingSeatsCount: number) => void;
}

const Seat = ({
  typeSeat,
  seatStatus,
  seatId,
  seatsList,
  setSeatsList,
  pickingSeatsCount,
  setPickingSeatsCount,
}: Props) => {
  const handleClickSeat = () => {
    const seatPickingIndex = seatsList.findIndex(
      (seat) => seat.seatId === seatId
    );
    //Update SeatsList status picking
    if (seatPickingIndex === -1) {
      return;
    }
    const updatedSeats = [...seatsList];
    if (
      updatedSeats[seatPickingIndex].seatStatus === 1 ||
      updatedSeats[seatPickingIndex].seatStatus === 2
    ) {
      return;
    }
    if (updatedSeats[seatPickingIndex].seatStatus === -1) {
      updatedSeats[seatPickingIndex].seatStatus = 0;
      setPickingSeatsCount(pickingSeatsCount - 1);
    } else if (pickingSeatsCount < 3) {
      updatedSeats[seatPickingIndex].seatStatus = -1;
      setPickingSeatsCount(pickingSeatsCount + 1);
    } else {
      alert("You cannot select more than 3 tickets!");
      return;
    }
    setSeatsList(updatedSeats);
  };

  
  return (
    <div
      className={classNames(
        "w-[40px] h-[40px] border-[2px] border-solid rouned-[2px] flex justify-center items-center cursor-pointer hover:opacity-80",
        {
          "bg-[#ccc] border-[#ccc] text-[#fff]":
            seatStatus === 2 || seatStatus === 1,
          "bg-[#88050c] border-[#88050c] text-[#fff]": seatStatus === -1,
          "border-main": seatStatus === 0 && typeSeat === 0,
          "border-[#e50914]": seatStatus === 0 && typeSeat === 1,
          "border-[#ee7a7a] bg-[#ee7a7a] text-[#fff]":
            seatStatus === 0 && typeSeat === 2,
        }
      )}
      onClick={handleClickSeat}
    >
      <p
        className={classNames("m-0", {
          "text-[24px]": seatStatus === 2,
        })}
      >
        {seatStatus === 2 ? "X" : seatId}
      </p>
    </div>
  );
};

export default Seat;
