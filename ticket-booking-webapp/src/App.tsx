import { Button } from "@mui/material";
import { LocalizationProvider } from "@mui/x-date-pickers";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { Route, Routes } from "react-router-dom";
import "./App.css";
import Layout from "./components/Layout";
import CreateEventPage from "./pages/CreateEventPage";
import EventDetailPage from "./pages/EventDetailPage";
import HomePage from "./pages/HomePage";
import StatisticPage from "./pages/StatisticPage";

function App() {
  return (
    <LocalizationProvider dateAdapter={AdapterDayjs}>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route path="/" element={<HomePage />} />
          <Route path="/event/3" element={<EventDetailPage />} />
          <Route path="/statistic" element={<StatisticPage />} />
          <Route path="/create-event" element={<CreateEventPage />} />
        </Route>
      </Routes>
    </LocalizationProvider>
  );
}

export default App;
