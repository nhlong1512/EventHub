import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogContentText,
  DialogTitle,
  TextField,
} from "@mui/material";
import React, { useEffect } from "react";
import { createTheme, ThemeProvider } from "@mui/material/styles";
import { ISeat } from "../models/ISeat";


interface Props {
  seatsList: ISeat[];
  setSeatsList: (seatsList: ISeat[]) => void;
}


const theme = createTheme({
  palette: {
    primary: {
      main: "#5669FF",
    },
  },
});

const EventDescription = ({seatsList, setSeatsList}:Props) => {
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);
  const handleClickPaymentBtn = () => {
    setOpen(true);
  };
  
  const fetchPaymentPicking = () => {
    const seats = seatsList.filter((seat) => seat.statusSeat === "picking");
    console.log(seats);
  }
  useEffect(() => {
    fetchPaymentPicking();
  }, [seatsList])

  return (
    <div className="mt-[80px] flex gap-[50px] p-[20px] rounded-[20px] border-[#ccc] border-solid border-[4px]">
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
          <div className="flex justify-between">
            <p className="my-0">Standard (10)</p>
            <p className="my-0">100.000 x 1</p>
          </div>
          <div className="flex justify-between">
            <p className="my-0">VIP (23)</p>
            <p className="my-0">200.000 x 1</p>
          </div>
          <div className="flex justify-between">
            <p className="my-0">SweetBox (49)</p>
            <p className="my-0">300.000 x 1</p>
          </div>
        </div>
        <div className="flex justify-between my-[16px]">
          <h3 className="my-0">Total</h3>
          <h3 className="my-0">600.000 đ</h3>
        </div>
        <p className="my-0 mb-[16px]">(Number of tickets booked: 3/3)</p>
        <ThemeProvider theme={theme}>
          <Button
            variant="contained"
            component="label"
            className="rounded-[10px]"
            onClick={handleClickPaymentBtn}
          >
            Payment
          </Button>
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
                  defaultValue="10, 23, 49"
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
