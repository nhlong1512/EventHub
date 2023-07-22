import {
  Box,
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
import { useState } from "react";

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

const CreateEventPage = () => {
  const theme = createTheme({
    palette: {
      primary: {
        main: "#5669FF",
      },
    },
  });

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

  return (
    <Container className="mt-[80px] mb-[80px]">
      <div className="flex flex-col gap-[40px]">
        <div className="flex items-center gap-[60px]">
          <p className="my-0 text-[20px]">Title</p>
          <ThemeProvider theme={theme}>
            <TextField
              label="Title"
              variant="outlined"
              style={{ width: "360px" }}
            />
          </ThemeProvider>
        </div>
        <div className="flex items-center gap-[60px]">
          <p className="my-0 text-[20px]">From Price</p>
          <ThemeProvider theme={theme}>
            <TextField
              label="From Price"
              variant="outlined"
              style={{ width: "360px" }}
            />
          </ThemeProvider>
        </div>
        <div className="flex items-center gap-[60px]">
          <p className="my-0 text-[20px]">Location</p>
          <ThemeProvider theme={theme}>
            <TextField
              label="Location"
              variant="outlined"
              style={{ width: "360px" }}
            />
          </ThemeProvider>
        </div>
        <div className="flex items-center gap-[60px]">
          <p className="my-0 text-[20px]">Event Date</p>
          <ThemeProvider theme={theme}>
            <DatePicker className="w-[360px]" />
          </ThemeProvider>
        </div>
        <div className="flex items-center gap-[60px]">
          <p className="my-0 text-[20px]">City</p>
          <ThemeProvider theme={theme}>
            <FormControl className="w-[360px]">
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
        <div className="flex items-center gap-[60px]">
          <p className="my-0 text-[20px]">Event Type</p>
          <ThemeProvider theme={theme}>
            <FormControl className="w-[360px]">
              <InputLabel id="event-type-select-label">Event Type</InputLabel>
              <Select
                labelId="event-type-select-label"
                id="event-type-select"
                label="Event Type"
                multiple
                value={eventTypes}
                onChange={handleChangeEventType}
                input={<OutlinedInput id="select-multiple-chip" label="Chip" />}
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
    </Container>
  );
};

export default CreateEventPage;
