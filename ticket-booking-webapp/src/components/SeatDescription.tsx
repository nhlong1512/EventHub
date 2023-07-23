import classNames from "classnames";

interface PropsASeatDescription {
  typeSeat: string;
  statusSeat: string;
}

const ASeatDescription = ({ typeSeat, statusSeat }: PropsASeatDescription) => {
  return (
    <div className="flex items-center gap-[12px]">
      <div
        className={classNames(
          "w-[40px] h-[40px] border-[2px] rouned-[2px] border-solid flex justify-center items-center cursor-pointer hover:opacity-80",
          {
            "bg-[#88050c] border-[#88050c] text-[#fff]":
              statusSeat === "picking",
            "bg-[#ccc] border-[#ccc] text-[#fff]":
              statusSeat === "banned" || statusSeat === "picked",
            "border-main": statusSeat === "default" && typeSeat === "standard",
            "border-[#e50914]": statusSeat === "default" && typeSeat === "vip",
            "border-[#ee7a7a] bg-[#ee7a7a] text-[#fff]":
              statusSeat === "default" && typeSeat === "sweet-box",
          }
        )}
      >
        {statusSeat === "banned" ? <p className="text-[20px]">X</p> : ""}
      </div>
      <p className="m-0 text-[18px]">
        {statusSeat === "picking"
          ? "Picking"
          : statusSeat === "banned"
          ? "Banned"
          : statusSeat === "picked"
          ? "Picked"
          : typeSeat === "standard"
          ? "Standard"
          : typeSeat === "vip"
          ? "VIP"
          : typeSeat === "sweet-box"
          ? "Sweet Box"
          : ""}
      </p>
    </div>
  );
};

const SeatDescription = () => {
  return (
    <div className="my-[80px] flex justify-between">
      <div className="flex gap-[36px]">
        <ASeatDescription typeSeat="vip" statusSeat="picking" />
        <ASeatDescription typeSeat="vip" statusSeat="picked" />
        <ASeatDescription typeSeat="vip" statusSeat="banned" />
      </div>
      <div className="flex gap-[36px]">
        <ASeatDescription typeSeat="standard" statusSeat="default" />
        <ASeatDescription typeSeat="vip" statusSeat="default" />
        <ASeatDescription typeSeat="sweet-box" statusSeat="default" />
      </div>
    </div>
  );
};

export default SeatDescription;
