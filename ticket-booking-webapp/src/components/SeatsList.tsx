import { useState } from "react";
import { ISeat } from "../models/ISeat";
import Seat from "./Seat";

interface Props {
  seatsList: ISeat[];
  setSeatsList: (seatsList: ISeat[]) => void;
  pickingSeatsCount: number;
  setPickingSeatsCount: (pickingSeatsCount: number) => void;
}

const SeatsList = ({seatsList, setSeatsList, pickingSeatsCount, setPickingSeatsCount}: Props) => {
  return (
    <div className="flex gap-[20px] flex-wrap justify-center">
      {seatsList.map((seat, seatIndex) => (
        <Seat
          key={seat.seatId}
          seatId={seat.seatId}
          typeSeat={seat.typeSeat}
          statusSeat={seat.statusSeat}
          seatsList = {seatsList}
          setSeatsList = {setSeatsList}
          pickingSeatsCount = {pickingSeatsCount}
          setPickingSeatsCount = {setPickingSeatsCount}
        />
      ))}
    </div>
  );
};

export default SeatsList;
