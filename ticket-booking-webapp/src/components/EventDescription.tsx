import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogContentText,
  DialogTitle,
  TextField,
} from "@mui/material";
import React, { useEffect, useState } from "react";
import { createTheme, ThemeProvider } from "@mui/material/styles";
import { ISeat } from "../models/ISeat";
import { VND } from "../utils/convertVND";

interface Props {
  seatsList: ISeat[];
  setSeatsList: (seatsList: ISeat[]) => void;
}

const PRICE_STANDARD = 100000;
const PRICE_VIP = 200000;
const PRICE_SWEET_BOX = 300000;


const theme = createTheme({
  palette: {
    primary: {
      main: "#5669FF",
    },
  },
});

const EventDescription = ({ seatsList, setSeatsList }: Props) => {
  const [open, setOpen] = React.useState(false);
  const handleClose = () => setOpen(false);
  const [seatsPicking, setSeatsPicking] = useState<ISeat[]>([]); // [10, 23, 49
  const [seatsNumber, setSeatsNumber] = useState<string>("");
  const handleClickPaymentBtn = () => {
    setOpen(true);
  };

  const fetchPaymentPicking = () => {
    const seats = seatsList.filter((seat) => seat.statusSeat === "picking");
    setSeatsNumber(seats.map((seat) => seat.seatId).join(", "));
    setSeatsPicking(seats);
  };
  useEffect(() => {
    fetchPaymentPicking();
  }, [seatsList]);

  //Calculate total price
  const totalTickets = seatsPicking.length;
  const totalPrice = seatsPicking.reduce((total, seat) => {
    switch (seat.typeSeat) {
      case "standard":
        return total + PRICE_STANDARD;
      case "vip":
        return total + PRICE_VIP;
      case "sweet-box":
        return total + PRICE_SWEET_BOX;
      default:
        return total;
    }
  }, 0);

  return (
    <div className="mt-[80px] flex gap-[50px] p-[20px] rounded-[20px] border-[#ccc] border-solid border-[4px] min-h-[230px]">
      <div className="flex flex-row flex-[7] gap-[16px]">
        <div>
          <img
            src={require("../assets/images/eventImg.jpg")}
            alt="event"
            className="w-[200px] h-full"
          />
        </div>
        <div className="flex flex-col justify-between">
          <h3 className="my-0 text-[24px]">{`[MÂY LANG THANG HÀ NỘI] LIVESHOW TUẤN NGỌC - LƯU BÍCH`}</h3>
          <div className="flex flex-col">
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
      </div>
      <div className="flex flex-[2] flex-col">
        <div className="flex flex-col gap-[16px]">
          {seatsPicking.map((seat) => (
            <div key={seat.seatId} className="flex justify-between">
              <p className="my-0">
                {seat.typeSeat === "standard"
                  ? `Standard ${`(${seat.seatId})`}`
                  : seat.typeSeat === "vip"
                  ? `VIP ${`(${seat.seatId})`}`
                  : `Sweet Box ${`(${seat.seatId})`}`}
              </p>
              <p className="my-0">
                {seat.typeSeat === "standard"
                  ? VND.format(PRICE_STANDARD)
                  : seat.typeSeat === "vip"
                  ? VND.format(PRICE_VIP)
                  : VND.format(PRICE_SWEET_BOX)}{" "}
                x 1
              </p>
            </div>
          ))}
        </div>
        {totalTickets > 0 ? (
          <div className="flex justify-between my-[16px]">
            <h3 className="my-0">Total</h3>
            <h3 className="my-0">{VND.format(totalPrice)}</h3>
          </div>
        ) : (
          ""
        )}
        <p className="my-0 mb-[16px]">
          (Number of tickets booked: {totalTickets}/3)
        </p>
        <ThemeProvider theme={theme}>
          {totalTickets > 0 ? (
            <Button
              variant="contained"
              component="label"
              className="rounded-[10px]"
              onClick={handleClickPaymentBtn}
            >
              Payment
            </Button>
          ) : (
            ""
          )}
          <Dialog open={open} onClose={handleClose}>
            <DialogTitle
              className="text-main"
              style={{ color: "#5669FF", fontSize: "24px" }}
            >
              Confirmation Payment
            </DialogTitle>
            <DialogContent
              style={{
                height: "100%",
                position: "relative",
                display: "flex",
                flexDirection: "column",
              }}
            >
              <DialogContentText>
                Please provide the required information for payment
                confirmation.
              </DialogContentText>
              <div
                style={{
                  display: "flex",
                  justifyContent: "center",
                  alignItems: "end",
                }}
              >
                <p style={{ flex: 2, margin: "0", fontSize: "18px" }}>
                  Full name:{" "}
                </p>
                <TextField
                  autoFocus
                  margin="dense"
                  id="name"
                  label="Full name"
                  type="text"
                  fullWidth
                  variant="standard"
                  style={{ flex: 4, margin: "0" }}
                />
              </div>
              <div
                style={{
                  display: "flex",
                  justifyContent: "center",
                  alignItems: "end",
                  marginTop: "12px",
                }}
              >
                <p style={{ flex: 2, margin: "0", fontSize: "18px" }}>
                  Phone number:{" "}
                </p>
                <TextField
                  autoFocus
                  margin="dense"
                  id="phone"
                  label="Phone number"
                  type="number"
                  fullWidth
                  variant="standard"
                  style={{ flex: 4, margin: "0" }}
                />
              </div>
              <div
                style={{
                  display: "flex",
                  justifyContent: "center",
                  alignItems: "end",
                  marginTop: "12px",
                }}
              >
                <p style={{ flex: 2, margin: "0", fontSize: "18px" }}>
                  Email:{" "}
                </p>
                <TextField
                  autoFocus
                  margin="dense"
                  id="phone"
                  label="Email"
                  type="email"
                  fullWidth
                  variant="standard"
                  style={{ flex: 4, margin: "0" }}
                />
              </div>
              <div
                style={{
                  display: "flex",
                  justifyContent: "center",
                  alignItems: "end",
                  marginTop: "12px",
                }}
              >
                <p style={{ flex: 2, margin: "0", fontSize: "18px" }}>
                  Event name:{" "}
                </p>
                <TextField
                  autoFocus
                  margin="dense"
                  id="phone"
                  label="Event name"
                  type="text"
                  defaultValue="[MÂY LANG THANG HÀ NỘI] LIVESHOW TUẤN NGỌC - LƯU BÍCH"
                  InputProps={{
                    readOnly: true,
                  }}
                  fullWidth
                  variant="standard"
                  style={{ flex: 4, margin: "0" }}
                />
              </div>
              <div
                style={{
                  display: "flex",
                  justifyContent: "center",
                  alignItems: "end",
                  marginTop: "12px",
                }}
              >
                <p style={{ flex: 2, margin: "0", fontSize: "18px" }}>
                  Seats:{" "}
                </p>
                <TextField
                  autoFocus
                  margin="dense"
                  id="text"
                  label="Seats"
                  type="text"
                  defaultValue={seatsNumber}
                  InputProps={{
                    readOnly: true,
                  }}
                  fullWidth
                  variant="standard"
                  style={{ flex: 4, margin: "0" }}
                />
              </div>
            </DialogContent>
            <DialogActions>
              <Button onClick={handleClose}>Cancel</Button>
              <Button onClick={handleClose}>Submit</Button>
            </DialogActions>
          </Dialog>
        </ThemeProvider>
      </div>
    </div>
  );
};

export default EventDescription;
