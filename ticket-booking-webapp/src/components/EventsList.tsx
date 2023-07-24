import { Link } from "react-router-dom";
import { IEvent } from "../models/IEvents";
import CardEvent from "./CardEvent";

interface Props {
  events: IEvent[];
}
const EventsList = ({ events }: Props) => {
  return (
    <div className="flex gap-[24px] justify-center items-center flex-wrap">
      {events.map((event, eventIndex) => (
        <Link to={`/event/${event.id}`} key={event.id} className="no-underline">
          <CardEvent event = {event} />
        </Link>
      ))}
    </div>
  );
};

export default EventsList;
