import { useState } from "react";
import "./style.css"

export default function Exercise4() {
  const [count, setCount] = useState(0);

  return (
    <div className="click-counting-container">
      <p>Button has been clicked: {count} times</p>
      <button onClick={() => setCount(count + 1)}>Click Me!</button>
    </div>
  );
}
