import * as React from "react";
import Card from "@mui/material/Card";
import CardContent from "@mui/material/CardContent";
import CardMedia from "@mui/material/CardMedia";
import Typography from "@mui/material/Typography";
import { CardActionArea } from "@mui/material";
import { SlCalender } from "react-icons/sl";

const CardEvent = () => {
  return (
    <Card sx={{ maxWidth: 345 }}>
      <CardActionArea>
        <CardMedia
          component="img"
          height="140"
          image={require("../assets/images/eventImg.jpg")}
          alt="green iguana"
        />
        <CardContent>
          <Typography
            gutterBottom
            variant="h5"
            component="div"
            className="text-[18px] font-[500] leading-[24px] h-[72px] hover:text-main"
          >
            {`[MÂY LANG THANG HÀ NỘI] LIVESHOW TUẤN NGỌC - LƯU BÍCH`}
          </Typography>
          <div className="flex justify-between">
            <Typography variant="body2" color="text.secondary">
              From <span className="text-main font-[700]">500,000 VND</span>
            </Typography>
            <div className="flex gap-[6px] items-center">
              <SlCalender className="w-[16px] h-[16px] text-main" />
              <Typography variant="body2" color="text.secondary">
                13.08.2023
              </Typography>
            </div>
          </div>
          <div className="flex mt-[12px] justify-between items-center">
            <div className="flex">
              <Typography
                color="text.secondary"
                className="pr-[10px] text-[12px]"
              >
                Live Music
              </Typography>
              <Typography
                variant="body2"
                color="text.secondary"
                className="pr-[10px] text-[12px]"
              >
                Theater & Plays
              </Typography>
            </div>
            <div style={{border:'1px solid #ccc'}} className="border-2 border-[#333] px-[4px] py-[2px] rounded-[2px]">
              <Typography
                variant="body2"
                color="text.secondary"
                className="text-[10px]"
              >
                HO CHI MINH
              </Typography>
            </div>
          </div>
        </CardContent>
      </CardActionArea>
    </Card>
  );
};
export default CardEvent;
