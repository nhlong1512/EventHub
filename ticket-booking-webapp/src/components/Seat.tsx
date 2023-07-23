import React from "react";
import classNames from "classnames";
import { ISeat } from "../models/ISeat";
import { Alert } from "@mui/material";

interface Props {
  typeSeat: string;
  statusSeat: string;
  seatId: number;
  seatsList: ISeat[];
  setSeatsList: (seatsList: ISeat[]) => void;
  pickingSeatsCount: number;
  setPickingSeatsCount: (pickingSeatsCount: number) => void;
}

const Seat = ({
  typeSeat,
  statusSeat,
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
      updatedSeats[seatPickingIndex].statusSeat === "picked" ||
      updatedSeats[seatPickingIndex].statusSeat === "banned"
    ) {
      return;
    }
    if (updatedSeats[seatPickingIndex].statusSeat === "picking") {
      updatedSeats[seatPickingIndex].statusSeat = "default";
      setPickingSeatsCount(pickingSeatsCount - 1);
    } else if (pickingSeatsCount < 3) {
      updatedSeats[seatPickingIndex].statusSeat = "picking";
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
            statusSeat === "banned" || statusSeat === "picked",
          "bg-[#88050c] border-[#88050c] text-[#fff]": statusSeat === "picking",
          "border-main": statusSeat === "default" && typeSeat === "standard",
          "border-[#e50914]": statusSeat === "default" && typeSeat === "vip",
          "border-[#ee7a7a] bg-[#ee7a7a] text-[#fff]":
            statusSeat === "default" && typeSeat === "sweet-box",
        }
      )}
      onClick={handleClickSeat}
    >
      <p
        className={classNames("m-0", {
          "text-[24px]": statusSeat === "banned",
        })}
      >
        {statusSeat === "banned" ? "X" : seatId}
      </p>
    </div>
  );
};

export default Seat;
