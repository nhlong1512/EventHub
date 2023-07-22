import React from "react";

const EventDescription = () => {
  return (
    <div className="mt-[80px] flex gap-[50px] p-[20px] rounded-[20px] border-[#ccc] border-solid border-[4px]">
      <div className="flex flex-row flex-[7] gap-[16px]">
        <div>
          <img src={require("../assets/images/eventImg.jpg")} alt="event" className="w-[200px] h-full" />
        </div>
        <div className="flex flex-col">
          <h3 className="my-0 text-[24px]">{`[MÂY LANG THANG HÀ NỘI] LIVESHOW TUẤN NGỌC - LƯU BÍCH`}</h3>
          <p className="my-0 text-[18px] font-[700]">
            Sunday, 13 August 2023 (07:30 PM - 09:30 PM)
          </p>
          <div className="flex flex-col gap-[6px]">
            <p className="my-0 text-[18px] font-[700]">RẠP ĐẠI NAM</p>
            <p className="my-0">
              89 Phố Huế, Ngô Thì Nhậm, Hai Bà Trưng, Hà Nội
            </p>
          </div>
        </div>
      </div>
      <div className="flex flex-[2] flex-col">
        <div className="flex flex-col gap-[16px]">
          <div className="flex justify-between">
            <p className="my-0">Standard</p>
            <p className="my-0">100.000 x 1</p>
          </div>
          <div className="flex justify-between">
            <p className="my-0">VIP </p>
            <p className="my-0">200.000 x 2</p>
          </div>
        </div>
        <div className="flex justify-between">
          <h3>Total</h3>
          <h3>500.000 đ</h3>
        </div>
      </div>
    </div>
  );
};

export default EventDescription;
