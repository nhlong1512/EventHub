import { useState } from "react";
import { Button, ButtonGroup } from "@mui/material";
import "./style.css"

export default function Exercise4() {
  const [count, setCount] = useState(0);

  return (
    <div className="click-counting-container exercise-container">
      <p>Button has been clicked: <i>{count}</i> times</p>
      <ButtonGroup variant="contained" aria-label="outlined primary button group">
        <Button onClick={() => setCount(count + 1)}>Click me!</Button>
        <Button onClick={() => setCount(0)}>Reset</Button>
      </ButtonGroup>
    </div>
  );
}
