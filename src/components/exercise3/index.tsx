import React, { useState } from "react";

export default function Exercise3() {


  return (
    <div className="checklist-container">
      <p>Your Checklist</p>
      <input type="checkbox" name={"Apple"} value={"Apple"}/>
      <input type="checkbox" name={"Banana"} value={"Banana"} />
      <input type="checkbox" name={"Tea"} value={"Tea"} />
      <input type="checkbox" name={"Coffee"} value={"Coffee"} />
      <div>Items checked are: </div>
      <div className="checked-items"></div>
    </div>
  );
}
