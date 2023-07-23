import { clsx } from "clsx";
import React from "react";

interface Props {
  typeSeat: string;
  statusSeat: string;
  seatId: number;
}

const Seat = ({ typeSeat, statusSeat, seatId }: Props) => {
  if (statusSeat === "banned") {
    return (
      <div className="w-[40px] h-[40px] border-[#ccc] border-[2px] border-solid rouned-[2px] flex justify-center items-center cursor-pointer hover:opacity-80 banned">
        <p className="m-0 text-[24px]">X</p>
      </div>
    );
  }
  if (statusSeat === "picked") {
    return (
      <div className="w-[40px] h-[40px] border-[#ccc] border-[2px] border-solid rouned-[2px] flex justify-center items-center cursor-pointer hover:opacity-80 picked">
        <p className="m-0">{seatId}</p>
      </div>
    );
  }
  if(statusSeat === "picking"){
    return (
      <div className="w-[40px] h-[40px] bg-[#88050c] text-[#fff] border-[2px] rouned-[2px] border-solid border-[#88050c] flex justify-center items-center cursor-pointer hover:opacity-80 picked">
        <p className="m-0">{seatId}</p>
      </div>
    );
  }
  if (statusSeat === "none") {
    if (typeSeat === "standard") {
      return (
        <div className="w-[40px] h-[40px] border-main border-[2px] border-solid rouned-[2px] flex justify-center items-center cursor-pointer hover:opacity-80">
          <p className="m-0">{seatId}</p>
        </div>
      );
    }
    if (typeSeat === "vip") {
      return (
        <div className="w-[40px] h-[40px] border-[#e50914] text-[#000] border-[2px] border-solid rouned-[2px] flex justify-center items-center cursor-pointer hover:opacity-80 active">
          <p className="m-0">{seatId}</p>
        </div>
      );
    }
    if (typeSeat === "sweet-box") {
      return (
        <div className="w-[40px] h-[40px] border-[2px] border-solid border-[#ee7a7a] bg-[#ee7a7a] text-[#fff] rouned-[2px] flex justify-center items-center cursor-pointer hover:opacity-80 active">
          <p className="m-0">{seatId}</p>
        </div>
      );
    }
  }
  return (
    <div className="w-[40px] h-[40px] border-green border-[2px] border-solid rouned-[2px] flex justify-center items-center cursor-pointer hover:opacity-80">
      <p className="m-0">None</p>
    </div>
  );
};

export default Seat;
