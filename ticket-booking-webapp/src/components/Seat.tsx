import React from "react";
import classNames from "classnames";

interface Props {
  typeSeat: string;
  statusSeat: string;
  seatId: number;
}

const Seat = ({ typeSeat, statusSeat, seatId }: Props) => {
  return (
    <div
      className={classNames(
        "w-[40px] h-[40px] border-[2px] border-solid rouned-[2px] flex justify-center items-center cursor-pointer hover:opacity-80",
        {
          "bg-[#ccc] border-[#ccc] text-[#fff]": statusSeat === "banned" || statusSeat === "picked",
          "bg-[#88050c] border-[#88050c] text-[#fff]": statusSeat ==="picking",
          "border-main": statusSeat ==="default" && typeSeat ==="standard",
          "border-[#e50914]": statusSeat ==="default" && typeSeat ==="vip",
          "border-[#ee7a7a] bg-[#ee7a7a] text-[#fff]": statusSeat ==="default" && typeSeat ==="sweet-box",

        }
      )}
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
