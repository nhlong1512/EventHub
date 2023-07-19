import { TextField, Button, Zoom, Alert, Input } from "@mui/material"
import { useEffect, useState } from "react"
import constants from "../../assets/constants/app.constants"
import "./style.css"

export default function Exercise5() {
	const [firstName, setFirstName] = useState("")
	const [lastName, setLastName] = useState("")
	const [fullName, setFullName] = useState("")
	const [disabledSubmit, setDisabledSubmit] = useState(true)
	const [firstNameError, setFirstNameError] = useState(false)
	const [lastNameError, setLastNameError] = useState(false)

	function handleFormOnSubmit() {
		if (isValidInputs()) setFullName(formatFullName())
		else setFullName("")
	}

	function handleInputOnchange(
		value: string,
		setValue: React.Dispatch<React.SetStateAction<string>>
	) {
		if (value.length <= constants.maxNameLength) setValue(value)
		if (fullName) setFullName("")
		if (firstNameError) setFirstNameError(false)
		if (lastNameError) setLastNameError(false)
	}

	// handle if users press enter to submit form
	function handleOnKeyDown(e: React.KeyboardEvent<HTMLFormElement>) {
		if (e.key === "Enter" && !disabledSubmit) handleFormOnSubmit()
	}

	// check if inputs are valid before submit
	function isValidInputs() {
		if (constants.nameRegex.test(firstName) || firstName.includes("  ")) {
			setFirstNameError(true)
			return false
		}
		if (constants.nameRegex.test(lastName) || lastName.includes("  ")) {
			setLastNameError(true)
			return false
		}
		return true
	}

	// Format name (trim and capitalize from first name and last name)
	function formatFullName() {
		let nameArray = firstName.split(" ").concat(lastName.split(" "))
		return nameArray.reduce((acc, ele) => {
			return acc + " " + (ele.charAt(0).toUpperCase() + ele.slice(1)).trim();
		}, "").substring(1)
	}

	// reset disableSubmit on changing inputs
	useEffect(() => {
		setDisabledSubmit(firstName === "" || lastName === "")
	}, [firstName, lastName])

	return (
		<div className="exercise-container form-container">

			<div className="title">Simple form</div>

			<form onKeyDown={e => handleOnKeyDown(e)}>
				<TextField
					id="outlined-basic"
					label="First name"
					variant="outlined"
					margin="dense"
					onChange={e => handleInputOnchange(e.target.value, setFirstName)}
					value={firstName}
					error={firstNameError}
					fullWidth
					autoFocus
				/>

				<TextField
					id="outlined-basic"
					label="Last name"
					variant="outlined"
					margin="dense"
					onChange={e => handleInputOnchange(e.target.value, setLastName)}
					value={lastName}
					error={lastNameError}
					fullWidth
				/>

				<Button
					variant="contained"
					disabled={disabledSubmit}
					onClick={handleFormOnSubmit}
				>
					Greet me
				</Button>
			</form>

			<div className="alert-container">
				<Zoom in={firstNameError || lastNameError} className="alert">
					<Alert severity="error">
						- Name cannot be empty. <br />
						- Name cannot contains numbers, special characters. <br />
						- Name cannot contains only spaces or consecutive spaces.
					</Alert>
				</Zoom>

				<Zoom in={fullName !== ""} className="alert">
					<Alert
						severity="success"
						action={
							<Button color="inherit" size="small" onClick={() => {
								setFullName("")
								setFirstName("")
								setLastName("")
							}}>
								Hide
							</Button>
						}
					>
						Full name is <strong>"{fullName}"</strong>
					</Alert>
				</Zoom>
			</div>
		</div>
	)
}