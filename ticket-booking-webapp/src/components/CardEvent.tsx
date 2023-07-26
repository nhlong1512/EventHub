import * as React from "react";
import Card from "@mui/material/Card";
import CardContent from "@mui/material/CardContent";
import CardMedia from "@mui/material/CardMedia";
import Typography from "@mui/material/Typography";
import { CardActionArea } from "@mui/material";
import { SlCalender } from "react-icons/sl";
import { IEvent } from "../Dto/IEvents";
import { VND } from "../utils/convertVND";
import { formatDate } from "../utils/convertDateEvent";

interface Props {
  event: IEvent;
}
const CardEvent = ({ event }: Props) => {
  return (
    <Card sx={{ maxWidth: 345 }}>
      <CardActionArea>
        <CardMedia
          component="img"
          height="140"
          image={event.image}
          alt="green iguana"
        />
        <CardContent>
          <Typography
            gutterBottom
            variant="h5"
            component="div"
            className="text-[18px] font-[500] leading-[24px] h-[72px] hover:text-main uppercase"
          >
            {event.title}
          </Typography>
          <div className="flex justify-between gap-[20px]">
            <Typography variant="body2" color="text.secondary">
              From{" "}
              <span className="text-main font-[700]">{`${event.minPrice.toLocaleString()} VND`}</span>
            </Typography>
            <div className="flex gap-[6px] items-center">
              <SlCalender className="w-[16px] h-[16px] text-main" />
              <Typography variant="body2" color="text.secondary">
                {/* 13.08.2023  */}
                {formatDate(event.date)}
              </Typography>
            </div>
          </div>
          <div className="flex mt-[12px] justify-between items-center">
            <div className="flex">
              {event.categories.map((category, categoryIndex) => (
                <Typography
                  key={category.id}
                  color="text.secondary"
                  className="pr-[10px] text-[12px]"
                >
                  {category.name}
                </Typography>
              ))}
            </div>
            {event.city ? (
              <div
                style={{ border: "1px solid #ccc" }}
                className="border-2 border-[#333] px-[4px] py-[2px] rounded-[2px]"
              >
                <Typography
                  variant="body2"
                  color="text.secondary"
                  className="text-[10px]"
                >
                  {event.city}
                </Typography>
              </div>
            ) : (
              ""
            )}
          </div>
        </CardContent>
      </CardActionArea>
    </Card>
  );
};
export default CardEvent;
