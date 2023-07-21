import { Button } from "@mui/material";
import { Route, Routes } from "react-router-dom";
import "./App.css";
import Layout from "./components/Layout";
import CreateEventPage from "./pages/CreateEventPage";
import EventDetailPage from "./pages/EventDetailPage";
import HomePage from "./pages/HomePage";
import StatisticPage from "./pages/StatisticPage";

function App() {
  return (
    <Routes>
      <Route path="/" element={<Layout />}>
        <Route path="/" element={<HomePage />} />
        <Route path="/event/3" element={<EventDetailPage />} />
        <Route path="/statistic" element={<StatisticPage />} />
        <Route path="/create-event" element={<CreateEventPage />} />
      </Route>
    </Routes>
  );
}

export default App;
