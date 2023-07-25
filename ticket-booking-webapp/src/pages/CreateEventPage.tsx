import {
  Alert,
  Box,
  Button,
  Chip,
  CircularProgress,
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
import FormData from "form-data";
import { createTheme, makeStyles } from "@mui/material/styles";
import { DatePicker } from "@mui/x-date-pickers";
import axios from "axios";
import { ChangeEvent, useEffect, useState } from "react";
import api from "../api";
import { PROVINCE_API } from "../config";
import { IProvince } from "../models/IProvince";
import { formatDateToStringCreateEvent } from "../utils/convertDateEvent";

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

const theme = createTheme({
  palette: {
    primary: {
      main: "#5669FF",
    },
  },
});

const CreateEventPage = () => {
  const [title, setTitle] = useState<string>("");
  const [standardPrice, setStandardPrice] = useState<number>(0);
  const [vipPrice, setVipPrice] = useState<number>(0);
  const [sweetboxPrice, setSweetboxPrice] = useState<number>(0);
  const [stageName, setStageName] = useState<string>("");
  const [location, setLocation] = useState<string>("");
  const [duration, setDuration] = useState<string>("");
  const [eventDate, setEventDate] = useState<Date>();
  const [city, setCity] = useState<string>("");
  const [eventTypes, setEventTypes] = useState<string[]>([]);

  const [provinces, setProvinces] = useState<IProvince[]>([]);
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [isPostSuccess, setIsPostSuccess] = useState<boolean>(false);

  const handleDateChange = (date: Date | null) => {
    if (date) {
      setEventDate(date);
    }
  };

  //Post Event
  const handleCreateEvent = async () => {
    if (!eventDate) return;
    console.log("title: ", title);
    console.log("standardPrice: ", standardPrice);
    console.log("vipPrice: ", vipPrice);
    console.log("sweetboxPrice: ", sweetboxPrice);
    console.log("stageName: ", stageName);
    console.log("location: ", location);
    console.log("duration: ", duration);
    console.log(
      "eventDate: ",
      formatDateToStringCreateEvent(eventDate.toISOString())
    );
    console.log("city: ", city);
    console.log("eventTypes: ", eventTypes);
    console.log("selectedImage: ", selectedImage);
    try {
      setIsLoading(true);
      const config = {
        headers: {
          "Content-Type": "multipart/form-data",
          "ngrok-skip-browser-warning": "true",
        },
      };
      let data = new FormData();
      if (!selectedImage) return;
      data.append("Image", selectedImage);
      data.append("Title", title);
      data.append("Duration", duration);
      data.append(
        "Date",
        formatDateToStringCreateEvent(eventDate.toISOString())
      );
      data.append("StageName", stageName);
      data.append("Location", location);
      data.append("City", city);
      eventTypes.forEach((eventType) => {
        data.append("Categories", eventType);
      });
      data.append("Prices", standardPrice);
      data.append("Prices", vipPrice);
      data.append("Prices", sweetboxPrice);
      const response = await api.post("/Event", data, config);
      console.log(response);
      setIsPostSuccess(true);
    } catch (error) {
      console.error("Error fetching data:", error);
    } finally {
      setIsLoading(false);
    }
  };

  //Fetch Provinces
  const fetchProvinces = async () => {
    try {
      setIsLoading(true);
      const response = await axios.get(PROVINCE_API);
      const newProvinces = response.data.map((province: IProvince) => {
        const newProvince = { ...province };
        newProvince.name = newProvince.name.replace("Tỉnh ", "");
        newProvince.name = newProvince.name.replace("Thành phố ", "");
        return newProvince;
      });
      setProvinces(newProvinces);
      //delete prefix tinh, thanh pho in province name
    } catch (error) {
      console.error("Error fetching data:", error);
    } finally {
      setIsLoading(false);
    }
  };
  useEffect(() => {
    fetchProvinces();
  }, []);

  const handleChangeCity = (event: SelectChangeEvent) => {
    setCity(event.target.value);
  };

  //Handle Change type Event
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
      if (!e.target.files[0]) return;
      console.log(e.target.files[0]);
      setSelectedImage(e.target.files[0]);
    }
  };

  return (
    <Container className="mt-[80px] mb-[80px]">
      {isPostSuccess && (
        <Alert severity="success" className="mb-[20px]">
          Create event successfully!
        </Alert>
      )}
      {isLoading ? (
        <div className="flex justify-center">
          <CircularProgress />
          <p>Loading...</p>
        </div>
      ) : (
        <div className="flex flex-row">
          <div className="flex flex-[7] flex-col gap-[20px]">
            <div className="flex items-center justify-between">
              <p className="my-0 text-[20px]">Title</p>
              <ThemeProvider theme={theme}>
                <TextField
                  label="Title"
                  variant="outlined"
                  style={{ width: "400px" }}
                  type="text"
                  value={title}
                  onChange={(e) => setTitle(e.target.value)}
                />
              </ThemeProvider>
            </div>
            <div className="flex items-center justify-between">
              <p className="my-0 text-[20px]">Standard Price</p>
              <ThemeProvider theme={theme}>
                <TextField
                  label="Standard Price"
                  variant="outlined"
                  type="number"
                  className="w-[400px]"
                  value={standardPrice === 0 ? "" : standardPrice.toString()}
                  onChange={(e) => setStandardPrice(Number(e.target.value))}
                />
              </ThemeProvider>
            </div>
            <div className="flex items-center justify-between">
              <p className="my-0 text-[20px]">VIP Price</p>
              <ThemeProvider theme={theme}>
                <TextField
                  label="VIP Price"
                  variant="outlined"
                  type="number"
                  className="w-[400px]"
                  value={vipPrice === 0 ? "" : vipPrice.toString()}
                  onChange={(e) => setVipPrice(Number(e.target.value))}
                />
              </ThemeProvider>
            </div>
            <div className="flex items-center justify-between">
              <p className="my-0 text-[20px]">Sweetbox Price</p>
              <ThemeProvider theme={theme}>
                <TextField
                  label="Sweetbox Price"
                  variant="outlined"
                  type="number"
                  className="w-[400px]"
                  value={sweetboxPrice === 0 ? "" : sweetboxPrice.toString()}
                  onChange={(e) => setSweetboxPrice(Number(e.target.value))}
                />
              </ThemeProvider>
            </div>
            <div className="flex items-center justify-between">
              <p className="my-0 text-[20px]">Stage Name</p>
              <ThemeProvider theme={theme}>
                <TextField
                  label="Stage Name"
                  variant="outlined"
                  style={{ width: "400px" }}
                  type="text"
                  value={stageName}
                  onChange={(e) => setStageName(e.target.value)}
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
                  type="text"
                  value={location}
                  onChange={(e) => setLocation(e.target.value)}
                />
              </ThemeProvider>
            </div>
            <div className="flex items-center justify-between">
              <p className="my-0 text-[20px]">Duration</p>
              <ThemeProvider theme={theme}>
                <TextField
                  label="Duration"
                  variant="outlined"
                  style={{ width: "400px" }}
                  type="text"
                  value={duration}
                  onChange={(e) => setDuration(e.target.value)}
                />
              </ThemeProvider>
            </div>
            <div className="flex items-center justify-between">
              <p className="my-0 text-[20px]">Event Date</p>
              <ThemeProvider theme={theme}>
                <DatePicker className="w-[400px]" onChange={handleDateChange} />
              </ThemeProvider>
            </div>
          </div>
          <div className="flex-[1]"></div>
          <div className="flex flex-col flex-[7] gap-[20px]">
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
                    MenuProps={{
                      style: {
                        maxHeight: 400,
                      },
                    }}
                  >
                    {provinces.map((province, provinceIndex) => (
                      <MenuItem key={province.code} value={province.name}>
                        {province.name}
                      </MenuItem>
                    ))}
                  </Select>
                </FormControl>
              </ThemeProvider>
            </div>
            <div className="flex items-center justify-between">
              <p className="my-0 text-[20px]">Event Type</p>
              <ThemeProvider theme={theme}>
                <FormControl className="w-[400px]">
                  <InputLabel id="event-type-select-label">
                    Event Type
                  </InputLabel>
                  <Select
                    labelId="event-type-select-label"
                    id="event-type-select"
                    label="Event Type"
                    multiple
                    value={eventTypes}
                    onChange={handleChangeEventType}
                    MenuProps={{
                      style: {
                        maxHeight: 300,
                      },
                    }}
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
            <ThemeProvider theme={theme}>
              <Button
                variant="contained"
                component="label"
                className="flex self-start"
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
      )}
      <div className="mt-[40px] flex justify-center">
        <ThemeProvider theme={theme}>
          <Button
            variant="contained"
            component="label"
            className="flex w-[400px] text-[16px] py-[10px] rounded-[10px]"
            onClick={handleCreateEvent}
          >
            Create Event
          </Button>
        </ThemeProvider>
      </div>
    </Container>
  );
};

export default CreateEventPage;
