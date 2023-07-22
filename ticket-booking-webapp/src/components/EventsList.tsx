import { Link } from "react-router-dom";
import CardEvent from "./CardEvent";

const EventsList = () => {
  return (
    <div className="flex gap-[24px] justify-center items-center flex-wrap">
      <Link to="/event/3" className="no-underline">
        <CardEvent />
      </Link>
      <Link to="/event/3" className="no-underline">
        <CardEvent />
      </Link>
      <Link to="/event/3" className="no-underline">
        <CardEvent />
      </Link>
      <Link to="/event/3" className="no-underline">
        <CardEvent />
      </Link>
      <Link to="/event/3" className="no-underline">
        <CardEvent />
      </Link>
      <Link to="/event/3" className="no-underline">
        <CardEvent />
      </Link>
    </div>
  );
};

export default EventsList;
