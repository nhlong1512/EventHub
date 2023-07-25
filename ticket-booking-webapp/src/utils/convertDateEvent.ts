export const formatDate = (dateString: string) => {
  const date = new Date(dateString);
  const day = date.getDate().toString().padStart(2, "0");
  const month = (date.getMonth() + 1).toString().padStart(2, "0");
  const year = date.getFullYear().toString();
  return `${day}.${month}.${year}`;
};

export const formatDateEventDetail = (dateString: string) => {
  const options: Intl.DateTimeFormatOptions = {
    weekday: "long",
    year: "numeric",
    month: "long",
    day: "numeric",
  };
  const date = new Date(dateString);
  return date.toLocaleDateString("en-US", options);
};

export const formatDateToStringCreateEvent = (selectedDate: string) => {
  const dateObject = new Date(selectedDate);
  dateObject.setHours(21);
  dateObject.setMinutes(15);
  const formattedDate = dateObject.toISOString().slice(0, 19);
  console.log(formattedDate);
  return formattedDate;
};
