import {
  Box,
  Button,
  Chip,
  Container,
  FormControl,
  InputLabel,
  MenuItem,
  OutlinedInput,
  Select,
  SelectChangeEvent,
  TextField,
  ThemeProvider,
} from "@mui/material";
import { createTheme } from "@mui/material/styles";
import { DatePicker } from "@mui/x-date-pickers";
import { ChangeEvent, useRef, useState } from "react";

const initEventTypes = [
  "Live Music",
  "Art & Culture",
  "Theater & Plays",
  "Nightlife",
  "Outdoor",
  "Conference",
  "Seminar/Courses",
  "Exhibitions",
  "Meetups",
  "Sports",
  "Community",
  "Attractions",
];

const ITEM_HEIGHT = 48;
const ITEM_PADDING_TOP = 8;

const MenuProps = {
  PaperProps: {
    style: {
      maxHeight: ITEM_HEIGHT * 4.5 + ITEM_PADDING_TOP,
      width: 250,
    },
  },
};
const theme = createTheme({
  palette: {
    primary: {
      main: "#5669FF",
    },
  },
});

const CreateEventPage = () => {
  const [city, setCity] = useState<string>("");
  const [eventTypes, setEventTypes] = useState<string[]>([]);

  const handleChangeCity = (event: SelectChangeEvent) => {
    setCity(event.target.value);
  };

  const handleChangeEventType = (
    event: SelectChangeEvent<typeof eventTypes>
  ) => {
    const {
      target: { value },
    } = event;
    setEventTypes(
      // On autofill we get a stringified value.
      typeof value === "string" ? value.split(",") : value
    );
  };

  //Handle upload file image
  const [selectedImage, setSelectedImage] = useState<File>();

  const handleFileChange = (e: ChangeEvent<HTMLInputElement>) => {
    if (e.target.files) {
      console.log(e.target.files[0]);
      setSelectedImage(e.target.files[0]);
    }
  };

  return (
    <Container className="mt-[80px] mb-[80px]">
      {/* <h3 className="text-main text-[50px] leading-[60px] mb-[80px]">Create new event</h3> */}
      <div className="flex flex-row">
        <div className="flex flex-[7] flex-col gap-[40px]">
          <div className="flex items-center justify-between">
            <p className="my-0 text-[20px]">Title</p>
            <ThemeProvider theme={theme}>
              <TextField
                label="Title"
                variant="outlined"
                style={{ width: "400px" }}
              />
            </ThemeProvider>
          </div>
          <div className="flex items-center justify-between">
            <p className="my-0 text-[20px]">From Price</p>
            <ThemeProvider theme={theme}>
              <TextField
                label="From Price"
                variant="outlined"
                style={{ width: "400px" }}
              />
            </ThemeProvider>
          </div>
          <div className="flex items-center justify-between">
            <p className="my-0 text-[20px]">Location</p>
            <ThemeProvider theme={theme}>
              <TextField
                label="Location"
                variant="outlined"
                style={{ width: "400px" }}
              />
            </ThemeProvider>
          </div>
          <div className="flex items-center justify-between">
            <p className="my-0 text-[20px]">Event Date</p>
            <ThemeProvider theme={theme}>
              <DatePicker className="w-[400px]" />
            </ThemeProvider>
          </div>
          <div className="flex items-center justify-between">
            <p className="my-0 text-[20px]">City</p>
            <ThemeProvider theme={theme}>
              <FormControl className="w-[400px]">
                <InputLabel id="city-select-label">City</InputLabel>
                <Select
                  labelId="city-select-label"
                  id="city-select"
                  value={city}
                  label="City"
                  onChange={handleChangeCity}
                >
                  <MenuItem value={1}>Ha Noi</MenuItem>
                  <MenuItem value={2}>Ho Chi Minh</MenuItem>
                  <MenuItem value={3}>Da Nang</MenuItem>
                </Select>
              </FormControl>
            </ThemeProvider>
          </div>
          <div className="flex items-center justify-between">
            <p className="my-0 text-[20px]">Event Type</p>
            <ThemeProvider theme={theme}>
              <FormControl className="w-[400px]">
                <InputLabel id="event-type-select-label">Event Type</InputLabel>
                <Select
                  labelId="event-type-select-label"
                  id="event-type-select"
                  label="Event Type"
                  multiple
                  value={eventTypes}
                  onChange={handleChangeEventType}
                  input={
                    <OutlinedInput id="select-multiple-chip" label="Chip" />
                  }
                  renderValue={(selected) => (
                    <Box sx={{ display: "flex", flexWrap: "wrap", gap: 0.5 }}>
                      {selected.map((value) => (
                        <Chip key={value} label={value} />
                      ))}
                    </Box>
                  )}
                  MenuProps={MenuProps}
                >
                  {initEventTypes.map((eventType, eventIndex) => (
                    <MenuItem key={eventType} value={eventType}>
                      {eventType}
                    </MenuItem>
                  ))}
                </Select>
              </FormControl>
            </ThemeProvider>
          </div>
        </div>
        <div className="flex-[1]"></div>

        <div className="flex flex-col items-start flex-[4] self-start gap-[40px]">
          <ThemeProvider theme={theme}>
            <Button
              variant="contained"
              component="label"
              // onClick={handleUploadClick}
            >
              Upload File
              <input
                type="file"
                id="imgUploadLabel"
                hidden
                onChange={handleFileChange}
              />
            </Button>
          </ThemeProvider>
          {selectedImage && (
            <div className="w-full">
              <label htmlFor="imgUploadLabel" className="w-full">
                <img
                  alt="imageUpload"
                  className="w-full cursor-pointer hover:opacity-80"
                  style={{
                    boxShadow:
                      "rgba(0, 0, 0, 0.19) 0px 10px 20px, rgba(0, 0, 0, 0.23) 0px 6px 6px",
                  }}
                  src={URL.createObjectURL(selectedImage)}
                />
              </label>
            </div>
          )}
        </div>
      </div>
    </Container>
  );
};

export default CreateEventPage;
