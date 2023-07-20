import React, { useState } from "react";
import "./style.css";

export default function Exercise3() {
  const [checklist, setChecklist] = useState([""]);

  function handleChecklist(e: React.MouseEvent<HTMLInputElement, MouseEvent>) {
    let target: HTMLInputElement = e.target as HTMLInputElement;
    if (target.checked)
      setChecklist((checklist) => [...checklist, target.value]);
    else
      setChecklist((checklist) =>
        checklist.filter((item) => item !== target.value)
      );
  }

  return (
    <div className="checklist-container exercise-container">
      <p>Your Checklist</p>
      <div>
        <div className="checkbox-container">
          <input type="checkbox" value={"Apple"} onClick={handleChecklist} />
          <span>Apple</span>
        </div>
        <div className="checkbox-container">
          <input type="checkbox" value={"Banana"} onClick={handleChecklist} />
          <span>Banana</span>
        </div>
        <div className="checkbox-container">
          <input type="checkbox" value={"Tea"} onClick={handleChecklist} />
          <span>Tea</span>
        </div>
        <div className="checkbox-container">
          <input type="checkbox" value={"Coffee"} onClick={handleChecklist} />
          <span>Coffee</span>
        </div>
      </div>
      <div>Items checked are: </div>
      <ul className="checked-items">
        {checklist.map((item, index) => (
          <li key={index}>{item}</li>
        ))}
      </ul>
    </div>
  );
}
