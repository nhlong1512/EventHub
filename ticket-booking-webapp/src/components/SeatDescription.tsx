import React from "react";

const SeatDescription = () => {
  return (
    <div className="my-[80px] flex justify-between">
      <div className="flex gap-[36px]">
        <div className="flex items-center gap-[12px]">
          <div
            className="w-[40px] h-[40px] bg-[#88050c] text-[#fff] border-[2px] 
        rouned-[2px] border-solid border-[#88050c] flex justify-center items-center 
        cursor-pointer hover:opacity-80 picked"
          ></div>
          <p className="m-0 text-[18px]">Picking</p>
        </div>
        <div className="flex items-center gap-[12px]">
          <div
            className="w-[40px] h-[40px] border-[#ccc] border-[2px] border-solid
         rouned-[2px] flex justify-center items-center cursor-pointer 
         hover:opacity-80 picked"
          ></div>
          <p className="m-0 text-[18px]">Picked</p>
        </div>
        <div className="flex items-center gap-[12px]">
          <div
            className="w-[40px] h-[40px] border-[#ccc] border-[2px] border-solid 
        rouned-[2px] flex justify-center items-center cursor-pointer hover:opacity-80 
        banned"
          >
            <p className="m-0 text-[24px]">X</p>
          </div>
          <p className="m-0 text-[18px]">Banned</p>
        </div>
      </div>

      <div className="flex gap-[36px]">
        <div className="flex items-center gap-[12px]">
          <div
            className="w-[40px] h-[40px] border-main border-[2px] border-solid
         rouned-[2px] flex justify-center items-center cursor-pointer hover:opacity-80"
          ></div>
          <p className="m-0 text-[18px]">Standard</p>
        </div>
        <div className="flex items-center gap-[12px]">
          <div
            className="w-[40px] h-[40px] border-[#e50914] text-[#000] 
        border-[2px] border-solid rouned-[2px] flex justify-center items-center 
        cursor-pointer hover:opacity-80 active"
          ></div>
          <p className="m-0 text-[18px]">VIP</p>
        </div>
        <div className="flex items-center gap-[12px]">
          <div
            className="w-[40px] h-[40px] border-[2px] border-solid border-[#ee7a7a] 
        bg-[#ee7a7a] text-[#fff] rouned-[2px] flex justify-center items-center 
        cursor-pointer hover:opacity-80 active"
          ></div>
          <p className="m-0 text-[18px]">Sweet Box</p>
        </div>
      </div>
    </div>
  );
};

export default SeatDescription;
