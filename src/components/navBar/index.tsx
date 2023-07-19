import { Link } from "react-router-dom";
import { useEffect, useState } from "react";
import clsx from "clsx";
import constants from "../../assets/constants/app.constants";
import style from "./style.module.css";

export default function NavBar() {

  const [navItemStyles, setNavItemStyles] = useState([
    style["nav-item"],
    style["nav-item"],
    style["nav-item"],
    style["nav-item"],
    style["nav-item"],
    style["nav-item"],
    style["nav-item"],
    style["nav-item"],
    style["nav-item"],
  ])

  const getCurrentPathnamePostFix = () => {
    return window.location.pathname.length > 1 
      ? window.location.pathname.slice(-1)
      : "1";
  }

  // Highlight focus navigation item
  const handleNavBar = (pathnamePostfix: string) => {
    let currentStyleIndex = parseInt(pathnamePostfix) - 1
    let newNavItemStyles = navItemStyles.map((item, index) => {
      return currentStyleIndex===index
        ? clsx(style["nav-item"], style.focused)
        : style["nav-item"]
    })
    setNavItemStyles(newNavItemStyles)
  }

  // Reset page title by current pathname
  useEffect(() => {
    document.title = constants.pageTitlePrefix + getCurrentPathnamePostFix()
  }, [navItemStyles])

  // Handle navigation bar at the first time page rendered
  useEffect(() => {
    handleNavBar(getCurrentPathnamePostFix())
  }, [])

  // Handle navigation var on browser popstate
  useEffect(() => {
    window.addEventListener('popstate', e => {
      handleNavBar(getCurrentPathnamePostFix())
    })

    return (
      window.removeEventListener('popstate',  e => {
          handleNavBar(getCurrentPathnamePostFix())
      })
    )
  }, [])

  return (
    <ul className={style.nav}>
      <li>
        <Link className={navItemStyles[0]} onClick={()=>handleNavBar("1")} to={"/"}>Exercise 1</Link>
      </li>
      <li>
        <Link className={navItemStyles[1]} onClick={()=>handleNavBar("2")} to={"/exercise2"}>Exercise 2</Link>
      </li>
      <li>
        <Link className={navItemStyles[2]} onClick={()=>handleNavBar("3")} to={"/exercise3"}>Exercise 3</Link>
      </li>
      <li>
        <Link className={navItemStyles[3]} onClick={()=>handleNavBar("4")} to={"/exercise4"}>Exercise 4</Link>
      </li>
      <li>
        <Link className={navItemStyles[4]} onClick={()=>handleNavBar("5")} to={"exercise5"}>Exercise 5</Link>
      </li>
      <li>
        <Link className={navItemStyles[5]} onClick={()=>handleNavBar("5")} to={"/exercise6"}>Exercise 6</Link>
      </li>
      <li>
        <Link className={navItemStyles[6]} onClick={()=>handleNavBar("7")} to={"/exercise7"}>Exercise 7</Link>
      </li>
      <li>
        <Link className={navItemStyles[7]} onClick={()=>handleNavBar("8")} to={"/exercise8"}>Exercise 8</Link>
      </li>
      <li>
        <Link className={navItemStyles[8]} onClick={()=>handleNavBar("9")} to={"/exercise9"}>Exercise 9</Link>
      </li>
    </ul>
  );
}
